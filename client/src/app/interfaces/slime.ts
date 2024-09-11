import { Item } from "./item";

export interface Slime {
    id: number;
    name: string;
    imgUrl: string;
    toy : Item | null;
    locations: Item[] | null;
    diet: Item | null;
    favFood: Item | null;
    plort: Item | null;
}
