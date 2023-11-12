import { IRootState } from '../store';

export const openModalSelector = (state: IRootState) => state.modals.openModal;

export const modalPropsSelector = (state: IRootState) => state.modals.props;

export const modalIsOpenSelector = (state: IRootState) => state.modals.isOpen;

export const modalsInfoSelector = (state: IRootState) => state.modals;
