import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../interfaces/item';
import { Toy } from '../interfaces/toy';

@Injectable({
  providedIn: 'root'
})
export class ToyService {

  apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getToys = (): Observable<Item[]> =>
    this.http.get<Item[]>(`${this.apiUrl}Toy`);

  getToysDetails = (): Observable<Toy[]> =>
    this.http.get<Toy[]>(`${this.apiUrl}Toy/Details`);
}
