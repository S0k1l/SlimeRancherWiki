import { Component, inject, Inject } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { ItemButtonComponent } from '../item-button/item-button.component';
import { CommonModule } from '@angular/common';
import { FoodService } from '../../services/food.service';
import { PlortService } from '../../services/plort.service';

@Component({
  selector: 'app-resources',
  standalone: true,
  imports: [MatTabsModule, ItemButtonComponent, CommonModule],
  templateUrl: './resources.component.html',
  styleUrl: './resources.component.css'
})

export class ResourcesComponent {

  foodService = inject(FoodService);
  plortService = inject(PlortService);

  fruits = this.foodService.getFruits();
  veggie = this.foodService.getVeggies();
  meat = this.foodService.getMeats();

  plorts = this.plortService.getPlorts();
}
