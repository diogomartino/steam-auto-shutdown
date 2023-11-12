import DiskSpeed from '../disk-speed';
import NetworkSpeed from '../network-speed';

const Footer = () => {
  return (
    <div className="absolute bottom-0 bottom-0 flex gap-2 w-full">
      <div className="flex justify-center gap-5 w-full">
        <DiskSpeed />
        <NetworkSpeed />
      </div>
    </div>
  );
};

export default Footer;
