import { useContext } from "react";
import { CartContext } from "../../cart/CartProvider";
import { CartContextType } from "../../types/types";

const Checkout = () => {
  const { cart } = useContext(CartContext) as CartContextType;
  return (
    <section>
      <div>{cart.cartItems.map(item => <div>{item.product.name}</div>)}</div>
      <button>Place Order</button>
    </section>
  );
}
  
export default Checkout;
