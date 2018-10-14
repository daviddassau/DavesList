import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RetailerCategory } from '../_models/retailerCategory';

const httpOptions = {
  headers: new HttpHeaders({
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
};

@Injectable({
  providedIn: 'root'
})
export class RetailerCategoryService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getRetailerCategories(): Observable<RetailerCategory[]> {
    return this.http.get<RetailerCategory[]>(this.baseUrl + 'retailerCategories', httpOptions);
  }

}
