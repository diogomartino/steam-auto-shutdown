import { Button } from '@nextui-org/react';
import { IconMoon, IconSettings, IconSun } from '@tabler/icons-react';
import { toggleTheme } from '../../actions/app';
import { openModal } from '../../actions/modal';
import { Modal } from '../../types';
import useSelectedTheme from '../../hooks/use-selected-theme';

const TopRightSlot = () => {
  const theme = useSelectedTheme();
  const onToggleThemeClick = () => {
    toggleTheme();
  };

  const onSettingsClick = () => {
    openModal(Modal.SETTINGS);
  };

  return (
    <div className="absolute top-2 right-2 flex gap-2">
      <Button isIconOnly onClick={onToggleThemeClick} size="sm" variant="flat">
        {theme === 'light' ? <IconMoon /> : <IconSun />}
      </Button>

      <Button isIconOnly onClick={onSettingsClick} size="sm" variant="flat">
        <IconSettings />
      </Button>
    </div>
  );
};

export default TopRightSlot;
