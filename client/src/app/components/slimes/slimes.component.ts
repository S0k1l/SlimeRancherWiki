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
  selector: 'app-slimes',
  standalone: true,
  imports: [MatTabsModule, ItemButtonComponent, CommonModule],
  templateUrl: './slimes.component.html',
  styleUrl: './slimes.component.css'
})
export class SlimesComponent {
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
}
