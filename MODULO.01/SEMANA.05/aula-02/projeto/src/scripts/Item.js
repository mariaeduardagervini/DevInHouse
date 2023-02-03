export default class Item {
  static #lastId = 0;
  #id;
  label;

  constructor(label) {
    this.#id = ++Item.#lastId;
    this.label = label;
  }

  get id() {
    return this.#id;
  }

  criaElemento(aoApagarItem) {
    const li = document.createElement('li');
    li.innerHTML = `<p>${this.label}</p>`;
    const botaoApagar = document.createElement('button');
    botaoApagar.innerHTML = 'x';
    botaoApagar.addEventListener('click', () => {
      aoApagarItem(this.#id);
    });
    li.appendChild(botaoApagar);
    return li;
  }
}
