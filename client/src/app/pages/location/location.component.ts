import { Component, Input, OnInit } from '@angular/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { InfoBlockComponent } from "../../components/info-block/info-block.component";
import { InfoBlockBigComponent } from "../../components/info-block-big/info-block-big.component";
import { Location } from '../../interfaces/location';
import { LocationService } from '../../services/location.service';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';



@Component({
  selector: 'app-location',
  standalone: true,
  imports: [MatTooltipModule, InfoBlockComponent, InfoBlockBigComponent, CommonModule],
  templateUrl: './location.component.html',
  styleUrl: './location.component.css'
})
export class LocationComponent implements OnInit {

  @Input() id!:string;

  constructor(private locationService: LocationService) { }
  locationDetails!: Observable<Location>;

  ngOnInit(): void {
    this.locationDetails = this.locationService.getLocation(this.id);
    this.locationDetails.subscribe((response) => {
      console.log(response);
    },);

  }

}
