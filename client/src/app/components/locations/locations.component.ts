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
  selector: 'app-locations',
  standalone: true,
  imports: [MatTabsModule, ItemButtonComponent, CommonModule],
  templateUrl: './locations.component.html',
  styleUrl: './locations.component.css'
})
export class LocationsComponent {
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
}
