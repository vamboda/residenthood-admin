import React from 'react';
import ReactDOM from 'react-dom/client';
import { Provider } from 'react-redux'
import { useAppSelector } from './app/hooks'

import {store} from './app/configureStore'


const App: React.FC = () => {
  const count = useAppSelector((state: any) => state.appState.value)

  return <>{count}</>
};

const rootElement = document.getElementById('root');
if (rootElement) {
  const root = ReactDOM.createRoot(rootElement);
  root.render(
    <Provider store={store} children={<App />} />
  );
}