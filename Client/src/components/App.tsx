import { useEffect, useState } from 'react';
import '../App.css'
import Header from './Header';
import ProductList from './ProductList';
import { Container, CssBaseline } from '@mui/material';

// const products = [
//     {productId: 1, productName: "product1", productPrice:50, isActive:false},
//     {productId: 2, productName: "product2", productPrice:100, isActive:true},
//     {productId: 3, productName: "product3", productPrice:150, isActive:false}
// ]

function App() {
  const [products, setProducts] = useState([{productId: 1, productName: "product1", productPrice:50, isActive:false},
    {productId: 2, productName: "product2", productPrice:100, isActive:true},
    {productId: 3, productName: "product3", productPrice:150, isActive:false}]);

  useEffect(() => {
    fetch("http://localhost:5198/api/Products").then(response => response.json())
    .then(data => setProducts(data));
  }, []
)
 
  
  return (
    <>
    <CssBaseline />
    <Header />
    <Container>
    <ProductList products={products}/>
    </Container>
    
    </>
  )
}

export default App