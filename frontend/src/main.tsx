import React from 'react'
import ReactDOM from 'react-dom/client'
import './index.css'
import {
  createBrowserRouter,
  createRoutesFromElements,
  Navigate,
  Route,
  RouterProvider,
} from "react-router-dom";
import ErrorPage from './routes/error-page.tsx';
import ProductList from './routes/product-list/product-list.tsx';
import RootLayout from './routes/rootlayout.tsx';
import Checkout from './routes/checkout/checkout.tsx';
import ProductPage from './routes/product-page/product-page.tsx';
import CartProvider from './cart/CartProvider.tsx';

const router = createBrowserRouter(createRoutesFromElements(
  <Route path="/" element={<RootLayout />}>
    <Route path='/' element={<Navigate to="/products"/>} />
    <Route index path='/products' element={<ProductList />} />
    <Route path='/productS/:productId' element={<ProductPage />} />
    <Route path='/cart' element={<Checkout />} />
    <Route path='/*' element={<ErrorPage />} />
  </Route>
));

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <React.StrictMode>
    <CartProvider>
      <RouterProvider router={router} fallbackElement={'loading'} />
    </CartProvider>
  </React.StrictMode>,
)