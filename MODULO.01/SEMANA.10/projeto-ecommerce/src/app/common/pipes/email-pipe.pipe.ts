import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'emailPipe',
})
export class EmailPipePipe implements PipeTransform {
  transform(value: string): string {
    console.log('----value----');
    const resp = value.split('@');

    return resp[0];
  }
}
