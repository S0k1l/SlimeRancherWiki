import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { Item } from '../interfaces/item';
import { Food } from '../interfaces/food';

@Injectable({
  providedIn: 'root'
})
export class FoodService {

  apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getFruits = (): Observable<Item[]> =>
    this.http.get<Item[]>(`${this.apiUrl}Food/Fruits`);

  getVeggies = (): Observable<Item[]> =>
    this.http.get<Item[]>(`${this.apiUrl}Food/Veggies`);

  getMeats = (): Observable<Item[]> =>
    this.http.get<Item[]>(`${this.apiUrl}Food/Meats`);

  getFood = (id:string): Observable<Food> =>
    this.http.get<Food>(`${this.apiUrl}Food/${id}`);
}
