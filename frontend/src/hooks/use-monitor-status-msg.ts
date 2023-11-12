import { useSelector } from 'react-redux';
import { monitorStatusMsgSelector } from '../selectors/app';

const useMonitorStatusMsg = () => useSelector(monitorStatusMsgSelector);

export default useMonitorStatusMsg;
