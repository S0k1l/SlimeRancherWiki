import { Component, inject, Input, OnInit } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { Item } from '../../interfaces/item';
import { FoodService } from '../../services/food.service';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { Food } from '../../interfaces/food';

@Component({
  selector: 'app-food',
  standalone: true,
  imports: [MatTooltipModule, InfoBlockBigComponent, InfoBlockComponent, CommonModule],
  templateUrl: './food.component.html',
  styleUrl: './food.component.css'
})
export class FoodComponent implements OnInit {

  @Input() id!: string;
  foodService = inject(FoodService);
  foodDetails!: Observable<Food>;

  ngOnInit(): void {
    this.foodDetails = this.foodService.getFood(this.id);  
  }




  
}
