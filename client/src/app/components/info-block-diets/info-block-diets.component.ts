import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';
import { Diet } from '../../interfaces/diet';

@Component({
  selector: 'app-info-block-diets',
  standalone: true,
  imports: [MatTooltipModule, RouterLink, CommonModule],
  templateUrl: './info-block-diets.component.html',
  styleUrl: './info-block-diets.component.css'
})
export class InfoBlockDietsComponent {
  @Input() diet!: Diet;
  @Input() link!:string | null | undefined;
}
