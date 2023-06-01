import { useEffect, useState } from 'react';
import './product-list.css';
import { useNavigate, useSearchParams } from 'react-router-dom';
import { IProduct, IProductResponse } from '../../types/types';
import { fetchCategories, fetchProducts } from '../../services/ApiCalls';
import ProductItem from '../../components/common/product-item';
import Search from '../../components/common/Search';
import Filter from '../../components/common/Filter';

const ProductList = () => {
  const [{data, totalCount }, setProducts] = useState<IProductResponse>({
    data: [],
    totalCount: 1
  });
  const [categories, setCategories] = useState<string[]>([]);
  const [searchParams, setSearchParams] = useSearchParams();
  const [page, setPage] = useState(Number(searchParams.get("page")) || 0);

  useEffect(() => {
    fetchingCategories();
  }, []);

  useEffect(() => {
    fetchingProducts();
  }, [page, searchParams.get("searchParameter"), searchParams.get("filter")]);

  const fetchingCategories = async ( ) => {
const responseOfCategories = await fetchCategories();
    setCategories(responseOfCategories);
  };

  const fetchingProducts = async ( ) => {
    const resonseOfProducts = await fetchProducts(page, searchParams.get("searchParameter")  || "", searchParams.get("filter")  || "");
    setProducts(resonseOfProducts);
  };

  const next = (pageDirection: number) => {
    setPage(page + pageDirection);
    searchParams.set("page", (page + pageDirection).toString());
    setSearchParams(searchParams)
  };

  return (
    <section>
      <div className='products-details'>
        <Search />
        <Filter categories={categories} /> 
        <p>{totalCount} products</p>
      </div>
      <section className='products-container'>
      {data.map(item => <ProductItem key={item.productId} product={item}/>)}
      </section>
      <div className='pagination-container '>
        <button disabled={page == 0} onClick={() => next(-1)}>prev</button>
        <button disabled={(page + 1) * 6 > totalCount} onClick={() => next(1)}>next</button>
      </div>
    </section>
  );
}

export default ProductList;