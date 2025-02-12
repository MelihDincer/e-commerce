import { IProduct } from "../model/IProduct";

interface Props {
    product: IProduct
}

function Product({product}: Props) {
    return(
      <>
      <h3>{product.productName}</h3>
      <p>{product.productPrice}₺</p>
      </>
    )
  }
  export default Product;