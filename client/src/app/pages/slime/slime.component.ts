import { CommonModule } from '@angular/common';
import { Component, inject, OnInit } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";
import { Slime } from '../../interfaces/slime';
import { SlimeService } from '../../services/slime.service';

@Component({
  selector: 'app-slime',
  standalone: true,
  imports: [RouterLink, CommonModule, MatTooltipModule, InfoBlockComponent, InfoBlockBigComponent],
  templateUrl: './slime.component.html',
  styleUrl: './slime.component.css',
})
export class SlimeComponent implements OnInit {

  id!:number;
  slimeService = inject(SlimeService);
  slime!: Slime;

  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
        this.id = +params['id'];
        this.getSlime(this.id);
      });
  }

  getSlime(id: number){
    this.slimeService.getSlime(id).subscribe(
      (response) => {
        this.slime = response;
      },
      (error) => {
        console.error('Error fetching data by ID:', error);
      }
    );
  }
}
