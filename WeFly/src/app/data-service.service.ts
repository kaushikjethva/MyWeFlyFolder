import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { searchFlight } from './models/searchFlight';

@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

  private messageSource = new BehaviorSubject<string>('Default Message');
  private searchBarCriteria = new BehaviorSubject<searchFlight>(new searchFlight());

  searchFlightData = this.searchBarCriteria.asObservable();
  
  currentMessage =  this.messageSource.asObservable();
  constructor() { }

  changeMessage(message:string)
  {
    this.messageSource.next(message);
  }

  FetchSearchFlightData(searchflight:searchFlight)
  {
    this.searchBarCriteria.next(searchflight);
  }
}
