import { CommonModule } from '@angular/common';
import { Component, inject, Input, OnInit } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterLink } from '@angular/router';
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";
import { Slime } from '../../interfaces/slime';
import { SlimeService } from '../../services/slime.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-slime',
  standalone: true,
  imports: [RouterLink, CommonModule, MatTooltipModule, InfoBlockComponent, InfoBlockBigComponent],
  templateUrl: './slime.component.html',
  styleUrl: './slime.component.css',
})
export class SlimeComponent implements OnInit {

  @Input() id!:string;
  slimeService = inject(SlimeService);
  slimeDetails!: Observable<Slime>;

  ngOnInit(): void {
    this.slimeDetails = this.slimeService.getSlime(this.id);
  }
}
