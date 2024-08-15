import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from './app.modeel';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private apiUrl ='https://localhost:7277/api/product'
  constructor(private http: HttpClient) { }
  getProducts(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
  addProduct(product: Product): Observable<Product> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post<Product>(this.apiUrl, product, { headers });
  }
}
