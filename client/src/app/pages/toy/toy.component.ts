import { Component } from '@angular/core';
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";
import { MatTooltipModule } from '@angular/material/tooltip';

interface Item {
  id: string,
  name: string,
  imgUrl: string,
}

interface Toy{
  id: string,
  name: string,
  imgUrl: string,
  slime: Item,
  price: string,
}


@Component({
  selector: 'app-toy',
  standalone: true,
  imports: [InfoBlockComponent, InfoBlockBigComponent, MatTooltipModule],
  templateUrl: './toy.component.html',
  styleUrl: './toy.component.css'
})

export class ToyComponent {
  toy: Toy = {
    id: '1', 
    name: 'Пляжний м\'яч', 
    imgUrl: 'toys/Beach_Ball.webp',
    slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},
    price: "300",
  };
}
