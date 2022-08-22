import { HttpClient } from '@angular/common/http';
import { Component, Injectable } from '@angular/core';
@Component({
  selector: 'app-temp-converter',
  templateUrl: './temp-converter.component.html',
  styleUrls: ['./temp-converter.component.scss']
})

@Injectable()
export class TempConverterComponent {

  title = 'Weather Converter';
  convertedTemp = '';


  constructor(private http: HttpClient ) { }

  onSubmit(temperature: string,unitfrom:string, convertedTo: string): any {
    //TODO:Allow Dynamic units from
    return this.http.get('https://localhost:7066', { params: { temp: temperature, unitFrom: unitfrom, unitTo: convertedTo } }).subscribe(data => {
      this.convertedTemp = data.toString();
    })
  }

  

}
