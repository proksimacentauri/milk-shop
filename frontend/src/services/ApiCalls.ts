import axios from "axios"
import { ICart, ICartItem, IOrder, IProduct, IProductResponse } from "../types/types";

export const fetchProducts : (page: number, searchParameter: string, filter : string) => Promise<IProductResponse> = async (page: number, searchParameter = "", filter : string)  => {
    let url = `http://localhost:5163/api/Products?page=${page}`;
    if (searchParameter != "") {
        url += `&searchParameter=${searchParameter}`;
    }
    if (filter != "") {
        url += `&filter=${filter}`;
    }
    const response = await axios.get(url);
    return response.data;
}

export const fetchCategories : () => Promise<string[]> = async ()  => {
    const response = await axios.get(`http://localhost:5163/api/Products/category`);
    return response.data;
}

export const fetchProduct : (id : string) => Promise<IProduct> = async (id : string) => {
    const response = await axios.get(`http://localhost:5163/api/Products/${id}`);
    return response.data;
}

export const createCart : () => Promise<ICart> = async () => {
    const response = await axios.post(`http://localhost:5163/api/Carts`);
    return response.data;
}

export const getCart : (cartId : string) => Promise<ICart> = async (cartId : string) => {
    const response = await axios.get(`http://localhost:5163/api/Carts/${cartId}`);
    return response.data;
}

export const addToCart : (cartId : string, productId : string, quantity: number) => Promise<IProduct> = async (cartId : string, productId : string, quantity: number) => {
    const response = await axios.post(`http://localhost:5163/api/Carts/${cartId}?productId=${productId}&quantity=${quantity}`);
    return response.data;
}

export const orderProduct : (cartId : string) => Promise<IOrder> = async (cartId : string) => {
    const response = await axios.post(`http://localhost:5163/api/Carts/${cartId}/Order`);
    return response.data;
}

export const deleteItemFromCart : (cartId : string, itemId : string) => Promise<ICartItem> = async (cartId : string, itemId : string) => {
    const response = await axios.delete(`http://localhost:5163/api/Carts/${cartId}/Item/${itemId}`);
    return response.data;
}
