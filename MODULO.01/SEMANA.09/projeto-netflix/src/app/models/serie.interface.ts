export interface ISerie {
  id: string;
  imagem: string;
  nome: string;
  season: string;
}

export class Serie implements ISerie {
  id!: string;
  imagem!: string;
  nome!: string;
  season!: string;
}
