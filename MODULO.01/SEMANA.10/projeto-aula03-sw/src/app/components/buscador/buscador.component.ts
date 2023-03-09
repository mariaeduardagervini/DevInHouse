import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-buscador',
  templateUrl: './buscador.component.html',
  styleUrls: ['./buscador.component.css'],
})
export class BuscadorComponent implements OnInit {
  constructor() {}
  ngOnInit(): void {}

  // buscar(array: [], nome: string) {
  //     if(!array.length === 0) return []
  //     if(!nome) return array

  //   const termo = nome.toLowerCase()
  //     return array.filter(personagem => {
  //       return personagem.nome.toLowerCase().includes(termo)
  //     })

  //    }

  //   const filtrado = buscar(personagens, '')

  //   console.log(filtrado)
}
