import { Component, inject, Inject } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { ItemButtonComponent } from '../item-button/item-button.component';
import { CommonModule } from '@angular/common';
import { FoodService } from '../../services/food.service';

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

  foodService = inject(FoodService);

  fruits = this.foodService.getFruits();
  veggie = this.foodService.getVeggies();
  meat = this.foodService.getMeats();

  plorts: Items[] = [
    {id: '1', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp'},
    {id: '2', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp'},
    {id: '3', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp'},
    {id: '4', name: 'Фосфорний плорт', imgUrl: 'plorts/PlortPHOSPHOR.webp'},
    {id: '5', name: 'Рад-плорт', imgUrl: 'plorts/PlortRAD.webp'},
    {id: '6', name: 'Бум-плорт', imgUrl: 'plorts/PlortBOOM.webp'},
    {id: '7', name: 'Медовий плорт', imgUrl: 'plorts/PlortHONEY.webp'},
    {id: '8', name: 'Калюжний плорт', imgUrl: 'plorts/PlortPUDDLE.webp'},
    {id: '9', name: 'Кристалевий плорт', imgUrl: 'plorts/PlortCRYSTAL.webp'},
    {id: '10', name: 'Мисливець-плорт', imgUrl: 'plorts/PlortHUNTER.webp'},
    {id: '11', name: 'Квантовий плорт', imgUrl: 'plorts/PlortQUANTUM.webp'},
    {id: '12', name: 'Вогняний плорт', imgUrl: 'plorts/PlortFIRE.webp'},
    {id: '13', name: 'Вихорний плорт', imgUrl: 'plorts/PlortDERVISH.webp'},
    {id: '14', name: 'Ліанний плорт', imgUrl: 'plorts/PlortTANGLE.webp'},
    {id: '15', name: 'Мозаїчний плорт', imgUrl: 'plorts/PlortMOSAIC.webp'},
    {id: '16', name: 'Саблезубий плорт', imgUrl: 'plorts/PlortSABER.webp'},
    {id: '17', name: 'Ртутний плорт', imgUrl: 'plorts/PlortQUICKSILVER.webp'},
    {id: '18', name: 'Золотий плорт', imgUrl: 'plorts/PlortGOLD.webp'},
  ]
}
