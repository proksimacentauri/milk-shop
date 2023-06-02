import { useNavigate } from 'react-router-dom';
import { ICartItem } from '../../types/types';
import milkImg from "../../assets/milk.png";
import './cart-item.css';

export interface ICartItemProps {
    item: ICartItem,
    deleteItem: (cartId:string, itemId : string) => void,
}

const CartItem = ({ item: { productId, cartId, itemId, quantity,  product: { name, type } }, deleteItem} : ICartItemProps) => {
  const navigate = useNavigate();
  return (
    <article className='cart-item'>    
      <div className='cart--image-container'>
        <img className='cart-item--image' src={milkImg} />
      </div>
      <div onClick={() => navigate(`/products/${productId}`)} className='cart-item--details'>
        <h3>{name}</h3>
        <h5>{type}</h5>
        <h5>{quantity} liters</h5>'
      </div>
      <div className='cart-item--delete-btn-container'>
        <button onClick={() => deleteItem(cartId, itemId)} className='cart-item--delete-btn'>delete</button>
      </div>
    </article>
  );
}

export default CartItem;