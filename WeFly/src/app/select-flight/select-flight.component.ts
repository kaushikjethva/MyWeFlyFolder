import { Component, OnInit } from '@angular/core';
import { SearchedFlightDetailService } from '../services/searched-flight-detail.service';
import { searchedFlight } from '../models/searchedFlight';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-select-flight',
  templateUrl: './select-flight.component.html',
  styleUrls: ['./select-flight.component.css']
})
export class SelectFlightComponent implements OnInit {
  weflyUrl = "http://localhost:49332/api/WeflyRoute/GetRoute?";
  searchflight: searchedFlight;
  constructor(private searchedflighgdata: SearchedFlightDetailService,
    private route: Router,
    private http: HttpClient) {    
  }

  ngOnInit() {
    //this.data.searchFlightData.subscribe(data => this.searchflight = data);   
    //this.getFlightbyCity('CT01', 'CT02');
    this.searchedflighgdata.searchFlightData.subscribe(data=>this.searchflight = data);        

  }

  // getFlightbyCity(fromCity: string, toCity: string) {
  //   this.http.get(this.weflyUrl + "fromCity=" + fromCity + "&toCity=" + toCity).subscribe(
  //     (res: searchedFlight[]) => {
  //       console.log(res);
  //       this.searchflights = res;
  //       console.log(this.searchflights);
  //     }
  //   );
  // }
  bookflight(bookFlight:searchedFlight) {
    this.route.navigate(['/pre-checkout']);
  }

}
