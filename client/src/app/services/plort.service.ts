import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../interfaces/item';
import { Plort } from '../interfaces/plort';

@Injectable({
  providedIn: 'root'
})
export class PlortService {

  apiUrl = environment.apiUrl;

  constructor(private http : HttpClient) { }

  getPlorts = (): Observable<Item[]> =>
    this.http.get<Item[]>(`${this.apiUrl}Plort`);

  getPlortsDetalis = (): Observable<Plort[]> =>
    this.http.get<Plort[]>(`${this.apiUrl}Plort/Details`);
}
