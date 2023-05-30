
import { Link, useNavigate, useParams } from 'react-router-dom';
import { fetchProduct } from '../../services/ApiCalls';
import { IProduct } from '../../types/types';
import { useEffect, useState } from 'react';
import milkImg from "../../assets/milk.png";
import './product-page.css';

const ProductPage = () => {
  const [{name, description, type, storage}, setProduct] = useState<IProduct>({} as IProduct);
  const navigate = useNavigate();
  const { productId } = useParams();
  useEffect(() => {
    fetchingProducts();
  }, []);

  const fetchingProducts = async () => {
    const data = await fetchProduct(productId as string);
    console.log(data);
    setProduct(data);  
  };

  return (
    <section className='product-page-container'>
        <div className='product-page--details-container'>
        <a onClick={() => navigate(-1)}>Back</a>
        <div className='product-page--image-container'>
          <img className='product-page--image' src={milkImg} />
        </div>
        <div className='product-page--text-container'>
          <h1>{name}</h1>
          <p>{description}</p>
          <h2>{type}</h2>
          <button disabled={storage < 0}>Add to Cart</button>
        </div>
        </div>
    </section>
  );
}

export default ProductPage;