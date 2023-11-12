import { appSliceActions } from '../store/app-slice';
import { store } from '../store';
import { DesktopApi } from '../desktop';
import { TProcess } from '../types';

export const setSelectedMac = (mac: string | undefined) => {
  store.dispatch(appSliceActions.setSelectedMac(mac));
};

export const setNetworkSpeed = (speed: number | undefined) => {
  store.dispatch(appSliceActions.setNetworkSpeed(speed || 0));
};

export const setDiskSpeed = (speed: number | undefined) => {
  store.dispatch(appSliceActions.setDiskSpeed(speed || 0));
};

export const setSettings = (settings: any) => {
  store.dispatch(appSliceActions.setSettings(settings));
};

export const toggleMonitoring = () => {
  store.dispatch(appSliceActions.toggleMonitoring());
};

export const toggleTheme = () => {
  store.dispatch(appSliceActions.toggleTheme());
};

export const setTargetProcess = (process: TProcess) => {
  store.dispatch(appSliceActions.setTargetProcess(process));
};

export const setMonitorStatusMsg = (msg: string) => {
  store.dispatch(appSliceActions.setMonitorStatusMsg(msg));
};

export const loadInterfaces = async () => {
  const results = await DesktopApi.getInterfaces();

  store.dispatch(appSliceActions.setInterfaces(results));

  try {
    const detectedMac = await DesktopApi.autoDetectInterface();

    if (detectedMac) {
      setSelectedMac(detectedMac);
    }
  } catch {
    // do nothing
  }
};

export const getSteamProcess = async () => {
  const processes = await DesktopApi.getProcesses();

  const result = processes?.find((p) => p.Name === 'steam.exe');

  if (!result) return;

  const process: TProcess = {
    id: result.Pid,
    name: result.Name
  };

  setTargetProcess(process);
};
