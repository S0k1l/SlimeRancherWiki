import { Component, ViewChild, OnInit } from '@angular/core';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatTooltipModule } from '@angular/material/tooltip';
import { NavigationEnd, Router, RouterLink } from '@angular/router';
interface Item {
  id: string,
  name: string,
  imgUrl: string,
}

interface Plorts{
  id: string;
  name: string;
  imgUrl: string;
  minPrice: string;
  maxPrice: string;
  avgPrice: string;
  slime: Item;
}

@Component({
  selector: 'app-plorts',
  standalone: true,
  imports: [MatTableModule, MatTooltipModule, MatSortModule, RouterLink],
  templateUrl: './plorts.component.html',
  styleUrl: './plorts.component.css'
})
export class PlortsComponent implements OnInit  {

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        const fragment = this.router.url.split('#')[1];
        if (fragment) {
          setTimeout(() => {
            document.getElementById(fragment)?.scrollIntoView({ behavior: 'smooth' });
          }, 100);  // Adjust the timeout if needed
        }
      }
    });
  }

  displayedColumns: string[] = ['plort', 'slime', 'minPrice', 'maxPrice', 'avgPrice'];
  plortsQ: Plorts[] = [
    {id: '1', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp', minPrice: '300', maxPrice: '350', avgPrice: '325', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},},
    {id: '2', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp', minPrice: '400', maxPrice: '450', avgPrice: '425', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},},
    {id: '3', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp', minPrice: '500', maxPrice: '550', avgPrice: '525', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},},
    {id: '4', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp', minPrice: '300', maxPrice: '350', avgPrice: '325', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},},
    {id: '5', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp', minPrice: '400', maxPrice: '450', avgPrice: '425', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},},
    {id: '6', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp', minPrice: '500', maxPrice: '550', avgPrice: '525', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},},
    {id: '7', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp', minPrice: '300' ,maxPrice: '350', avgPrice: '325', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},},
    {id: '8', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp', minPrice: '400', maxPrice: '450', avgPrice: '425', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},},
    {id: '9', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp', minPrice: '500', maxPrice: '550', avgPrice: '525', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},},
    {id: '10', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp', minPrice: '300' , maxPrice: '350', avgPrice: '325', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},},
    {id: '11', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp', minPrice: '400', maxPrice: '450', avgPrice: '425', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},},
    {id: '12', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp', minPrice: '500', maxPrice: '550', avgPrice: '525', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},},
    {id: '13', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp', minPrice: '300' , maxPrice: '350', avgPrice: '325', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},},
    {id: '14', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp', minPrice: '400', maxPrice: '450', avgPrice: '425', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},},
    {id: '15', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp', minPrice: '500', maxPrice: '550', avgPrice: '525', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},},
    {id: '16', name: 'Рожевий плорт', imgUrl: 'plorts/PlortPINK.webp', minPrice: '300' , maxPrice: '350', avgPrice: '325', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'},},
    {id: '17', name: 'Кам\'яний плорт', imgUrl: 'plorts/PlortROCK.webp', minPrice: '400', maxPrice: '450', avgPrice: '425', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'},},
    {id: '18', name: 'Смугастий плорт', imgUrl: 'plorts/PlortTABBY.webp', minPrice: '500', maxPrice: '550', avgPrice: '525', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'},},
  ]

  plorts = new MatTableDataSource(this.plortsQ);

  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
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
