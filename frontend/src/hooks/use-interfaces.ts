import { useSelector } from 'react-redux';
import { interfacesSelector } from '../selectors/app';

const useInterfaces = () => useSelector(interfacesSelector);

export default useInterfaces;
