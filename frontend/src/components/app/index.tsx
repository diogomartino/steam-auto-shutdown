import { useEffect, useRef } from 'react';
import Routing from '../routing';
import { getSteamProcess, loadInterfaces } from '../../actions/app';
import useTheme from '../../hooks/use-theme';
import useSystemMetrics from '../../hooks/use-system-metrics';
import useSystemMonitor from '../../hooks/use-system-monitor';

const App = () => {
  const inited = useRef<boolean>(false);
  useSystemMetrics();
  useTheme();
  useSystemMonitor();

  const initApp = async () => {
    await Promise.all([loadInterfaces(), getSteamProcess()]);
  };

  useEffect(() => {
    if (inited.current) return;

    inited.current = true;
    initApp();
  }, []);

  return <Routing />;
};

export default App;
