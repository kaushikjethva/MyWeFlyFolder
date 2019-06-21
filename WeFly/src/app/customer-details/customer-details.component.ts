import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators  } from '@angular/forms';
import { customer } from '../models/customer';
import { CustomerService } from '../services/customer.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.css']
})
export class CustomerDetailsComponent implements OnInit {
_customer:customer;
  constructor(private formBuilder: FormBuilder,
    private customerdata:CustomerService,
    private route:Router
    ) { }

  ngOnInit() {
  }

  
  customerForm = this.formBuilder.group({
    firstname: ['', Validators.required],
    emailid: ['', Validators.required],
    lastname: ['', Validators.required],
    mobileno: ['', Validators.required],
    address1: ['', Validators.required],
    nationality: ['', Validators.required],
    state : ['', Validators.required],
    city: ['', Validators.required],
    pincode: ['', Validators.required]
  });

  onSubmit() {    
    this._customer = new customer();  
    this._customer.firstName = this.customerForm.value.firstname;
    this._customer.lastName = this.customerForm.value.lastname;
    this._customer.emailId = this.customerForm.value.emailid;
    this._customer.mobileno = this.customerForm.value.mobileno;
    this._customer.address1 = this.customerForm.value.address1;
    this._customer.nationality = this.customerForm.value.nationality;
    this._customer.state = this.customerForm.value.state;
    this._customer.city = this.customerForm.value.city;
    this._customer.pincode = this.customerForm.value.pincode;
    
    this.customerdata.setcustomerdata(this._customer);
    this.route.navigate(['/payment'])

  }

}
