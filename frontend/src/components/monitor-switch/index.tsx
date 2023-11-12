import { Card, CardBody, Switch } from '@nextui-org/react';
import useMonitorStatusMsg from '../../hooks/use-monitor-status-msg';
import useSettings from '../../hooks/use-settings';

type TMonitorSwitchProps = {
  isActive: boolean;
  setIsActive: (value: boolean) => void;
};

const MonitorSwitch = ({ isActive, setIsActive }: TMonitorSwitchProps) => {
  const statusMsg = useMonitorStatusMsg();
  const { actionType } = useSettings();

  return (
    <Card className="w-[400px] h-[180px]">
      <CardBody className="flex flex-col justify-center items-center gap-2">
        <Switch isSelected={isActive} onValueChange={setIsActive} size="lg" />
        {isActive ? (
          <>
            <p className="text-primary font-bold">Auto shutdown is enabled</p>
            <p className="text-foreground text-sm text-center">{statusMsg}</p>
            <p className="text-gray-500 text-sm text-center">
              Your network speed is being monitored and your PC will{' '}
              {actionType.toLowerCase()} when no downloads are active.
            </p>
          </>
        ) : (
          <p className="text-gray-500">Auto shutdown is disabled</p>
        )}
      </CardBody>
    </Card>
  );
};

export default MonitorSwitch;
