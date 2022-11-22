import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'phone'
})
export class PhonePipe implements PipeTransform {

  transform(rawNum:string) {
      rawNum = "+55" + rawNum;
      const areaCodeStr = rawNum.slice(3,5);
      const midSectionStr = rawNum.slice(5,10);
      const lastSectionStr = rawNum.slice(10);

      return `(${areaCodeStr}) ${midSectionStr}-${lastSectionStr}`;
  }
}
