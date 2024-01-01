import {
  Button,
  Modal,
  ModalBody,
  ModalContent,
  ModalFooter,
  ModalHeader
} from '@nextui-org/react';
import { closeModals } from '../../../actions/modal';
import useSettings from '../../../hooks/use-settings';
import { ActionType } from '../../../types';
import { DesktopApi } from '../../../desktop';
import useModalsInfo from '../../../hooks/use-modals-info';

const messageMap = {
  [ActionType.HIBERNATE]: 'Your computer will hibernate in 10 seconds',
  [ActionType.SHUTDOWN]: 'Your computer will shutdown in 10 seconds',
  [ActionType.SLEEP]: 'Your computer will go to sleep in 10 seconds',
  [ActionType.LOGOFF]: 'Your computer log your user off in 10 seconds'
};

const ActionConfirmationModal = () => {
  const { isModalOpen } = useModalsInfo();
  const settings = useSettings();

  const onCancelClick = async () => {
    await DesktopApi.cancelShutdown();
    closeModals();
  };

  return (
    <Modal
      backdrop="blur"
      isOpen={isModalOpen}
      onClose={closeModals}
      scrollBehavior="inside"
    >
      <ModalContent>
        <ModalHeader className="flex gap-1 items-center"></ModalHeader>
        <ModalBody>
          <div className="flex full-w justify-center items-center">
            {messageMap[settings.actionType]}
          </div>
        </ModalBody>
        <ModalFooter className="justify-center">
          <Button
            onPress={onCancelClick}
            size="lg"
            variant="solid"
            color="danger"
          >
            CANCEL NOW
          </Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
};

export default ActionConfirmationModal;
