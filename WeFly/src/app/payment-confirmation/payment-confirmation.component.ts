import { Component, OnInit } from '@angular/core';
import { PaymentService } from '../services/payment.service';

@Component({
  selector: 'app-payment-confirmation',
  templateUrl: './payment-confirmation.component.html',
  styleUrls: ['./payment-confirmation.component.css']
})
export class PaymentConfirmationComponent implements OnInit {
  bookingId: string;
  constructor(private paymentservice: PaymentService) { }

  ngOnInit() {
    this.paymentservice.bookingdata.subscribe(res => this.bookingId = res.id);
  }

}
