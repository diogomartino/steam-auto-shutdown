# Steam Auto Shutdown

This is a Windows application that will automatically shutdown your computer when your downloads are finished. Originally it was intended to be used with Steam (ence the name), but it works with any application.

## Download

You can download the latest version from the [releases page](https://github.com/diogomartino/steam-auto-shutdown/releases).

## Instructions

1. Open the application
2. Toggle the switch to enable the shutdown
3. Your computer will shutdown when your downloads are finished

The default settings should work for most people, but you can change them in the settings screen by clicking the gear icon in the top right corner.

## Features

- Shutdown, sleep, hibernate or log off: you choose.
- Uses network traffic to detect when your downloads are finished, so it works with any application.
- Hability to choose the network interface to monitor.
- You can set a delay to shutdown your computer after your downloads are finished.
- You can set a minimum download speed to prevent your computer from shutting down when your downloads are finished but your internet is still being used.
- Disk monitoring to prevent your computer from shutting down when your disk is being used. This is useful when your downloads are finished but your game is still being installed, uncompressed or decrypted. This feature is disabled by default, you can enable it in the settings. This feature works on a process level, so you need to pick the process that you want to monitor (it's the Steam process by default).

## Screenshots

![Screenshot 1](https://i.imgur.com/jlJFmLC.jpg)

## Development

### Requirements

- [Go](https://go.dev/)
- [Wails](https://wails.io/)
- [Node.js](https://nodejs.org/)
- [pnpm](https://pnpm.io/)

```
wails dev
```

This will launch the application in development mode. The interface will also run on http://localhost:34115 in case you want to run it in a browser.

## Building

```
wails build --clean --platform windows/amd64
```

## Contributing

Feel free to contribute to this project by opening issues or pull requests. Please follow the code style of the project.
