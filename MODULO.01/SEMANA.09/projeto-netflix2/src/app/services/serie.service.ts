import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, retry } from 'rxjs';
import { API_PATH } from '../environments/environments';
import { Serie } from '../models/serie';

@Injectable({
  providedIn: 'root',
})
export class SerieService {
  private readonly API = 'http://localhost:3000/series';
  constructor(private http: HttpClient) {}

  getSeries(): Observable<Serie[]> {
    return this.http.get<Serie[]>(`${this.API}`).pipe(
      catchError(() => {
        throw new Error('Failed to reach the server!');
      }),
      retry({ count: 2, delay: 500 })
    );
  }

  getIdSerie(id: string): Observable<Serie> {
    return this.http.get<Serie>(`${this.API}/${id}`).pipe(
      catchError(() => {
        throw new Error('Failed to reach the server!');
      }),
      retry({ count: 2, delay: 500 })
    );
  }
}
