import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, retry } from 'rxjs';
import { API_PATH } from '../environments/environments';
import { Serie } from '../models/serie';

@Injectable({
  providedIn: 'root',
})
export class SerieService {
  constructor(private http: HttpClient) {}

  getSeries(): Observable<Serie[]> {
    return this.http.get<Serie[]>(`${API_PATH}/series`).pipe(
      catchError(() => {
        throw new Error('Failed to reach the server!');
      }),
      retry({ count: 2, delay: 500 })
    );
  }

  getSerie(id: string): Observable<Serie> {
    return this.http.get<Serie>(`${API_PATH}/series/${id}`).pipe(
      catchError(() => {
        throw new Error('Failed to reach the server!');
      }),
      retry({ count: 2, delay: 500 })
    );
  }
}
