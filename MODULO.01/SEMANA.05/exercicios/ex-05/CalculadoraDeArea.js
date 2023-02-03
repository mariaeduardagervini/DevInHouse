export default class CalculadoraDeArea {
  tipo;
  base;
  altura;

  constructor(tipo, base, altura) {
    this.tipo = tipo;
    this.base = base;
    this.altura = altura;
  }

  calcular() {
    let resultado;

    switch (this.tipo) {
      case 'triangulo':
        resultado = (this.base * this.altura) / 2;
        break;
      case 'quadrado':
      case 'retangulo':
        resultado = this.base * this.altura;
        break;

      default:
        resultado = null;
    }
    return resultado;
  }
}
