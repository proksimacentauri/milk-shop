import { SyntheticEvent } from "react";
import { useSearchParams } from "react-router-dom";

const Categories = ["Cashew milk", "Pea milk", "Walnut milk"];

const Filter = () => {
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
    {Categories.map(category => (<button onClick={() => handleChange(category)}>{category}</button>))}
  </div>);
};

export default Filter;

