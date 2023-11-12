import { Tooltip } from '@nextui-org/react';

import { IconServer2 } from '@tabler/icons-react';
import useSettings from '../../hooks/use-settings';
import { useDiskSpeedInMegaBytes } from '../../hooks/use-disk-speed';
import useTargetProcess from '../../hooks/use-target-process';

const DiskSpeed = () => {
  const { diskActivityMonitor } = useSettings();
  const diskSpeed = useDiskSpeedInMegaBytes();
  const targetProcess = useTargetProcess();

  const color = diskActivityMonitor ? 'text-gray-500' : 'text-gray-700';

  const tooltipContent = diskActivityMonitor ? (
    <p>
      Disk activity monitor is enabled and scanning for disk activity from{' '}
      {targetProcess?.name}
    </p>
  ) : (
    <p>Disk activity monitor is disabled. You can enable it in the settings.</p>
  );

  return (
    <Tooltip
      color="foreground"
      content={tooltipContent}
      showArrow
      delay={300}
      closeDelay={0}
    >
      <div className={`flex gap-1 items-center ${color}`}>
        <IconServer2 size="0.9rem" />
        <p className="text-sm">{diskSpeed.toFixed(2)} MB/s</p>
      </div>
    </Tooltip>
  );
};

export default DiskSpeed;
