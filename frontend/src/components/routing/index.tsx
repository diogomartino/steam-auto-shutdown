import { Route, Routes } from 'react-router';
import Home from '../../screens/home';

const Routing = () => {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
    </Routes>
  );
};

export default Routing;
