export default class Personagem {
  nome;
  percentualVida = 100;

  constructor(nome) {
    this.nome = nome;
    this.percentualVida = Personagem.percentualVida;
  }
  sofreuDano(percentualDano) {
    if (this.percentualVida <= 100 && this.percentualVida >= 0) {
      return (this.percentualVida = percentualDano);
    }

    //usouKitMedico() {
    // return this.percentualVida + 10;
    // }
  }
}
