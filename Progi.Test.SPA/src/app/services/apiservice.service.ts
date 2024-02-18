import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private baseUrl: string = 'http://localhost:5173/api';

  constructor(private http: HttpClient) {}

  getPrice(carType: number, basePrice: number): Observable<any> {
    let url = `${this.baseUrl}/CarCalculator?BasePrice=${basePrice}&CarType=${carType}`;
    console.log(url);
    var result = this.http.get(url);
    return result;
  }

 
}
