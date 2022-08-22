import { Component, OnInit, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
@Component({
  selector: 'app-temp-converter',
  templateUrl: './temp-converter.component.html',
  styleUrls: ['./temp-converter.component.scss']
})

@Injectable()
export class TempConverterComponent {

  title = 'Weather Converter';
  convertedTemp = '';
  unit = "F";


  constructor(private http: HttpClient ) { }

  onSubmit(temperature:string, convertedTo:string ): any {    
    return this.http.get('https://localhost:7066', { params: { temp: temperature, unitFrom: "C", unitTo: convertedTo } }).subscribe(data => {
      this.convertedTemp = data.toString();
    })
  }

  

}
