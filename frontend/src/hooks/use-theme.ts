import { useSelector } from 'react-redux';
import { themeSelector } from '../selectors/app';
import { useEffect } from 'react';

const useTheme = () => {
  const theme = useSelector(themeSelector);

  useEffect(() => {
    const html = document.querySelector('html');
    if (theme === 'light') {
      html?.classList.remove('dark');
      html?.classList.add('light');
    } else {
      html?.classList.remove('light');
      html?.classList.add('dark');
    }
  }, [theme]);
};

export default useTheme;
