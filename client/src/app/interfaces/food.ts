import { Item } from "./item";

export interface Food {
    id: number;
    name: string;
    imgUrl: string;
    slime: Item | null;
    locations: Item[];
    diet: Item;
}
