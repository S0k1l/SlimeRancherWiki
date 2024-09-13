import { Item } from "./item";

export interface Plort {
    id: number;
    name: string;
    imgUrl: string;
    minPrice: number;
    avgPrice: number;
    maxPrice: number;
    slime: Item;
}
