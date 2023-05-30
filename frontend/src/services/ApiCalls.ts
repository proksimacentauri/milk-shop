import axios from "axios"
import { IProduct } from "../types/types";

export const fetchProducts : (page: number) => Promise<IProduct[]> = async (page: number) => {
    const response = await axios.get(`http://localhost:5163/api/Products?page=${page}`);
    return response.data;
}

export const fetchProduct : (id : string) => Promise<IProduct> = async (id : string) => {
    const response = await axios.get(`http://localhost:5163/api/Products/${id}`);
    return response.data;
}