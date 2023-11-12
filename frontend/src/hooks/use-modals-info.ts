import { useSelector } from 'react-redux';
import { modalsInfoSelector } from '../selectors/modals';

const useModalsInfo = () => {
  const modalInfo = useSelector(modalsInfoSelector);

  return {
    modalProps: modalInfo.props,
    isModalOpen: modalInfo.isOpen,
    openModal: modalInfo.openModal
  };
};

export default useModalsInfo;
