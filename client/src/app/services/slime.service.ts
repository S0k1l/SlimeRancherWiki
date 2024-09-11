import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../interfaces/item';
import { Slime } from '../interfaces/slime';

@Injectable({
  providedIn: 'root'
})
export class SlimeService {

  apiUrl: string = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getSlimes = (): Observable<Item[]> => 
    this.http.get<Item[]>(`${this.apiUrl}Slime`);

  getSlime = (id: number): Observable<Slime> =>
    this.http.get<Slime>(`${this.apiUrl}Slime/${id}`);
}
