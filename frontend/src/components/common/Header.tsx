import { Link } from 'react-router-dom';
import './Header.css';
import { CartContextType } from '../../types/types';
import { useContext } from 'react';
import { CartContext } from '../../cart/CartProvider';

const Header = () => {
  const { cart } = useContext(CartContext) as CartContextType;
  return (
    <header className='header-container'>
      <Link to="/products"><h1>The Milk Store</h1></Link>
      <div className='header-cartlink'><Link to="/cart"><i className="fa-solid fa-cart-shopping" style={{color: "#d689a4"}}><span className='header-cart__qty '>{cart.cartItems.length}</span></i></Link></div>
    </header>
  );
}

export default Header;