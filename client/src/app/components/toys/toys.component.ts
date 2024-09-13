import { Component, inject } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { ItemButtonComponent } from '../item-button/item-button.component';
import { CommonModule } from '@angular/common';
import { Item } from '../../interfaces/item';
import { ToyService } from '../../services/toy.service';

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}


@Component({
  selector: 'app-toys',
  standalone: true,
  imports: [MatTabsModule, ItemButtonComponent, CommonModule],
  templateUrl: './toys.component.html',
  styleUrl: './toys.component.css'
})
export class ToysComponent {

  toyService = inject(ToyService);

  toys = this.toyService.getToys();

  // toys: Item[] = [
  //   {id: '1', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp'},
  //   {id: '2', name: 'Великий камінь', imgUrl: 'toys/Big_Rock.webp'},
  //   {id: '3', name: 'Клубок пряжі', imgUrl: 'toys/Yarn_Ball.webp'},
  //   {id: '4', name: 'Нічник', imgUrl: 'toys/Night_Light.webp'},
  //   {id: '5', name: 'Енергоблок', imgUrl: 'toys/Power_Cell.webp'},
  //   {id: '6', name: 'Вибуховий м\'яч', imgUrl: 'toys/Bomb_Ball.webp'},
  //   {id: '7', name: 'Жужільна бджілка', imgUrl: 'toys/Buzzy_Bee.webp'},
  //   {id: '8', name: 'Гумова качечка', imgUrl: 'toys/Rubber_Ducky.webp'},
  //   {id: '9', name: 'Кришталева куля', imgUrl: 'toys/Crystal_Ball.webp'},
  //   {id: '10', name: 'Плюшева курочка', imgUrl: 'toys/Stuffed_Chicken.webp'},
  //   {id: '11', name: 'Кубик-загадка', imgUrl: 'toys/Puzzle_Cube.webp'},
  //   {id: '12', name: 'Вугільна цеглина', imgUrl: 'toys/Charcoal_Brick.webp'},
  //   {id: '13', name: 'Гіроскопічна дзиґа', imgUrl: 'toys/Gyro_Top.webp'},
  //   {id: '14', name: 'Сонячний друг', imgUrl: 'toys/Sol_Mate.webp'},
  //   {id: '15', name: 'Дискокуля', imgUrl: 'toys/Disco_Ball.webp'},
  //   {id: '16', name: 'Стего-друг', imgUrl: 'toys/Stego_Buddy.webp'},
  // ]
}
