import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './components/app';
import { store } from './store';
import { Provider } from 'react-redux';
import { NextUIProvider } from '@nextui-org/react';
import './main.css';
import ModalsProvider from './components/modals';

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <NextUIProvider>
      <Provider store={store}>
        <ModalsProvider />
        <App />
      </Provider>
    </NextUIProvider>
  </React.StrictMode>
);
