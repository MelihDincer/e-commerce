
export interface IProduct {
    productId: number,
    productName: string,
    description?: string,
    productPrice: number,
    isActive: boolean,
    imageUrl?: string,
    stock?: number
}