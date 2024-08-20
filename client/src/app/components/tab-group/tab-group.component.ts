import { Component } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { SlimesComponent } from '../slimes/slimes.component';
import { LocationsComponent } from '../locations/locations.component';
import { ResourcesComponent } from '../resources/resources.component';
import { ToysComponent } from "../toys/toys.component";

@Component({
  selector: 'app-tab-group',
  standalone: true,
  imports: [MatTabsModule, SlimesComponent, LocationsComponent, ResourcesComponent, ToysComponent],
  templateUrl: './tab-group.component.html',
  styleUrl: './tab-group.component.css'
})

export class TabGroupComponent {

}
