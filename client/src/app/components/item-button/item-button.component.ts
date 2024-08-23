import { Component, Input } from '@angular/core';
import { RouterLink } from '@angular/router';

interface Items {
  id: string,
  name: string,
  imgUrl: string,
}

@Component({
  selector: 'app-item-button',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './item-button.component.html',
  styleUrl: './item-button.component.css'
})
export class ItemButtonComponent {
  @Input() item!: Items;
  @Input() routePath!: string | any[] | null | undefined;
  @Input() fragment!:string | undefined;
}
