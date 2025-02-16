import { ToastContainer } from 'react-toastify';
import '../App.css'
import Header from './Header';
import { Container, CssBaseline } from '@mui/material';
import { Outlet } from 'react-router';
import 'react-toastify/dist/ReactToastify.css';

// const products = [
//     {productId: 1, productName: "product1", productPrice:50, isActive:false},
//     {productId: 2, productName: "product2", productPrice:100, isActive:true},
//     {productId: 3, productName: "product3", productPrice:150, isActive:false}
// ]

function App() {
  return (
    <>
    <ToastContainer position='bottom-right' hideProgressBar theme='colored'/>
    <CssBaseline />
    <Header />
    <Container>
      <Outlet/>
    </Container>
    </>
  )
}

export default App