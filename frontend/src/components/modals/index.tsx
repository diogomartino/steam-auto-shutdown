import { Modal } from '../../types';
import ProcessPicker from './process-picker';
import { createElement } from 'react';
import SettingsModal from './settings';
import ActionConfirmationModal from './action-confirmation';
import useModalsInfo from '../../hooks/use-modals-info';

const ModalsMap = {
  [Modal.PROCESS_PICKER]: ProcessPicker,
  [Modal.SETTINGS]: SettingsModal,
  [Modal.ACTION_CONFIRMATION]: ActionConfirmationModal
};

const ModalsProvider = () => {
  const { openModal, modalProps } = useModalsInfo();

  if (!openModal || !ModalsMap[openModal]) return null;

  return createElement(ModalsMap[openModal], modalProps);
};

export default ModalsProvider;
