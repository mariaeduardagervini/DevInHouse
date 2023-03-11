import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Usuario } from '../models/usuario';
import { API_PATH } from '../environments/environments';

@Injectable({
  providedIn: 'root',
})
export class UsuarioService {
  constructor(private httpClient: HttpClient) {}

  getUsers(): Observable<Usuario[]> {
    return this.httpClient.get<Usuario[]>(`${API_PATH}/usuarios`);
  }
}
