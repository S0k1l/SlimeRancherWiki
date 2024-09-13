import { CommonModule } from '@angular/common';
import { Component, OnInit, Renderer2, ViewChild } from '@angular/core';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatTooltipModule } from '@angular/material/tooltip';
import { Router, RouterLink } from '@angular/router';
import { ToyService } from '../../services/toy.service';
import { Toy } from '../../interfaces/toy';

@Component({
  selector: 'app-toys',
  standalone: true,
  imports: [MatTableModule, MatSortModule, MatTooltipModule, RouterLink, CommonModule],
  templateUrl: './toys.component.html',
  styleUrl: './toys.component.css'
})
export class ToysComponent implements OnInit {

  id!: string;
  toys = new MatTableDataSource<Toy>([]);

  constructor(private router: Router, private renderer: Renderer2, private toyService: ToyService) { }

  ngOnInit(): void {
    this.toyService.getToysDetails().subscribe((res) =>{
      this.toys.data = res
    })
  }

  displayedColumns: string[] = ['toy', 'slime', 'price'];

  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
    
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

    this.toys.sort = this.sort;

    this.toys.sortingDataAccessor = (item, property) => {
      if (property === 'toy') {
        return item.name;
      } else if (property === 'slime') {
        return item.slime.name;
      } else if (property === 'price') {
        return item.price;
      } else {
        return '';
      }
    };
  }
}
