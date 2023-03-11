export interface IUsuario {
  id?: number;
  email: string;
  password: string;
}

export class User implements IUsuario {
  id?: number | undefined;
  email!: string;
  password!: string;
}
