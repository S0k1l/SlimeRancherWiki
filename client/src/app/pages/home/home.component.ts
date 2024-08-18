import { Component, ViewEncapsulation } from '@angular/core';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatTabsModule } from '@angular/material/tabs';
import { RouterLink } from '@angular/router';

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [MatGridListModule, MatTabsModule, RouterLink],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
  encapsulation: ViewEncapsulation.None,
})



export class HomeComponent {

  slimes: Items[] = [
    {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},
    {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},
    {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},
    {id: '4', name: 'Фосфорний слайм', imgUrl: 'slimes/Phosphor_Slime.webp'},
    {id: '5', name: 'Рад-слайм', imgUrl: 'slimes/Rad_Slime.webp'},
    {id: '6', name: 'Бум-слайм', imgUrl: 'slimes/Boom_Slime.webp'},
    {id: '7', name: 'Медовий слайм', imgUrl: 'slimes/Honey_Slime.webp'},
    {id: '8', name: 'Калюжний слайм', imgUrl: 'slimes/Puddle_Slime.webp'},
    {id: '9', name: 'Кристалевий слайм', imgUrl: 'slimes/Crystal_Slime.webp'},
    {id: '10', name: 'Мисливець-слайм', imgUrl: 'slimes/Hunter_Slime.webp'},
    {id: '11', name: 'Квантовий слайм', imgUrl: 'slimes/Quantum_Slime.webp'},
    {id: '12', name: 'Вогняний слайм', imgUrl: 'slimes/Fire_Slime.webp'},
    {id: '13', name: 'Вихорний слайм', imgUrl: 'slimes/Dervish_Slime.webp'},
    {id: '14', name: 'Ліанний слайм', imgUrl: 'slimes/Tangle_Slime.webp'},
    {id: '15', name: 'Мозаїчний слайм', imgUrl: 'slimes/Mosaic_Slime.webp'},
    {id: '16', name: 'Саблезубий слайм', imgUrl: 'slimes/Saber_Slime.webp'},
    {id: '17', name: 'Ртутний слайм', imgUrl: 'slimes/Quicksilver_Slime.webp'},
    {id: '18', name: 'Глітч-слайм', imgUrl: 'slimes/Glitch_Slime.webp'},
    {id: '19', name: 'Золотий слайм', imgUrl: 'slimes/Gold_Slime.webp'},
    {id: '20', name: 'Слайм удачі', imgUrl: 'slimes/Lucky_Slime.webp'},
  ]

  locations: Items[] = [
    {id: '1', name: 'Далекі Далекі Землі', imgUrl: 'locations/Far_Far_Range.webp'},
    {id: '2', name: 'Сухий Риф', imgUrl: 'locations/The_Dry_Reef.webp'},
    {id: '3', name: 'Індиговий Кар\'єр', imgUrl: 'locations/Indigo_Quarry.webp'},
    {id: '4', name: 'Моховий Покрив', imgUrl: 'locations/The_Moss_Blanket.webp'},
    {id: '5', name: 'Стародавні Руїни', imgUrl: 'locations/The_Ancient_Ruins.webp'},
    {id: '6', name: 'Скляна Пустеля', imgUrl: 'locations/The_Glass_Desert.webp'},
    {id: '7', name: 'Дикі Землі', imgUrl: 'locations/The_Wilds.webp'},
    {id: '8', name: 'Швидка Долина', imgUrl: 'locations/Nimble_Valley.webp'},
    {id: '9', name: 'Слаймуляція', imgUrl: 'locations/Slimeulation.webp'},
    {id: '10', name: 'Слаймове Море', imgUrl: 'locations/The_Slime_Sea.webp'},
  ]

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

  activeTabIndex = 0;

  setActiveTab(index: number) {
    this.activeTabIndex = index;
  }

  isActive(index: number) {
    return this.activeTabIndex === index;
  }
}
