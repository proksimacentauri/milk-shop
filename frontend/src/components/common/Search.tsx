import { KeyboardEvent , useState } from "react";
import { useSearchParams } from "react-router-dom";

const search = () => {
  const [searchParams, setSearchParams] = useSearchParams();
  const [searchValue, setSearchValue] = useState(searchParams.get("searchParameter") || "");
  
  const handleChange = (event: KeyboardEvent<HTMLInputElement> ) => {
    const target = event.target as HTMLInputElement;
    if (event.key == "Enter")
    {
      searchParams.set("searchParameter", (target.value).toString());
      setSearchParams(searchParams)
    }
  }

  return (
  <input
    onChange={(event) => setSearchValue(event.target.value)}
    onKeyDown={(event) => handleChange(event)} 
    type="text"
    value={searchValue}
  />);
};

export default search;

