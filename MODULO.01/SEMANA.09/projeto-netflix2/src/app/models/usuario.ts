export interface IUsuario {
  id?: number;
  email: string;
  password: string;
}

export class Usuario implements IUsuario {
  id?: number;
  email!: string;
  password!: string;
}
