import { createSlice } from '@reduxjs/toolkit';
import { Modal, TGenericObject } from '../types';

export interface IAppState {
  openModal: Modal | undefined;
  props?: TGenericObject;
  isOpen: boolean;
}

const initialState: IAppState = {
  openModal: undefined,
  props: {},
  isOpen: false
};

export const appSlice = createSlice({
  name: 'modals',
  initialState,
  reducers: {
    setOpenModal: (state, action) => {
      state.openModal = action.payload;
    },
    setModalProps: (state, action) => {
      state.props = action.payload;
    },
    setIsOpen: (state, action) => {
      state.isOpen = action.payload;
    },
    setModalInfo: (state, action) => {
      state.openModal = action.payload.modal;
      state.props = action.payload.props;
    }
  }
});

export const modalsSliceActions = appSlice.actions;

export default appSlice.reducer;
