import { useSelector } from 'react-redux';
import {
  networkSpeedInBytesPerSecondSelector,
  networkSpeedInMegabytesPerSecondSelector
} from '../selectors/app';

const useNetworkSpeedInMegaBytes = () =>
  useSelector(networkSpeedInMegabytesPerSecondSelector);

const useNetworkSpeedInBytes = () =>
  useSelector(networkSpeedInBytesPerSecondSelector);

export { useNetworkSpeedInMegaBytes, useNetworkSpeedInBytes };
