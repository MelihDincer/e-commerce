import { Card, CardMedia } from "@mui/material";
import { IProduct } from "../model/IProduct";

interface Props {
    product: IProduct
}

function Product({product}: Props) {
    console.log(product.imageUrl
        
    )
    return(
      <>
     <Card>
        {/* 160 yükseklik içerisinde contain kendini responsive bir şekilde ayarlar */}
        <CardMedia sx={{height:160, backgroundSize:"contain"}} image={`http://localhost:5198/images/${product.imageUrl}`}/>
     </Card>
      </>
    )
  }
  export default Product;