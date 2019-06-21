import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { city } from '../models/city';
import { HttpParams } from "@angular/common/http";
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CityService {  
  headers: HttpHeaders;

  constructor(private http: HttpClient) { }
  cities: city[];  
  weflyUrl = 'http://localhost:49332/api/WeflyCity/';

  getCities(cityCode: string) {
    this.headers = new HttpHeaders();
    this.headers.set('cityCode', cityCode);

    //Subscribe with response and log
    // this.http.get(this.weflyUrl + cityCode).subscribe((res) => {
    //   console.log(res);
    // });


    //Subscribe with object response
    this.http.get(this.weflyUrl + cityCode).subscribe(
      (res: city[]) => {
        console.log(res);
        this.cities = res;
        console.log(this.cities);
      }
    );
  }
}
