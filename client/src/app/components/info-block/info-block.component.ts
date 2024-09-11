import { Component, Input } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-info-block',
  standalone: true,
  imports: [RouterLink, MatTooltipModule],
  templateUrl: './info-block.component.html',
  styleUrl: './info-block.component.css'
})

export class InfoBlockComponent {
 @Input() imgUrl!:string;
 @Input() link!:string | any[] | null | undefined;
 @Input() name!:string;
 @Input() header!:string;
 @Input() fragment!:number | undefined;
}
