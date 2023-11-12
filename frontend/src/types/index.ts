export type TTheme = 'light' | 'dark';

export type TGenericObject = {
  [key: string]: any;
};

export enum Modal {
  PROCESS_PICKER = 'PROCESS_PICKER',
  SETTINGS = 'SETTINGS',
  ACTION_CONFIRMATION = 'ACTION_CONFIRMATION'
}

export enum ActionType {
  SHUTDOWN = 'SHUTDOWN',
  HIBERNATE = 'HIBERNATE',
  SLEEP = 'SLEEP',
  LOGOFF = 'LOGOFF'
}

export type TProcess = {
  id: string | undefined;
  name: string | undefined;
};

export type TSettings = {
  theme: TTheme;
  diskActivityMonitor: boolean;
  actionDelay: number; // seconds
  actionType: ActionType;
  speedThreshold: number; // KB/s
};
