import { Link, useNavigate } from 'react-router-dom';
import { IProduct } from '../../types/types';
import milkImg from "../../assets/milk.png";
import './product-item.css';

export interface IProductItemProps {
    product: IProduct
}



const ProductItem = ({ product: { name, type, productId, storage } } : IProductItemProps) => {
  const navigate = useNavigate();
  return (
    <article className='product-item' onClick={() => navigate(`/products/${productId}`)}>    
      <div className='product--image-container'>
        <img className='product-item--image' src={milkImg} />
      </div>
      <div className='product-item--details'>
        <h3>{name}</h3>
        <div className='product-item--description'>
          <h5>{type}</h5>
          <h6>{storage} liter</h6>
        </div>
      </div>
    </article>
  );
}

export default ProductItem;