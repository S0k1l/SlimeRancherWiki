import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Diet } from '../interfaces/diet';

@Injectable({
  providedIn: 'root'
})
export class DietService {

  apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getDiets = ():Observable<Diet[]> =>
    this.http.get<Diet[]>(`${this.apiUrl}Diet`);
}
