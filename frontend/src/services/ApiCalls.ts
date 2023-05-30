import axios from "axios"
import { IProduct, ProductResponse } from "../types/types";

export const fetchProducts : (page: number, searchParameter: string) => Promise<ProductResponse> = async (page: number, searchParameter = "")  => {
  
    if (searchParameter == "") {
        const response = await axios.get(`http://localhost:5163/api/Products?page=${page}`);
        return response.data;
    }
    const response = await axios.get(`http://localhost:5163/api/Products?searchParameter=${searchParameter}&page=${page}`);
    return response.data;
}

export const fetchProduct : (id : string) => Promise<IProduct> = async (id : string) => {
    const response = await axios.get(`http://localhost:5163/api/Products/${id}`);
    return response.data;
}