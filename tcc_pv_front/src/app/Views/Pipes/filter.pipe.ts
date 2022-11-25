import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: any, filterString: string, attrib: string) {
    if (filterString == '' || filterString == null) {
      return value;
    }

    const filteredValues = [];
    for (const val of value) {
      if (val[attrib].toUpperCase().includes(filterString.toUpperCase())) {
        filteredValues.push(val);
      }
    }
    return filteredValues;
  }

}
