
import { Link, useNavigate, useParams } from 'react-router-dom';
import { fetchProduct, orderProduct } from '../../services/ApiCalls';
import { IProduct } from '../../types/types';
import { useEffect, useState } from 'react';
import milkImg from "../../assets/milk.png";
import './product-page.css';
import Slider from '../../components/common/slider';

const ProductPage = () => {
  const [{name, description, type, storage}, setProduct] = useState<IProduct>({} as IProduct);
  const [orderQuantity, setOrderQuantity] = useState(0);
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

  const handleSubmit = async () => {
    const res = await orderProduct(productId as string, orderQuantity);
    setProduct(res);
  }

  return (
    <section className='product-page-container'>
        <div className='product-page--details-container'>
          <div>
            <a onClick={() => navigate(-1)}>Back</a>
            <div className='product-page--image-container'>
              <img className='product-page--image' src={milkImg} />
            </div>
          </div>
        <div className='product-page--text-container'>
          <h1>{name}</h1>
          <p>{description}</p>
          <h2>{type}</h2>
          <h5>{storage} liters</h5>
          <Slider storage={storage} orderQuantity={orderQuantity} setOrderQuantity={setOrderQuantity} /> 
          <button onClick={handleSubmit} disabled={storage <= 0}>Add to Cart</button>
        </div>
        </div>
    </section>
  );
}

export default ProductPage;