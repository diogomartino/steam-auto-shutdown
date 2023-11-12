import { useSelector } from 'react-redux';
import { settingsSelector } from '../selectors/app';

const useSettings = () => useSelector(settingsSelector);

export default useSettings;
