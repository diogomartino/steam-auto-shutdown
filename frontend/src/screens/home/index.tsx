import { Divider } from '@nextui-org/react';
import Header from '../../components/header';
import MonitorSwitch from '../../components/monitor-switch';
import InterfacePicker from '../../components/interface-picker';
import Footer from '../../components/footer';
import TopRightSlot from '../../components/top-right-slot';
import useMonitorStatus from '../../hooks/use-monitor-status';
import { toggleMonitoring } from '../../actions/app';

const Home = () => {
  const isMonitoring = useMonitorStatus();

  const onToggleClick = () => {
    toggleMonitoring();
  };

  return (
    <>
      <TopRightSlot />
      <Header />
      <div className="flex flex-col justify-center items-center h-full gap-3">
        <MonitorSwitch isActive={isMonitoring} setIsActive={onToggleClick} />

        <Divider className="my-4 w-1/4" />

        <div className="flex justify-between w-full">
          <div className="flex justify-center w-full">
            <InterfacePicker />
          </div>
        </div>
      </div>
      <Footer />
    </>
  );
};

export default Home;
