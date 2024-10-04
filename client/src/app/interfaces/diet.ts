import { Item } from "./item";

export interface Diet {
    id: number;
    name: string;
    imgUrl: string;
    food: Item[];
}
