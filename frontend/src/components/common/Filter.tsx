import { SyntheticEvent } from "react";
import { useSearchParams } from "react-router-dom";


export interface IFilterProps {
  categories: string[]
}
const Filter = ({categories} : IFilterProps) => {
  const [searchParams, setSearchParams] = useSearchParams();
    
  const handleChange = (value : string) => {
    if (searchParams.get("filter")) {
        searchParams.delete("filter");
    } else {
        searchParams.set("filter", (value).toString());
    }
    setSearchParams(searchParams)
  }

  return (<div>
    {categories.map(category => (<button onClick={() => handleChange(category)}>{category}</button>))}
  </div>);
};

export default Filter;

