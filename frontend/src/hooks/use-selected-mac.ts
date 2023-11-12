import { useSelector } from 'react-redux';
import { selectedMacSelector } from '../selectors/app';

const useSelectedMac = () => useSelector(selectedMacSelector);

export default useSelectedMac;
