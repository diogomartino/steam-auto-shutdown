import { Image, Link } from '@nextui-org/react';
import Logo from '../../assets/icone-steam-bleue.png';
import { DesktopApi } from '../../desktop';

const Header = () => {
  return (
    <div className="flex flex-row justify-center items-center gap-4">
      <Image src={Logo} width="120" height="120" className="p-3" />
      <div>
        <p className="text-3xl">STEAM AUTO SHUTDOWN</p>
        <div className="flex gap-2">
          <p className="text-xs text-gray-500">Version 6.0</p>
          <Link
            href="#"
            className="text-xs text-gray-500"
            onClick={() =>
              DesktopApi.openInBrowser(
                'https://github.com/diogomartino/steam-auto-shutdown'
              )
            }
          >
            Github
          </Link>
        </div>
      </div>
    </div>
  );
};

export default Header;
