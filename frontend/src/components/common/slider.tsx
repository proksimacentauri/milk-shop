import { useState } from "react";

export interface ISliderProps {
    storage: number,
    orderQuantity: number,
    setOrderQuantity: React.Dispatch<React.SetStateAction<number>>
}

const slider = ({storage, orderQuantity, setOrderQuantity} : ISliderProps) => {
  return (
    <>
      <input
        type="range"
        min="0"
        max={storage}
        onChange={(e) => setOrderQuantity(parseInt(e.target.value))}
        value={orderQuantity}
      />
      <div>{orderQuantity}</div>
    </>
  );
};

export default slider;