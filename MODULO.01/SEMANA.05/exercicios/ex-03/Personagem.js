export default class Personagem {
  nome;
  static percentualVida = 100;

  constructor(nome) {
    this.nome = nome;
    this.percentualVida = Personagem.percentualVida;
  }
  sofreuDano(percentualDano) {
    return this.percentualVida - percentualDano;
  }
  usouKitMedico() {
    return this.percentualVida + 10;
  }
}
