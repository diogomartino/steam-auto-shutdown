import { Switch, Tooltip } from '@nextui-org/react';
import {} from '../../wailsjs/go/models';
import { openModal } from '../../actions/modal';
import { IconListSearch } from '@tabler/icons-react';
import { Modal } from '../../types';
import useTargetProcess from '../../hooks/use-target-process';

const DiskMonitor = ({ value, onChange }) => {
  const targetProcessName = useTargetProcess();

  const onTargetProcessChangeClick = async () => {
    openModal(Modal.PROCESS_PICKER);
  };

  return (
    <div className="flex flex-col gap-2">
      <p className="text-sm">Monitor Disk</p>

      <div className="flex">
        <Switch isSelected={value} onValueChange={onChange} size="sm" name="" />

        <div className="flex items-center gap-1">
          <Tooltip
            showArrow={true}
            color="foreground"
            content="Change the process that is being monitored."
            delay={300}
            closeDelay={0}
          >
            <IconListSearch
              className="text-gray-500"
              size="1rem"
              style={{
                cursor: 'pointer'
              }}
              onClick={onTargetProcessChangeClick}
            />
          </Tooltip>
          <Tooltip
            showArrow={true}
            color="foreground"
            content="This is the process that is being monitored."
            delay={300}
            closeDelay={0}
          >
            <p className="text-gray-500 text-sm">{targetProcessName?.name}</p>
          </Tooltip>
        </div>
      </div>
    </div>
  );
};

export default DiskMonitor;
