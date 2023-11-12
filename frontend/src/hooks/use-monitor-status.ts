import { useSelector } from 'react-redux';
import { monitoringSelector } from '../selectors/app';

const useMonitorStatus = () => useSelector(monitoringSelector);

export default useMonitorStatus;
