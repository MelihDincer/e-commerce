import { IProduct } from "../model/IProduct";
import Product from "./Product";

interface Props {
    products: IProduct[];
    addProductHandler: () => void;
}

function ProductList({products, addProductHandler}: Props) {
    return(
      <div>
         {products.map((p:IProduct) => (
          p.isActive &&
          <Product key={p.productId} product={p} />
         ))}
         <button onClick={addProductHandler}>Ekle</button>
      </div>
     
    );
  }

  export default ProductList;