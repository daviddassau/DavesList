import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Retailer } from '../_models/retailer';

const httpOptions = {
  headers: new HttpHeaders({
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class RetailerService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getRetailers(): Observable<Retailer[]> {
    return this.http.get<Retailer[]>(this.baseUrl + 'retailers', httpOptions);
  }

  getRetailer(id): Observable<Retailer> {
    return this.http.get<Retailer>(this.baseUrl + 'retailers/' + id);
  }
}
