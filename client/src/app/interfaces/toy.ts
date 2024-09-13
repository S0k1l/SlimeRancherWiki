import { Item } from "./item";

export interface Toy {
    id: number;
    name: string;
    imgUrl: string;
    price: number;
    slime: Item;
}
