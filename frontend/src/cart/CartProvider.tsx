import { createContext, useEffect, useState } from "react";
import { ICart } from "../types/types";
import { createCart, getCart, orderProduct } from "../services/ApiCalls";

interface CartProviderProps {
    children: React.ReactNode
}

export const CartContext = createContext({});

const CartProvider = ({ children }: CartProviderProps) => {
    const [cart, setCart] = useState<ICart>({} as ICart);

    useEffect(() => {
        if (!localStorage.getItem('cart')) {
            creatingCart();
        } else {
            fetchCart(JSON.parse(localStorage.getItem('cart') || ''));
        }   
    }, []);

    const creatingCart = async () => {
        var res = await createCart();
        setCart(res);
        localStorage.setItem('cart', JSON.stringify(res.cartId));
    }

    const fetchCart = async (cartid:string) => {
        var res = await getCart(cartid);
        setCart(res);
    }

    const addItem = async (cartId:string, productId : string, quantity : number) => {
        var res = await orderProduct(cartId, productId, quantity);
        fetchCart(cartId);
    }

    return (
        <CartContext.Provider value={{cart, fetchCart, addItem}}>
            {children}
        </CartContext.Provider>
    );
}

export default CartProvider;