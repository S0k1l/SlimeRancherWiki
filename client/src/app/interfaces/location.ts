import { Item } from "./item";

export interface Location {
    id: number;
    name: string;
    imgUrl: string;
    fruits: Item[];
    veggies: Item[];
    meats: Item[];
    slimes: Item[];
}
