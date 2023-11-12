import { createSlice } from '@reduxjs/toolkit';
import { net } from '../wailsjs/go/models';
import { ActionType, TProcess, TSettings } from '../types';

const getStoredSettings = () => {
  const stored = JSON.parse(localStorage.getItem('settings') || '{}');

  return {
    theme: stored.theme || 'dark',
    diskActivityMonitor: stored.diskActivityMonitor || false,
    actionDelay: stored.actionDelay || 20,
    actionType: stored.actionType || ActionType.SHUTDOWN,
    speedThreshold: stored.speedThreshold || 200
  } as TSettings;
};

export interface IAppState {
  selectedMac: string | undefined;
  interfaces: net.InterfaceStat[];
  networkSpeed: number;
  diskSpeed: number;
  targetProcess: TProcess | undefined;
  settings: TSettings;
  monitoring: boolean;
  monitorStatusMsg: string;
}

const initialState: IAppState = {
  selectedMac: undefined,
  interfaces: [],
  networkSpeed: 0,
  diskSpeed: 0,
  targetProcess: {
    name: undefined,
    id: undefined
  } as TProcess,
  settings: getStoredSettings(),
  monitoring: false,
  monitorStatusMsg: ''
};

export const appSlice = createSlice({
  name: 'app',
  initialState,
  reducers: {
    setSelectedMac: (state, action) => {
      state.selectedMac = action.payload;
    },
    setInterfaces: (state, action) => {
      state.interfaces = action.payload;
    },
    setNetworkSpeed: (state, action) => {
      state.networkSpeed = action.payload;
    },
    setDiskSpeed: (state, action) => {
      state.diskSpeed = action.payload;
    },
    toggleTheme: (state) => {
      state.settings.theme = state.settings.theme === 'dark' ? 'light' : 'dark';

      localStorage.setItem('settings', JSON.stringify(state.settings));
    },
    setTargetProcess: (state, action) => {
      state.targetProcess = action.payload;
    },
    setSettings: (state, action) => {
      state.settings = {
        ...state.settings,
        ...action.payload
      };

      localStorage.setItem('settings', JSON.stringify(action.payload));
    },
    toggleMonitoring: (state) => {
      state.monitoring = !state.monitoring;
    },
    setMonitorStatusMsg: (state, action) => {
      state.monitorStatusMsg = action.payload;
    }
  }
});

export const appSliceActions = appSlice.actions;

export default appSlice.reducer;
