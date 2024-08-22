import { Component } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}

interface Location {
  id: string,
  name: string,
  imgUrl: string,
  meat : Items[],
  veggie: Items[],
  fruits: Items[],
  slimes: Items[],
}

@Component({
  selector: 'app-location',
  standalone: true,
  imports: [MatTooltipModule, InfoBlockComponent, InfoBlockBigComponent],
  templateUrl: './location.component.html',
  styleUrl: './location.component.css'
})
export class LocationComponent {

  location: Location = {
    id: '2', 
    name: 'Сухий Риф', 
    imgUrl: 'locations/The_Dry_Reef.webp',
    meat:[
      {id: '2', name: 'Кур-курочка', imgUrl: 'diets/meats/Hen_Hen.webp'},
      {id: '3', name: 'Півень', imgUrl: 'diets/meats/Roostro.webp'},
      {id: '4', name: 'Кам\'янисте курчатко', imgUrl: 'diets/meats/Stony_Chickadoo.webp'},
    ],
    fruits: [
      {id: '1', name: 'Погофрукт', imgUrl: 'diets/fruits/Pogofruit.webp'},
      {id: '2', name: 'Кубниця', imgUrl: 'diets/fruits/Cuberry.webp'},
    ],
    veggie: [
      {id: '1', name: 'Морква', imgUrl: 'diets/veggie/Carrot.webp'},
      {id: '2', name: 'Ока-ока', imgUrl: 'diets/veggie/Oca_Oca.webp'},
      {id: '3', name: 'Серцебуряк', imgUrl: 'diets/veggie/Heart_Beet.webp'},
      {id: '4', name: 'Срібний пастернак', imgUrl: 'diets/veggie/Silver_Parsnip.webp'},
    ],
    slimes: [
      {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},
      {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},
      {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},
      {id: '4', name: 'Фосфорний слайм', imgUrl: 'slimes/Phosphor_Slime.webp'},
      {id: '5', name: 'Рад-слайм', imgUrl: 'slimes/Rad_Slime.webp'},
      {id: '6', name: 'Бум-слайм', imgUrl: 'slimes/Boom_Slime.webp'},
      {id: '7', name: 'Медовий слайм', imgUrl: 'slimes/Honey_Slime.webp'},
    ],
  };
}
