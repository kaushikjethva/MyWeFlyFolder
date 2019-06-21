import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { searchFlight } from 'src/app/models/searchFlight';
import { Router } from '@angular/router';
import { DataServiceService } from 'src/app/data-service.service';
import { CityService } from 'src/app/services/city.service';
import { city } from 'src/app/models/city';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';


@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent implements OnInit {

  //@Input() message :string;
  isSearchEnable: boolean = true;
  @Output() searchEvent = new EventEmitter<boolean>();
  public  cities: city[];
  weflyUrl = 'http://localhost:49332/api/WeflyCity/';
  

  constructor(private formBuilder: FormBuilder,
    private router: Router,
    private data: DataServiceService,
    private cityService: CityService,
    private http: HttpClient

  ) {        
  }

  searchflight: searchFlight;
  message: string;

  ngOnInit() {
    this.data.currentMessage.subscribe(message => this.message = message);
    //this.searchflight = new BehaviorSubject<searchFlight>(new searchFlight());
    this.data.searchFlightData.subscribe(data => this.searchflight = data);    
     this.getCities(null);
    console.log(this.cities);
  }

  profileForm = this.formBuilder.group({
    from: ['', Validators.required],
    to: ['', Validators.required],
    departDate: ['', Validators.required],
    returnDate: ['', Validators.required],
    passenger: ['', Validators.required],
  });

  getCities(cityCode: string) {
    this.http.get(this.weflyUrl + cityCode).subscribe(
      (res : city[])=>{
        console.log(res);
        this.cities = res;
        console.log(this.cities);        
        }
    );        
  }

  onSubmit() {
    this.searchEvent.emit(!this.isSearchEnable);
    console.log(!this.isSearchEnable);
    // TODO: Use EventEmitter with form value
    // console.log(this.profileForm.value);    
    this.searchflight = new searchFlight();  
    this.searchflight.from = this.profileForm.value.from;
    this.searchflight.to= this.profileForm.value.to;
    this.searchflight.flightDate = this.profileForm.value.departDate;    
    this.searchflight.noOfPassenger = this.profileForm.value.passenger;    
    this.data.FetchSearchFlightData(this.searchflight);        

  }

}
