import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerService } from '../services/customer.service';
import { SearchedFlightDetailService } from '../services/searched-flight-detail.service';
import { bookingdetails } from '../models/bookingdetail';
import { searchedFlight } from '../models/searchedFlight';
import { customer } from '../models/customer';
import { DataServiceService } from '../data-service.service';
import { searchFlight } from '../models/searchFlight';
import { PaymentService } from '../services/payment.service';



@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {
  _bookingdetail: bookingdetails;
  _searchedflight: searchedFlight;
  _customer: customer;
  _searchflight: searchFlight;
  bookingconfirmation: bookingdetails;
  amount:number;

  weflyUrl = 'http://localhost:49332/api/WeflyBooking/';
  constructor(private formBuilder: FormBuilder,
    private customerdata: CustomerService,
    private selectedflightdata: SearchedFlightDetailService,
    private searchselection: DataServiceService,
    private paymentservice:PaymentService,
    private route:Router
  ) { }


  ngOnInit() {
    this.selectedflightdata.searchFlightData.subscribe(data => this._searchedflight = data);
    this.searchselection.searchFlightData.subscribe(data => this._searchflight = data);
    this.amount = this._searchedflight.flightPrice * this._searchflight.noOfPassenger;
  }
  paymentForm = this.formBuilder.group({
    cardnumber: ['', Validators.required],
    expirymonth: ['', Validators.required],
    expirydate: ['', Validators.required],
    cvvcode: ['', Validators.required],
    cardholdername: ['', Validators.required],
  });

  onSubmit() {
    this._bookingdetail = new bookingdetails();
    this.selectedflightdata.searchFlightData.subscribe(data => this._searchedflight = data);
    this.customerdata.customer.subscribe(data => this._customer = data);
    this.searchselection.searchFlightData.subscribe(data => this._searchflight = data);

    this._bookingdetail.firstName = this._customer.firstName;
    this._bookingdetail.laststName = this._customer.lastName;
    this._bookingdetail.emailId = this._customer.emailId;
    this._bookingdetail.mobileNo = this._customer.mobileno;
    this._bookingdetail.address = this._customer.address1;
    this._bookingdetail.state = this._customer.state;
    this._bookingdetail.city = this._customer.city;
    this._bookingdetail.pinCode = this._customer.pincode;
    this._bookingdetail.scheduleId = this._searchedflight.scheduleId;
    this._bookingdetail.routeId = this._searchedflight.routeId;
    this._bookingdetail.planeId = this._searchedflight.planeId;
    this._bookingdetail.ticketPrice = this._searchedflight.flightPrice * this._searchflight.noOfPassenger;
    this._bookingdetail.journeyTime = this._searchedflight.departTimeSource;
    this._bookingdetail.cardNumber = this.paymentForm.value.cardnumber;


    this.paymentservice.savebookingdetails(this._bookingdetail).subscribe(
      res=> {
        this.bookingconfirmation = res;
      }
    );
    this.route.navigate(['/payment-confirmation']);

  }

}
