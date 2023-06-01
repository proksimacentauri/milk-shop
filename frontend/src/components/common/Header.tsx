import { Link, NavLink } from 'react-router-dom';
import './Header.css';

const Header = () => {
  return (
    <header className='header-container'>
      <Link to="/products"><h1>The Milk Store</h1></Link>
      <div className='header-cartlink'><Link to="/cart">cart</Link></div>
    </header>
  );
}

export default Header;