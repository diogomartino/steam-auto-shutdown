import { useSelector } from 'react-redux';
import {
  diskSpeedInBytesPerSecondSelector,
  diskSpeedInMegabytesPerSecondSelector
} from '../selectors/app';

const useDiskSpeedInMegaBytes = () =>
  useSelector(diskSpeedInMegabytesPerSecondSelector);

const useDiskSpeedInBytes = () =>
  useSelector(diskSpeedInBytesPerSecondSelector);

export { useDiskSpeedInMegaBytes, useDiskSpeedInBytes };
