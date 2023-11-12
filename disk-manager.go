package main

import (
	"fmt"
	"time"

	"github.com/shirou/gopsutil/process"
)

type DiskManager struct{}

type Process struct {
	Pid  int32
	Name string
}

func createDiskManager() *DiskManager {
	return &DiskManager{}
}

func getProcessByPID(pid int32) (*process.Process, error) {
	processes, err := process.Processes()
	if err != nil {
		return nil, err
	}

	for _, p := range processes {
		if p.Pid == pid {
			return p, nil
		}
	}

	return nil, fmt.Errorf("No process found with PID: %d", pid)
}

func (d *DiskManager) GetDiskWriteSpeed(processPID int32) (float64, error) {
	process, err := getProcessByPID(processPID)
	if err != nil {
		return 0, err
	}

	initialIOCounters, err := process.IOCounters()
	if err != nil {
		return 0, err
	}

	time.Sleep(sampleInterval)

	finalIOCounters, err := process.IOCounters()
	if err != nil {
		return 0, err
	}

	bytesWritten := finalIOCounters.WriteBytes - initialIOCounters.WriteBytes
	writeDuration := sampleInterval.Seconds()
	if writeDuration == 0 {
		return 0, nil
	}

	writeSpeed := float64(bytesWritten) / writeDuration

	return writeSpeed, nil
}

func (d *DiskManager) GetProcesses() ([]*Process, error) {
	var processList []*Process = make([]*Process, 0)

	processes, err := process.Processes()
	if err != nil {
		return nil, err
	}

	for _, process := range processes {
		name, err := process.Name()
		if err != nil {
			return nil, err
		}

		processList = append(processList, &Process{
			Pid:  process.Pid,
			Name: name,
		})
	}

	return processList, nil
}
