package main

import (
	"context"
	"fmt"
	"os/exec"
)

// App struct
type App struct {
	ctx context.Context
}

// NewApp creates a new App application struct
func NewApp() *App {
	return &App{}
}

// startup is called at application startup
func (a *App) startup(ctx context.Context) {
	// Perform your setup here
	a.ctx = ctx
}

// domReady is called after front-end resources have been loaded
func (a App) domReady(ctx context.Context) {
	// Add your action here
}

// beforeClose is called when the application is about to quit,
// either by clicking the window close button or calling runtime.Quit.
// Returning true will cause the application to continue, false will continue shutdown as normal.
func (a *App) beforeClose(ctx context.Context) (prevent bool) {
	return false
}

// shutdown is called at application termination
func (a *App) shutdown(ctx context.Context) {
	// Perform your teardown here
}

const secondsToWait = "10"

func (a *App) ExecuteAction(actionName string) {
	var cmd *exec.Cmd

	switch actionName {
	case "SHUTDOWN":
		cmd = exec.Command("shutdown", "/s", "/t", secondsToWait)
	case "RESTART":
		cmd = exec.Command("shutdown", "/r", "/t", secondsToWait)
	case "SLEEP":
		cmd = exec.Command("rundll32.exe", "powrprof.dll,SetSuspendState", "0")
	case "LOGOFF":
		cmd = exec.Command("shutdown", "/l", "/t", secondsToWait)
	case "HIBERNATE":
		cmd = exec.Command("shutdown", "/h", "/t", secondsToWait)
	default:
		fmt.Println("Unknown action:", actionName)
		return
	}

	err := cmd.Run()
	if err != nil {
		fmt.Println("Error executing command:", err)
	}
}

func (a *App) CancelShutdown() {
	cmd := exec.Command("shutdown", "/a")
	err := cmd.Run()
	if err != nil {
		fmt.Println("Error executing command:", err)
	}
}

func (a *App) OpenInBrowser(url string) {
	cmd := exec.Command("cmd", "/c", "start", url)
	err := cmd.Run()
	if err != nil {
		fmt.Println("Error executing command:", err)
	}
}
