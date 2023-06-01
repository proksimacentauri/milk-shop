import axios from "axios"
import { ICart, IProduct, IProductResponse } from "../types/types";

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

export const orderProduct : (cartId : string, productId : string, quantity: number) => Promise<IProduct> = async (cartId : string, productId : string, quantity: number) => {
    const response = await axios.post(`http://localhost:5163/api/Carts/${cartId}?productId=${productId}&quantity=${quantity}`);
    return response.data;
}