import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material";
import { IProduct } from "../../model/IProduct";
import { AddShoppingCart } from "@mui/icons-material";
import SearchIcon from '@mui/icons-material/Search';
import { Link } from "react-router";

interface Props {
    product: IProduct
}

function Product({product}: Props) {
    return(
      <>
     <Card>
        {/* 160 yükseklik içerisinde contain kendini responsive bir şekilde ayarlar */}
        <CardMedia sx={{height:160, backgroundSize:"contain"}} image={`http://localhost:5198/images/${product.imageUrl}`}/>
        <CardContent>
        {/* h2 etiketi kullanıp h6 boyutunda olsun. */}
          <Typography gutterBottom variant="h6" component="h2" color="text-secondary">
            {product.productName}
            </Typography> 
            <Typography variant="body2" color="warning">
              {(product.productPrice / 100).toFixed(2)} ₺
            </Typography>
        </CardContent>
        <CardActions>
          <Button variant="outlined" startIcon={<AddShoppingCart/>} color="success" size="small">Add to cart</Button>
          <Button variant="outlined" component={Link} to={`/catalog/${product.productId}`} size="small" startIcon={<SearchIcon/>} color="primary">View</Button>
        </CardActions>
     </Card>
      </>
    )
  }
  export default Product;