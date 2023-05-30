export interface IProduct {
    name: string,
    type: string,
    description: string,
    productId: number,
    storage: number,
}


export interface ProductResponse {
    data: IProduct[],
    totalCount: number,
}