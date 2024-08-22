import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';

interface Item {
  id: string,
  name: string,
  imgUrl: string,
}

@Component({
  selector: 'app-info-block-big',
  standalone: true,
  imports: [CommonModule, RouterLink, MatTooltipModule],
  templateUrl: './info-block-big.component.html',
  styleUrl: './info-block-big.component.css'
})
export class InfoBlockBigComponent {
  @Input() header!:string;
  @Input() array!:Item[];
  @Input() path!:string | any[] | null | undefined;

}
