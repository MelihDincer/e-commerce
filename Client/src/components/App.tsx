
import { useEffect, useState } from 'react';
import '../App.css'
import Header from './Header';
import ProductList from './ProductList';

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
 
  function addProductHandler(){
    setProducts([...products, {productId:Date.now(), productName: "product 4", productPrice: 4000, isActive: true}])
  }
  return (
    <>
    <Header products={products} />
    <ProductList products={products} addProductHandler={addProductHandler}/>
    </>
  )
}

export default App