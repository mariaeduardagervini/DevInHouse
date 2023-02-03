export default class Personagem {
  nome;
  percentualVida = 100;

  sofreuDano(percentualDano) {
    const novaVida = this.percentualVida - percentualDano;
    this.percentualVida = novaVida < 0 ? 0 : novaVida;
  }

  usouKitMedico() {
    const novaVida = this.percentualVida + 10;
    this.percentualVida = novaVida > 100 ? 100 : novaVida;
  }
}
