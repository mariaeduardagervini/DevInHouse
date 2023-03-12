import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'searchPipe',
})
export class SearchPipePipe implements PipeTransform {
  transform(products: any, value: string): any[] {
    if (products) {
      if (value === '') {
        return products;
      } else {
        return products.filter((list: any) => {
          return list.name.toLowerCase().includes(value);
        });
      }
    }
    return products;
  }
}
