import { useSelector } from 'react-redux';
import { themeSelector } from '../selectors/app';

export const useSelectedTheme = () => useSelector(themeSelector);

export default useSelectedTheme;
