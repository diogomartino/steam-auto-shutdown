import { useSelector } from 'react-redux';
import { targetProcessSelector } from '../selectors/app';

const useTargetProcess = () => useSelector(targetProcessSelector);

export default useTargetProcess;
