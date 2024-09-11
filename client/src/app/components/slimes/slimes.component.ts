import { Component, inject } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { ItemButtonComponent } from '../item-button/item-button.component';
import { CommonModule } from '@angular/common';
import { SlimeService } from '../../services/slime.service';

@Component({
  selector: 'app-slimes',
  standalone: true,
  imports: [MatTabsModule, ItemButtonComponent, CommonModule],
  templateUrl: './slimes.component.html',
  styleUrl: './slimes.component.css'
})
export class SlimesComponent {

  slimeService = inject(SlimeService);

  slimes = this.slimeService.getSlimes();

}
