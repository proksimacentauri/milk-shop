import { useRef, useState } from "react";
import { useSearchParams } from "react-router-dom";

const Search = () => {
  const [searchParams, setSearchParams] = useSearchParams();

  return (<input
    onChange={(e) => setSearchParams({"searchParameter": (e.target.value).toString()})} 
    type="text"
    value={searchParams.get("searchParameter")  || ""}
  />);
};

export default Search;
