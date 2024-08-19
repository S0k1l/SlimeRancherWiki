import { Component, ViewEncapsulation } from '@angular/core';
import { TabGroupComponent } from '../../components/tab-group/tab-group.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [TabGroupComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
  encapsulation: ViewEncapsulation.None,
})



export class HomeComponent {

  activeTabIndex = 0;

  setActiveTab(index: number) {
    this.activeTabIndex = index;
  }

  isActive(index: number) {
    return this.activeTabIndex === index;
  }
}
