import { useEffect, useRef } from 'react';
import { store } from '../store';
import {
  diskSpeedInBytesPerSecondSelector,
  networkSpeedInBytesPerSecondSelector,
  settingsSelector
} from '../selectors/app';
import useMonitorStatus from './use-monitor-status';
import { setMonitorStatusMsg } from '../actions/app';
import { openModal } from '../actions/modal';
import { Modal } from '../types';
import { DesktopApi } from '../desktop';

const INTERVAL_MS = 1000;
const IDLE_THRESHOLD = 5;

let idleCounter = 0;
let idleThresholdCounter = 0;

const useSystemMonitor = () => {
  const interval = useRef<number | undefined>(undefined);
  const isMonitoring = useMonitorStatus();

  // we use getState here so we don't need to manage useEffect dependencies
  const monitor = async () => {
    const state = store.getState();
    const { actionDelay, speedThreshold, diskActivityMonitor, actionType } =
      settingsSelector(state);
    const networkSpeedInBytes = networkSpeedInBytesPerSecondSelector(state);
    const diskSpeedInBytes = diskSpeedInBytesPerSecondSelector(state);
    const speedThresholdInBytes = speedThreshold * 1024;
    const isBelowNetworkSpeedThreshold =
      networkSpeedInBytes < speedThresholdInBytes;
    const isBelowDiskSpeedThreshold = diskSpeedInBytes < speedThresholdInBytes;

    // if diskActivityMonitor is enabled, we need to check both network and disk speed
    const isIdle = diskActivityMonitor
      ? isBelowNetworkSpeedThreshold && isBelowDiskSpeedThreshold
      : isBelowNetworkSpeedThreshold;

    if (isIdle) {
      idleCounter += 1;
      idleThresholdCounter = 0;

      setMonitorStatusMsg(
        `No activity detected for ${idleCounter}/${actionDelay} seconds.`
      );
    } else {
      idleThresholdCounter += 1;

      if (idleThresholdCounter >= IDLE_THRESHOLD) {
        idleCounter = 0;
      }

      setMonitorStatusMsg('Download in progress.');
    }

    if (idleCounter >= actionDelay) {
      clearTimeout(interval.current);
      setMonitorStatusMsg('Detected download completion.');
      DesktopApi.executeAction(actionType);
      openModal(Modal.ACTION_CONFIRMATION);
    }
  };

  useEffect(() => {
    if (!isMonitoring) {
      clearTimeout(interval.current);
      return;
    }

    setMonitorStatusMsg('Starting...');
    idleCounter = 0;
    interval.current = setInterval(monitor, INTERVAL_MS);

    return () => {
      clearTimeout(interval.current);
    };
  }, [isMonitoring]);
};

export default useSystemMonitor;
