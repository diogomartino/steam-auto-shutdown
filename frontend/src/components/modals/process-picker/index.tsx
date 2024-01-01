import {
  Button,
  Input,
  Link,
  Listbox,
  ListboxItem,
  Modal,
  ModalBody,
  ModalContent,
  ModalFooter,
  ModalHeader,
  Spinner
} from '@nextui-org/react';
import { openModal } from '../../../actions/modal';
import { DesktopApi } from '../../../desktop';
import { useEffect, useMemo, useState } from 'react';
import { TProcess } from '../../../types';
import { setTargetProcess } from '../../../actions/app';
import { IconSearch } from '@tabler/icons-react';
import { Modal as ModalList } from '../../../types';
import useModalsInfo from '../../../hooks/use-modals-info';
import useTargetProcess from '../../../hooks/use-target-process';

const ProcessPicker = () => {
  const { isModalOpen } = useModalsInfo();
  const targetProcess = useTargetProcess();
  const [processes, setProcesses] = useState<any[]>([]);
  const [search, setSearch] = useState('');
  const [loading, setLoading] = useState(false);

  const filteredProcesses = useMemo(() => {
    return processes.filter((process) =>
      process.Name.toString()
        .trim()
        .toLowerCase()
        .includes(search.trim().toLowerCase())
    );
  }, [processes, search]);

  const onSearchChange = (event: any) => {
    setSearch(event.target.value);
  };

  const loadProcesses = async () => {
    setLoading(true);

    const processes = await DesktopApi.getProcesses();

    setProcesses(processes);
    setLoading(false);
  };

  useEffect(() => {
    loadProcesses();
  }, []);

  return (
    <Modal
      backdrop="blur"
      isOpen={isModalOpen}
      onClose={() => {
        openModal(ModalList.SETTINGS);
      }}
      scrollBehavior="inside"
    >
      <ModalContent>
        {(onClose) => (
          <>
            <ModalHeader className="flex flex-col gap-3">
              <p>Pick a process to monitor</p>
              <Input
                size="sm"
                variant="underlined"
                label="Search process"
                value={search}
                onChange={onSearchChange}
                startContent={
                  <IconSearch size="0.9rem" className="text-gray-500" />
                }
              />
              <p className="text-gray-500 text-xs">
                The process you pick here will only be used to monitor the disk
                activity.{' '}
                <Link href="#" className="text-xs">
                  Learn more.
                </Link>
              </p>
            </ModalHeader>
            <ModalBody>
              <div
                style={{
                  height: '130px'
                }}
              >
                {loading ? (
                  <div className="flex flex-col justify-center items-center gap-2">
                    <Spinner size="sm" />
                    <p className="text-gray-500 text-sm">
                      Loading processes...
                    </p>
                  </div>
                ) : (
                  <Listbox
                    aria-label="Single selection example"
                    variant="faded"
                    color="primary"
                    disallowEmptySelection
                    selectionMode="single"
                    emptyContent="No processes found."
                    selectedKeys={[targetProcess?.id?.toString() ?? '']}
                    onSelectionChange={(selection) => {
                      const [processId] = selection;

                      const process: TProcess = {
                        id: processId.toString(),
                        name:
                          processes.find((p) => p.Pid.toString() === processId)
                            ?.Name ?? ''
                      };

                      setTargetProcess(process);
                    }}
                  >
                    {filteredProcesses?.map((process) => (
                      <ListboxItem key={process.Pid}>
                        <p>
                          {process.Name}{' '}
                          <span className="text-xs text-gray-500">
                            {process.Pid}
                          </span>
                        </p>
                      </ListboxItem>
                    ))}
                  </Listbox>
                )}
              </div>
            </ModalBody>
            <ModalFooter>
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

export default ProcessPicker;
