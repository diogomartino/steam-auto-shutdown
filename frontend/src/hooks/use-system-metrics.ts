import { selectedMacSelector, targetProcessSelector } from '../selectors/app';
import { useEffect, useRef } from 'react';
import { DesktopApi } from '../desktop';
import { setDiskSpeed, setNetworkSpeed } from '../actions/app';
import { store } from '../store';

const useSystemMetrics = () => {
  const timeout = useRef<number | undefined>(undefined);

  useEffect(() => {
    // we use getState here so we don't need to manage useEffect dependencies
    const loop = async () => {
      const state = store.getState();
      const selectedMac = selectedMacSelector(state);
      const targetProcess = targetProcessSelector(state);

      try {
        const [networkSpeed, diskSpeed] = await Promise.all([
          DesktopApi.getNetworkSpeed(selectedMac || ''),
          DesktopApi.getDiskWriteSpeed(+(targetProcess?.id || 0))
        ]);

        setNetworkSpeed(networkSpeed);
        setDiskSpeed(diskSpeed);
      } catch {
        // Ignore
      }

      clearTimeout(timeout.current);
      timeout.current = setTimeout(loop, 1000);
    };

    clearTimeout(timeout.current);
    loop();

    return () => {
      clearTimeout(timeout.current);
    };
  }, []);
};

export default useSystemMetrics;
