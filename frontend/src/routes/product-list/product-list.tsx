import { useEffect, useState } from 'react';
import './product-list.css';
import { useNavigate, useSearchParams } from 'react-router-dom';
import { IProduct } from '../../types/types';
import { fetchProducts } from '../../services/ApiCalls';
import ProductItem from '../../components/common/product-item';

const ProductList = () => {
  const [products, setProducts] = useState<IProduct[]>([]);
  const navigate = useNavigate();
  const [searchParams, setSearchParams] = useSearchParams();
  const [page, setPage] = useState(Number(searchParams.get("page")) || 0);
  console.log(searchParams.get("page"));

  useEffect(() => {
    fetchingProducts();
  }, [page]);

  const fetchingProducts = async ( ) => {
    const data = await fetchProducts(page);
    setProducts(data);  
  };

  const next = (pageDirection: number) => {
    setPage(page + pageDirection);
    setSearchParams({"page": (page + pageDirection).toString()})
  };

  return (
    <section>
      <div>search</div>
      <div>filter</div>
      <section className='products-container'>
      {products.map(product => <ProductItem key={product.productId} product={product}/>)}
      </section>
      <div className='pagination-container '>
        <button disabled={page == 0} onClick={() => next(-1)}>prev</button>
        <button onClick={() => next(1)}>next</button>
      </div>
    </section>
  );
}

export default ProductList;