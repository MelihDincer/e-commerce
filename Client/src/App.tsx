
import { useEffect, useState } from 'react';
import './App.css'

const products = [
    {productId: 1, productName: "product1", productPrice:50, isActive:false},
    {productId: 2, productName: "product2", productPrice:100, isActive:true},
    {productId: 3, productName: "product3", productPrice:150, isActive:false}
]

function App() {

  return (
    <>
    <Header />
    <ProductList />
    </>
  )
}

function Header() {
  return(
    <h1>Başlık</h1>
  );
}



function ProductList() {

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
  return(
    <div>
       {products.map((p) => (
        p.isActive &&
        <Product key={p.productId} product={p} />
       ))}
       <button onClick={addProductHandler}>Ekle</button>
    </div>
   
  );
}

function Product(props: any) {
  return(
    <>
    <h3>{props.product.productName}</h3>
    <p>{props.product.productPrice}₺</p>
    </>
  )
}

export default App



