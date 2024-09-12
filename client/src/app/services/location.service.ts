import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../interfaces/item';
import { Location } from '../interfaces/location';

@Injectable({
  providedIn: 'root'
})
export class LocationService {

  apiUrl: string = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getLocations = () :Observable<Item[]> =>
    this.http.get<Item[]>(`${this.apiUrl}Location`);

  getLocation = (id: string):Observable<Location> =>
    this.http.get<Location>(`${this.apiUrl}Location/${id}`);

}
