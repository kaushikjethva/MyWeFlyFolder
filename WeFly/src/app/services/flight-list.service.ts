import { Injectable } from '@angular/core';
import { searchFlight } from '../models/searchFlight';
import { searchedFlight } from '../models/searchedFlight';

@Injectable({
  providedIn: 'root'
})
export class FlightListService {
  searchedflights: searchedFlight[];
  constructor() {
    // this.searchedflights = [
    //   { planType: "Jet Airways", arrivalTime: "3:20", departTime: "1:20", flightDuration: "2", flightPrice: "3000", fromCity: "Mumbai", toCity: "New Delhi", fromCityCode: "BOM", toCityCode: "DEL", noOfstops: 2 },
    //   { planType: "IndiGo", arrivalTime: "3:20", departTime: "1:20", flightDuration: "2", flightPrice: "3000", fromCity: "Mumbai", toCity: "New Delhi", fromCityCode: "BOM", toCityCode: "DEL", noOfstops: 2 },
    //   { planType: "Spicejet", arrivalTime: "3:20", departTime: "1:20", flightDuration: "2", flightPrice: "3000", fromCity: "Mumbai", toCity: "New Delhi", fromCityCode: "BOM", toCityCode: "DEL", noOfstops: 2 },
    //   { planType: "Kingfisher", arrivalTime: "3:20", departTime: "1:20", flightDuration: "2", flightPrice: "3000", fromCity: "Mumbai", toCity: "New Delhi", fromCityCode: "BOM", toCityCode: "DEL", noOfstops: 2 },
    //   { planType: "hello", arrivalTime: "3:20", departTime: "1:20", flightDuration: "2", flightPrice: "3000", fromCity: "Mumbai", toCity: "New Delhi", fromCityCode: "BOM", toCityCode: "DEL", noOfstops: 2 },
    // ];
  }

  ngOnInit() {


  }

  getSearchedFlightData(): searchedFlight[] {
    return this.searchedflights;
  }
}
