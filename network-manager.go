package main

import (
	"errors"
	"time"

	"github.com/shirou/gopsutil/net"
)

type NetworkManager struct{}

type Interface struct {
	Index        int
	Name         string
	MTU          int
	HardwareAddr string
	Flags        []string
}

func createNetworkManager() *NetworkManager {
	return &NetworkManager{}
}

func (n *NetworkManager) GetInterfaces() []net.InterfaceStat {
	netInterfaces, err := net.Interfaces()
	if err != nil {
		panic(err)
	}

	return netInterfaces
}

const sampleInterval = 2 * time.Second

func (n *NetworkManager) GetInterfaceDownloadSpeed(mac string) (float64, error) {
	initialStat, err := n.GetIOStatByMac(mac)
	if err != nil {
		return 0, err
	}

	startTime := time.Now()
	endTime := startTime.Add(sampleInterval)
	initialBytesRecv := initialStat.BytesRecv
	totalBytesRecv := uint64(0)

	for time.Now().Before(endTime) {
		stat, err := n.GetIOStatByMac(mac)
		if err != nil {
			return 0, err
		}

		bytesReceivedNow := stat.BytesRecv - initialBytesRecv
		initialBytesRecv = stat.BytesRecv
		totalBytesRecv += bytesReceivedNow

		time.Sleep(100 * time.Millisecond)
	}

	actualEndTime := time.Now()
	elapsedSeconds := actualEndTime.Sub(startTime).Seconds()

	if elapsedSeconds == 0 {
		return 0, nil
	}

	downloadSpeed := float64(totalBytesRecv) / elapsedSeconds

	return downloadSpeed, nil
}

func (n *NetworkManager) GetIOStatByMac(mac string) (net.IOCountersStat, error) {
	interfaceName := n.GetInterfaceByMac(mac).Name

	netInterface, err := net.IOCounters(true)
	if err != nil {
		panic(err)
	}

	stat := net.IOCountersStat{}

	for _, v := range netInterface {
		if v.Name == interfaceName {
			stat = v
		}
	}

	if stat.Name == "" {
		return stat, errors.New("Interface not found")
	}

	return stat, nil
}

func (n *NetworkManager) GetInterfaceByMac(mac string) net.InterfaceStat {
	netInterfaces, err := net.Interfaces()
	if err != nil {
		panic(err)
	}

	for _, v := range netInterfaces {
		if v.HardwareAddr == mac {
			return v
		}
	}

	return net.InterfaceStat{}
}

func (n *NetworkManager) AutoDetectInterface() string {
	netInterface, err := net.IOCounters(true)
	if err != nil {
		panic(err)
	}

	var highestInterfaceName string
	var highestRecieved float64

	for _, v := range netInterface {
		if float64(v.BytesRecv) > highestRecieved {
			highestRecieved = float64(v.BytesRecv)
			highestInterfaceName = v.Name
		}
	}

	interfaces := n.GetInterfaces()

	var highestInterfaceMac string

	for _, v := range interfaces {
		if v.Name == highestInterfaceName {
			highestInterfaceMac = v.HardwareAddr
		}
	}

	return highestInterfaceMac
}
