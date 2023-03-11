import { ISeries } from './../models/series.interface';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class WebService {
  // private readonly API = 'http://localhost:4200/card-serie';
  // post: any;
  // constructor(private http: HttpClient) {}
  // buscarPorId(id: number): Observable<ISeries> {
  //   const url = `${this.API}/${id}`;
  //   return this.http.get<ISeries>(url);
  // }
}
