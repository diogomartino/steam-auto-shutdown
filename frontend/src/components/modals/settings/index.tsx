import {
  Button,
  Chip,
  Dropdown,
  DropdownItem,
  DropdownMenu,
  DropdownTrigger,
  Input,
  Modal,
  ModalBody,
  ModalContent,
  ModalFooter,
  ModalHeader,
  Tooltip
} from '@nextui-org/react';
import { closeModals } from '../../../actions/modal';
import DiskMonitor from '../../disk-monitor';
import useSettings from '../../../hooks/use-settings';
import { setSettings } from '../../../actions/app';
import { ActionType } from '../../../types';
import { useMemo } from 'react';
import { IconInfoCircle } from '@tabler/icons-react';
import useModalsInfo from '../../../hooks/use-modals-info';

const SettingsModal = () => {
  const { isModalOpen } = useModalsInfo();
  const { speedThreshold, actionDelay, actionType, diskActivityMonitor } =
    useSettings();

  const onChangeSettings = (event) => {
    const { name, value } = event.target;

    setSettings({
      [name]: isNaN(value) ? value : parseInt(value)
    });
  };

  const selectedValue = useMemo(() => {
    switch (actionType) {
      case ActionType.SHUTDOWN:
        return 'Shutdown';
      case ActionType.HIBERNATE:
        return 'Hibernate';
      case ActionType.LOGOFF:
        return 'Logoff';
      case ActionType.SLEEP:
        return 'Sleep';
      default:
        return '';
    }
  }, [actionType]);

  return (
    <Modal
      backdrop="blur"
      isOpen={isModalOpen}
      onClose={closeModals}
      scrollBehavior="inside"
    >
      <ModalContent>
        {(onClose) => (
          <>
            <ModalHeader className="flex gap-1 items-center">
              <p>Settings</p>
              <Tooltip
                className="text-foreground"
                content={
                  <div className="flex flex-col gap-2">
                    <div>
                      <div className="text-small font-bold">
                        Shutdown after x seconds of inactivity
                      </div>
                      <div className="text-tiny">
                        The number of seconds to wait before shutting down the
                        PC after no downloads are active. Using a small value
                        will increase the chance of shutting down while a
                        download is still active.
                      </div>
                    </div>

                    <div>
                      <div className="text-small font-bold">
                        Download speed threshold
                      </div>
                      <div className="text-tiny">
                        The minimum download speed to consider a download
                        active.
                      </div>
                    </div>

                    <div>
                      <div className="text-small font-bold">Monitor disk</div>
                      <div className="text-tiny">
                        Monitors disk activity to prevent shutdowns when a
                        process is writing to disk. This is useful, for example,
                        in case steam is not actively downloading but is writing
                        to disk, like uncompressing game files.
                      </div>
                    </div>

                    <div>
                      <div className="text-small font-bold">
                        Action to perform
                      </div>
                      <div className="text-tiny">
                        The action to perform when no downloads are active.
                        Sleeping is the only action that can be cancelled by the
                        user after it has been triggered.
                      </div>
                    </div>
                  </div>
                }
              >
                <IconInfoCircle size="1rem" />
              </Tooltip>
            </ModalHeader>
            <ModalBody>
              <div className="flex flex-col gap-2">
                <Input
                  type="number"
                  name="actionDelay"
                  size="sm"
                  label="Shutdown after x seconds of inactivity"
                  placeholder="10"
                  onChange={onChangeSettings}
                  min={1}
                  value={actionDelay.toString()}
                  endContent={
                    <Chip radius="sm" size="sm">
                      Seconds
                    </Chip>
                  }
                />
                <Input
                  type="number"
                  name="speedThreshold"
                  size="sm"
                  label="Download speed threshold"
                  placeholder="200"
                  onChange={onChangeSettings}
                  min={1}
                  value={speedThreshold.toString()}
                  endContent={
                    <Chip radius="sm" size="sm">
                      KB/s
                    </Chip>
                  }
                />

                <div className="flex justify-between mt-1">
                  <DiskMonitor
                    value={diskActivityMonitor}
                    onChange={(value) =>
                      setSettings({ diskActivityMonitor: value })
                    }
                  />

                  <div className="flex flex-col gap-1">
                    <p className="text-sm">Action to perform</p>

                    <Dropdown>
                      <DropdownTrigger>
                        <Button variant="bordered" size="sm">
                          {selectedValue || 'Select Network Interface'}
                        </Button>
                      </DropdownTrigger>
                      <DropdownMenu
                        disallowEmptySelection
                        selectionMode="single"
                        selectedKeys={[actionType as string]}
                        onSelectionChange={(selection) => {
                          const [first] = selection;

                          setSettings({
                            actionType: first
                          });
                        }}
                      >
                        <DropdownItem
                          key={ActionType.SHUTDOWN}
                          className="text-foreground"
                        >
                          Shutdown
                        </DropdownItem>
                        <DropdownItem
                          key={ActionType.HIBERNATE}
                          className="text-foreground"
                        >
                          Hibernate
                        </DropdownItem>
                        <DropdownItem
                          key={ActionType.LOGOFF}
                          className="text-foreground"
                        >
                          Logoff
                        </DropdownItem>
                        <DropdownItem
                          key={ActionType.SLEEP}
                          className="text-foreground"
                        >
                          Sleep
                        </DropdownItem>
                      </DropdownMenu>
                    </Dropdown>
                  </div>
                </div>
              </div>
            </ModalBody>
            <ModalFooter>
              <Button
                onPress={() => {
                  setSettings({
                    actionDelay: 20,
                    speedThreshold: 200,
                    actionType: ActionType.SHUTDOWN
                  });
                }}
                size="sm"
              >
                Reset to defaults
              </Button>
              <Button onPress={onClose} size="sm">
                Close
              </Button>
            </ModalFooter>
          </>
        )}
      </ModalContent>
    </Modal>
  );
};

export default SettingsModal;
