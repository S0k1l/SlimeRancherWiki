import { Component } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { ItemButtonComponent } from '../item-button/item-button.component';
import { CommonModule } from '@angular/common';

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}

@Component({
  selector: 'app-resources',
  standalone: true,
  imports: [MatTabsModule, ItemButtonComponent, CommonModule],
  templateUrl: './resources.component.html',
  styleUrl: './resources.component.css'
})

export class ResourcesComponent {

  fruits: Items[] = [
    {id: '1', name: 'Погофрукт', imgUrl: 'fruits/Pogofruit.webp'},
    {id: '2', name: 'Кубниця', imgUrl: 'fruits/Cuberry.webp'},
    {id: '3', name: 'М\'ятне манго', imgUrl: 'fruits/Mint_Mango.webp'},
    {id: '4', name: 'Фазовий лимон', imgUrl: 'fruits/Phase_Lemon.webp'},
    {id: '5', name: 'Колюча груша', imgUrl: 'fruits/Prickle_Pear.webp'},
    {id: '6', name: 'Кукадоба', imgUrl: 'fruits/Kookadoba.webp'},
  ]
  
  veggie: Items[] = [
    {id: '1', name: 'Морква', imgUrl: 'veggie/Carrot.webp'},
    {id: '2', name: 'Ока-ока', imgUrl: 'veggie/Oca_Oca.webp'},
    {id: '3', name: 'Серцебуряк', imgUrl: 'veggie/Heart_Beet.webp'},
    {id: '4', name: 'Срібний пастернак', imgUrl: 'veggie/Silver_Parsnip.webp'},
    {id: '5', name: 'Дивна цибуля', imgUrl: 'veggie/Odd_Onion.webp'},
    {id: '6', name: 'Позолочений імбир', imgUrl: 'veggie/Gilded_Ginger.webp'},
  ]

  meat: Items[] = [
    {id: '1', name: 'Курчатко', imgUrl: 'meats/Chickadoo.webp'},
    {id: '2', name: 'Кур-курочка', imgUrl: 'meats/Hen_Hen.webp'},
    {id: '3', name: 'Півень', imgUrl: 'meats/Roostro.webp'},
    {id: '4', name: 'Кам\'янисте курчатко', imgUrl: 'meats/Stony_Chickadoo.webp'},
    {id: '5', name: 'Кам\'яниста курочка', imgUrl: 'meats/Stony_Hen.webp'},
    {id: '6', name: 'Чагарникове курчатко', imgUrl: 'meats/Briar_Chickadoo.webp'},
    {id: '7', name: 'Чагарникова курочка', imgUrl: 'meats/Briar_Hen.webp'},
    {id: '8', name: 'Фарбоване курчатко', imgUrl: 'meats/Painted_Chickadoo.webp'},
    {id: '9', name: 'Фарбована курочка', imgUrl: 'meats/Painted_Hen.webp'},
    {id: '10', name: 'Старенька курочка', imgUrl: 'meats/Elder_Hen.webp'},
    {id: '9', name: 'Старенький півень', imgUrl: 'meats/Elder_Roostro.webp'},
  ]
}
