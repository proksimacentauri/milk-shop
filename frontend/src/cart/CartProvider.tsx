import { createContext, useEffect, useState } from "react";
import { ICart } from "../types/types";
import { createCart, getCart, addToCart, orderProduct, deleteItemFromCart } from "../services/ApiCalls";

interface CartProviderProps {
    children: React.ReactNode
}

export const CartContext = createContext({});

const CartProvider = ({ children }: CartProviderProps) => {
    const [cart, setCart] = useState<ICart>({
        cartId: "",
        cartItems: []
    });

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
        await addToCart(cartId, productId, quantity);
        fetchCart(cartId);
    }

    const deleteItem =async (cartId: string, itemId : string) => {
        await deleteItemFromCart(cartId, itemId);
        setCart(prevCart => ({
            ...prevCart,
            cartItems: prevCart.cartItems.filter(item => item.itemId !== itemId),
        }))
    }

    const placeOrder = async (cartId:string) => {
        await orderProduct(cartId);
        await creatingCart();
    }

    return (
        <CartContext.Provider value={{cart, fetchCart, addItem, deleteItem, placeOrder}}>
            {children}
        </CartContext.Provider>
    );
}

export default CartProvider;