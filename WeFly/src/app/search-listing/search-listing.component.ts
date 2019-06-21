import { Component, OnInit } from '@angular/core';
import { searchFlight } from '../models/searchFlight';
import { Router, ActivatedRoute } from '@angular/router';
import { DataServiceService } from '../data-service.service';
import { FlightListService } from '../services/flight-list.service';
import { searchedFlight } from '../models/searchedFlight';
import { SearchedFlightDetailService } from '../services/searched-flight-detail.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-search-listing',
  templateUrl: './search-listing.component.html',
  styleUrls: ['./search-listing.component.css']
})
export class SearchListingComponent implements OnInit {
    searchFlighData :searchFlight;

    searchedflightlist : searchedFlight[];

    weflyUrl = "http://localhost:49332/api/WeflyRoute/GetRoute?";
    searchflights: searchedFlight[];


    //Below ex. used for component communication
    //message : string;
  constructor(private data:DataServiceService,
    private searchedflightlistdata: FlightListService,
    private searchedflightdetaildata : SearchedFlightDetailService,
    private route:Router,
    private http:HttpClient  
    ) { }

  ngOnInit() {
    //Pass data as parameter
    //this.sub = this.route.data.subscribe(v=> console.log(v));      
    ///this.route.data.subscribe(v=> console.log(v));
    //Below ex. used for component communication
    //this.data.currentMessage.subscribe(message => this.message = message);
    this.data.searchFlightData.subscribe(data => this.searchFlighData = data);
    console.log(this.searchFlighData);
    //this.searchedflightlist = this.searchedflightlistdata.getSearchedFlightData();
    console.log(this.searchedflightlist);    
    this.getFlightbyCity(this.searchFlighData.from, this.searchFlighData.to);
  }

  getFlightbyCity(fromCity: string, toCity: string) {
    this.http.get(this.weflyUrl + "fromCity=" + fromCity + "&toCity=" + toCity).subscribe(
      (res: searchedFlight[]) => {
        console.log(res);
        this.searchflights = res;
        this.searchedflightlist = this.searchflights;
        console.log(this.searchflights);
      }
    );
  }

  selectedFlight(selectedflight:searchedFlight)
  {    
    this.searchedflightdetaildata.setSelectedFlightData(selectedflight);    
    this.route.navigate(['/select-flight']);

  }
}
