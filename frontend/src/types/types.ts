export interface IProduct {
    name: string,
    type: string,
    description: string,
    productId: number,
    storage: number,
}

export interface IProductResponse {
    data: IProduct[],
    totalCount: number,
}

export interface ICart {
    cartId: string,
    cartItems:  ICartItem[],
}

export interface ICartItem {
    itemId: string,
    cartId: string,
    productId: string,
    product: IProduct,
    quantity: number,
    createdAt: string
}

export interface IOrder {
    id: number,
    orderItems: IProduct[],
    status: string
}
export type CartContextType = {
    cart: ICart;
    addItem: (cartId:string, productId : string, quantity : number) => void;
    placeOrder:(cartId:string) => void;
    deleteItem: (cartId:string, itemId : string) => void;
};