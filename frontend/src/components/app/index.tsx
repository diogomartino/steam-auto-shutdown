import { useEffect, useRef } from 'react';
import { getSteamProcess, loadInterfaces } from '../../actions/app';
import useTheme from '../../hooks/use-theme';
import useSystemMetrics from '../../hooks/use-system-metrics';
import useSystemMonitor from '../../hooks/use-system-monitor';
import Home from '../../screens/home';

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

  return <Home />;
};

export default App;
