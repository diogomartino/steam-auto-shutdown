import { configureStore } from '@reduxjs/toolkit';
import appSlice from './app-slice';
import modalsSlice from './modals-slice';

export const store = configureStore({
  reducer: {
    app: appSlice,
    modals: modalsSlice
  }
});

export type IRootState = ReturnType<typeof store.getState>;
