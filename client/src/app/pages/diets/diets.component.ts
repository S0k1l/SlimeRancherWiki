import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}

interface Diet {
  name: string
  imgUrl: string,
  food: Items[],
}

@Component({
  selector: 'app-diets',
  standalone: true,
  imports: [CommonModule, MatTooltipModule, RouterLink],
  templateUrl: './diets.component.html',
  styleUrl: './diets.component.css'
})
export class DietsComponent {
  fruit: Diet = {
    name: "Фрукти",
    imgUrl: "diets/Fruit.webp",
    food: [
      {id: '1', name: 'Погофрукт', imgUrl: 'diets/fruits/Pogofruit.webp'},
      {id: '2', name: 'Кубниця', imgUrl: 'diets/fruits/Cuberry.webp'},
      {id: '3', name: 'М\'ятне манго', imgUrl: 'diets/fruits/Mint_Mango.webp'},
      {id: '4', name: 'Фазовий лимон', imgUrl: 'diets/fruits/Phase_Lemon.webp'},
      {id: '5', name: 'Колюча груша', imgUrl: 'diets/fruits/Prickle_Pear.webp'},
      {id: '6', name: 'Кукадоба', imgUrl: 'diets/fruits/Kookadoba.webp'},
    ]
  }

  veggie: Diet = {
    name: "Овочі",
    imgUrl: "diets/Veggie.webp",
    food: [
      {id: '1', name: 'Морква', imgUrl: 'diets/veggie/Carrot.webp'},
      {id: '2', name: 'Ока-ока', imgUrl: 'diets/veggie/Oca_Oca.webp'},
      {id: '3', name: 'Серцебуряк', imgUrl: 'diets/veggie/Heart_Beet.webp'},
      {id: '4', name: 'Срібний пастернак', imgUrl: 'diets/veggie/Silver_Parsnip.webp'},
      {id: '5', name: 'Дивна цибуля', imgUrl: 'diets/veggie/Odd_Onion.webp'},
      {id: '6', name: 'Позолочений імбир', imgUrl: 'diets/veggie/Gilded_Ginger.webp'},
    ]
  }

  meat: Diet = {
    name: "М'ясо",
    imgUrl: "diets/Meat.webp",
    food: [
      {id: '1', name: 'Курчатко', imgUrl: 'diets/meats/Chickadoo.webp'},
      {id: '2', name: 'Кур-курочка', imgUrl: 'diets/meats/Hen_Hen.webp'},
      {id: '3', name: 'Півень', imgUrl: 'diets/meats/Roostro.webp'},
      {id: '4', name: 'Кам\'янисте курчатко', imgUrl: 'diets/meats/Stony_Chickadoo.webp'},
      {id: '5', name: 'Кам\'яниста курочка', imgUrl: 'diets/meats/Stony_Hen.webp'},
      {id: '6', name: 'Чагарникове курчатко', imgUrl: 'diets/meats/Briar_Chickadoo.webp'},
      {id: '7', name: 'Чагарникова курочка', imgUrl: 'diets/meats/Briar_Hen.webp'},
      {id: '8', name: 'Фарбоване курчатко', imgUrl: 'diets/meats/Painted_Chickadoo.webp'},
      {id: '9', name: 'Фарбована курочка', imgUrl: 'diets/meats/Painted_Hen.webp'},
      {id: '10', name: 'Старенька курочка', imgUrl: 'diets/meats/Elder_Hen.webp'},
      {id: '9', name: 'Старенький півень', imgUrl: 'diets/meats/Elder_Roostro.webp'},
    ]
  }
}
