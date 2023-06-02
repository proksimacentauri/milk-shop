import { useContext } from "react";
import "./checkout.css";
import { CartContext } from "../../cart/CartProvider";
import { CartContextType } from "../../types/types";
import CartItem from "../../components/common/cart-item";
import { useNavigate } from "react-router-dom";

const Checkout = () => {
  const { cart, placeOrder, deleteItem } = useContext(CartContext) as CartContextType;
  const navigate = useNavigate();

  const placeOrderHandler = ( )=> {
    placeOrder(cart.cartId);
    navigate(`/products`);
  }
  return (
    <section>
      <div>{cart.cartItems.map(item => <CartItem key={item.itemId} deleteItem={deleteItem} item={item} />)}</div>
      <div>
        <button className="checkout--order-btn" disabled={cart.cartItems.length == 0} onClick={() => placeOrderHandler()}>Place Order</button>
      </div>
    </section>
  );
}
  
export default Checkout;
