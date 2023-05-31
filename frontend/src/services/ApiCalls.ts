import axios from "axios"
import { IProduct, ProductResponse } from "../types/types";

export const fetchProducts : (page: number, searchParameter: string, filter : string) => Promise<ProductResponse> = async (page: number, searchParameter = "", filter : string)  => {
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

export const fetchProduct : (id : string) => Promise<IProduct> = async (id : string) => {
    const response = await axios.get(`http://localhost:5163/api/Products/${id}`);
    return response.data;
}

export const orderProduct : (id : string, quantity: number) => Promise<IProduct> = async (id : string, quantity: number) => {
    const response = await axios.patch(`http://localhost:5163/api/Products/${id}?quantity=${quantity}`);
    return response.data;
}