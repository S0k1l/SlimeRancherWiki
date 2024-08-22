import { Component } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";
import { InfoBlockComponent } from "../../components/info-block/info-block.component";

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}

interface Diet {
  name: string;
  imgUrl: string;
}

interface Food {
  id: string,
  name: string,
  imgUrl: string,
  diet: Diet,
  slime: Items | null,
  Locations: Items[],
}

@Component({
  selector: 'app-food',
  standalone: true,
  imports: [MatTooltipModule, InfoBlockBigComponent, InfoBlockComponent],
  templateUrl: './food.component.html',
  styleUrl: './food.component.css'
})
export class FoodComponent {
 food: Food = {
  id: '1', 
  name: 'Погофрукт', 
  imgUrl: 'diets/fruits/Pogofruit.webp',
  diet: {name: 'Фрукти', imgUrl: 'diets/Fruit.webp'},
  slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},
  Locations: [
    {id: '1', name: 'Далекі Далекі Землі', imgUrl: 'locations/Far_Far_Range.webp'},
    {id: '2', name: 'Сухий Риф', imgUrl: 'locations/The_Dry_Reef.webp'},
    {id: '3', name: 'Індиговий Кар\'єр', imgUrl: 'locations/Indigo_Quarry.webp'},
    {id: '4', name: 'Моховий Покрив', imgUrl: 'locations/The_Moss_Blanket.webp'},
    {id: '5', name: 'Стародавні Руїни', imgUrl: 'locations/The_Ancient_Ruins.webp'},
    {id: '6', name: 'Скляна Пустеля', imgUrl: 'locations/The_Glass_Desert.webp'},
  ],
};
}
