
import { Component, inject } from '@angular/core';
import { InfoBlockDietsComponent } from '../../components/info-block-diets/info-block-diets.component';
import { DietService } from '../../services/diet.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-diets',
  standalone: true,
  imports: [InfoBlockDietsComponent, CommonModule],
  templateUrl: './diets.component.html',
  styleUrl: './diets.component.css'
})
export class DietsComponent {

  dietService = inject(DietService);
  
  dietsDetails = this.dietService.getDiets();
}
