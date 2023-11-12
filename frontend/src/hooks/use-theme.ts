import { useSelector } from 'react-redux';
import { themeSelector } from '../selectors/app';
import { useEffect } from 'react';

const mainDarkClasses = ['dark', 'text-foreground', 'bg-background'];

export const useModalContentClassName = () => {
  const theme = useSelector(themeSelector);

  if (theme === 'light') {
    return '';
  }

  return 'dark text-foreground';
};

const useTheme = () => {
  const theme = useSelector(themeSelector);

  useEffect(() => {
    if (theme === 'light') {
      document.body.classList.remove('dark');
      document.body.classList.add('light');

      mainDarkClasses.forEach((c) => {
        document.querySelector('main')?.classList.remove(c);
      });
    } else {
      document.body.classList.remove('light');
      document.body.classList.add('dark');

      mainDarkClasses.forEach((c) => {
        document.querySelector('main')?.classList.add(c);
      });
    }
  }, [theme]);
};

export default useTheme;
