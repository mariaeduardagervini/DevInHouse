export interface ISerie {
  id: string;
  imagem: string;
  nome: string;
  seasons: string;
}

export class Serie implements ISerie {
  id!: string;
  imagem!: string;
  nome!: string;
  seasons!: string;
}
