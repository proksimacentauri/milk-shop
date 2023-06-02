import { useContext } from "react";
import { CartContext } from "../../cart/CartProvider";
import { CartContextType } from "../../types/types";

const Checkout = () => {
  const { cart, placeOrder } = useContext(CartContext) as CartContextType;
  console.log(cart.cartItems);
  return (
    <section>
      <div>{cart.cartItems.map(item => <div>{item.product.name}</div>)}</div>
      <button disabled={cart.cartItems.length == 0} onClick={() => placeOrder(cart.cartId)}>Place Order</button>
    </section>
  );
}
  
export default Checkout;
