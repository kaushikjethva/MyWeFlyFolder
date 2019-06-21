import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { searchedFlight } from '../models/searchedFlight';

@Injectable({
  providedIn: 'root'
})
export class SearchedFlightDetailService {
  private searchBarCriteria = new BehaviorSubject<searchedFlight>(new searchedFlight());

  searchFlightData = this.searchBarCriteria.asObservable();

  constructor() { }

  // fetchSelectedFlightData(searchflight: searchedFlight) {    
  //   this.searchBarCriteria.next(searchflight);
  // }

  setSelectedFlightData(searchflight: searchedFlight) {
    this.searchBarCriteria.next(searchflight);
    //console.log(searchflight);
  }
}
