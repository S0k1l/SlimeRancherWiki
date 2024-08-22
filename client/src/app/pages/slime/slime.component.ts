import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";

interface Item {
  id: string,
  name: string,
  imgUrl: string,
}

interface Diet {
  name: string;
  imgUrl: string;
}

interface Slime{
  name: string;
  imgUrl: string;
  toys: Item | null;
  locations: Item[];
  diet: Diet | null;
  favFood: Item | null;
  plort: Item | null;
}

@Component({
  selector: 'app-slime',
  standalone: true,
  imports: [RouterLink, CommonModule, MatTooltipModule, InfoBlockComponent, InfoBlockBigComponent],
  templateUrl: './slime.component.html',
  styleUrl: './slime.component.css'
})
export class SlimeComponent {

 slime: Slime = {
   name: 'Рожевий слайм',
   imgUrl: 'slimes/Pink_Slime.webp',
   toys: {id: '1', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp'},
   locations: [
    {id: '2', name: 'Сухий Риф', imgUrl: 'locations/The_Dry_Reef.webp'},
    {id: '3', name: 'Індиговий Кар\'єр', imgUrl: 'locations/Indigo_Quarry.webp'},
    {id: '4', name: 'Моховий Покрив', imgUrl: 'locations/The_Moss_Blanket.webp'},
    {id: '5', name: 'Стародавні Руїни', imgUrl: 'locations/The_Ancient_Ruins.webp'},
    {id: '6', name: 'Скляна Пустеля', imgUrl: 'locations/The_Glass_Desert.webp'},
    {id: '7', name: 'Дикі Землі', imgUrl: 'locations/The_Wilds.webp'},
    {id: '8', name: 'Швидка Долина', imgUrl: 'locations/Nimble_Valley.webp'},
    {id: '9', name: 'Слаймуляція', imgUrl: 'locations/Slimeulation.webp'},
    {id: '10', name: 'Слаймове Море', imgUrl: 'locations/The_Slime_Sea.webp'},
   ],
   diet: {name : 'Всеядний', imgUrl: 'diets/All.webp'},
   favFood: null,
   plort: {id: '1', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp'},
 }
}
