import { Component, ViewChild, OnInit, Renderer2, AfterViewInit } from '@angular/core';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatTooltipModule } from '@angular/material/tooltip';
import { Router, RouterLink } from '@angular/router';
import { PlortService } from '../../services/plort.service';
import { Plort } from '../../interfaces/plort';

@Component({
  selector: 'app-plorts',
  standalone: true,
  imports: [MatTableModule, MatTooltipModule, MatSortModule, RouterLink],
  templateUrl: './plorts.component.html',
  styleUrl: './plorts.component.css'
})

export class PlortsComponent implements OnInit, AfterViewInit {

  id!: string;

  plorts = new MatTableDataSource<Plort>([]);

  constructor(private router: Router, private renderer: Renderer2, private plortService: PlortService) { }

  ngOnInit(): void {
    this.plortService.getPlortsDetalis().subscribe((res) => {
      this.plorts.data = res;
    });
  }
  
  displayedColumns: string[] = ['plort', 'slime', 'minPrice', 'maxPrice', 'avgPrice'];

  @ViewChild(MatSort) sort!: MatSort;

  async ngAfterViewInit() {

     this.id = this.router.url.split('#')[1];

    setTimeout(() => {
      const element = document.getElementById(this.id);
      if (element) {
        this.renderer.addClass(element, 'highlighted');
        element.scrollIntoView({ behavior: 'smooth', block: 'center', inline: 'center' });

        setTimeout(() => {
          this.renderer.removeClass(element, 'highlighted');
        }, 1000);
      }
    }, 300);

    this.plorts.sort = this.sort;

    this.plorts.sortingDataAccessor = (item, property) => {
      if (property === 'plort') {
        return item.name;
      } else if (property === 'slime') {
        return item.slime.name;
      } else if (property === 'minPrice') {
        return item.minPrice;
      } else if (property === 'maxPrice') {
        return item.maxPrice;
      } else if (property === 'avgPrice') {
        return item.avgPrice;
      } else {
        return '';
      }
    };
  }
}
