import { CommonModule } from '@angular/common';
import { Component, OnInit, Renderer2, ViewChild } from '@angular/core';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatTooltipModule } from '@angular/material/tooltip';
import { NavigationEnd, Router, RouterLink } from '@angular/router';

interface Item {
  id: string,
  name: string,
  imgUrl: string,
}

interface Toy{
  id: string,
  name: string,
  slime: Item,
  imgUrl: string,
  price: string,
}

@Component({
  selector: 'app-toys',
  standalone: true,
  imports: [MatTableModule, MatSortModule, MatTooltipModule, RouterLink, CommonModule],
  templateUrl: './toys.component.html',
  styleUrl: './toys.component.css'
})
export class ToysComponent implements OnInit {

  constructor(private router: Router, private renderer: Renderer2) { }

  ngOnInit(): void {
    this.router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        const fragment = this.router.url.split('#')[1];
        if (fragment) {
          setTimeout(() => {
            const el = document.getElementById(fragment);
            this.renderer.addClass(el,'highlighted');
            el?.scrollIntoView({ behavior: 'smooth', block: 'center', inline: 'center' });

            setTimeout(() => {
              this.renderer.removeClass(el,'highlighted');
            }, 900);
          }, 100);
        }
      }
    });
  }

  displayedColumns: string[] = ['toy', 'slime', 'price'];

  toysQ: Toy[] = [
    {id: '1', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'}, price: '300',},
    {id: '2', name: 'Великий камінь', imgUrl: 'toys/Big_Rock.webp', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'}, price: '400',},
    {id: '3', name: 'Клубок пряжі', imgUrl: 'toys/Yarn_Ball.webp', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'}, price: '500',},
    {id: '4', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'}, price: '300',},
    {id: '5', name: 'Великий камінь', imgUrl: 'toys/Big_Rock.webp', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'}, price: '400',},
    {id: '6', name: 'Клубок пряжі', imgUrl: 'toys/Yarn_Ball.webp', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'}, price: '500',},
    {id: '7', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'}, price: '300',},
    {id: '8', name: 'Великий камінь', imgUrl: 'toys/Big_Rock.webp', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'}, price: '400',},
    {id: '9', name: 'Клубок пряжі', imgUrl: 'toys/Yarn_Ball.webp', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'}, price: '500',},
    {id: '10', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'}, price: '300',},
    {id: '11', name: 'Великий камінь', imgUrl: 'toys/Big_Rock.webp', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'}, price: '400',},
    {id: '12', name: 'Клубок пряжі', imgUrl: 'toys/Yarn_Ball.webp', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'}, price: '500',},
    {id: '13', name: 'Пляжний м\'яч', imgUrl: 'toys/Beach_Ball.webp', slime: {id: '1', name: 'Рожевий слайм', imgUrl: 'slimes/Pink_Slime.webp'}, price: '300',},
    {id: '14', name: 'Великий камінь', imgUrl: 'toys/Big_Rock.webp', slime: {id: '2', name: 'Кам\'яний слайм', imgUrl: 'slimes/Rock_Slime.webp'}, price: '400',},
    {id: '15', name: 'Клубок пряжі', imgUrl: 'toys/Yarn_Ball.webp', slime: {id: '3', name: 'Смугастий слайм', imgUrl: 'slimes/Tabby_Slime.webp'}, price: '500',},
  ];

  toys = new MatTableDataSource(this.toysQ);

  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
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
