import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { customer } from '../models/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {  
  private customerdata = new BehaviorSubject<customer>(new customer());
  customer = this.customerdata.asObservable();



  constructor() { }
  setcustomerdata(_customer: customer) {
    this.customerdata.next(_customer);

  }

}
