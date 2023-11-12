import * as NetworkManager from './wailsjs/go/main/NetworkManager';
import * as DiskManager from './wailsjs/go/main/DiskManager';
import * as GoApp from './wailsjs/go/main/App';

export const DesktopApi = {
  getInterfaces: NetworkManager.GetInterfaces,
  autoDetectInterface: NetworkManager.AutoDetectInterface,
  getNetworkSpeed: NetworkManager.GetInterfaceDownloadSpeed,
  getProcesses: DiskManager.GetProcesses,
  getDiskWriteSpeed: DiskManager.GetDiskWriteSpeed,
  executeAction: GoApp.ExecuteAction,
  cancelShutdown: GoApp.CancelShutdown,
  openInBrowser: GoApp.OpenInBrowser
};
