import { Injectable } from '@angular/core';
import { bookingdetails } from '../models/bookingdetail';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PaymentService {
  bookingconfirmation: bookingdetails;
  weflyUrl = 'http://localhost:49332/api/WeflyBooking/saveBookingDetails';

  private bookingconf = new BehaviorSubject<bookingdetails>(new bookingdetails());
  bookingdata = this.bookingconf.asObservable();

  constructor(private http: HttpClient) { }
  
  savebookingdetails(bookingdet: bookingdetails): Observable<any> {
    let options = {
      headers: {
        "Content-type": "application/json"
      }
    }
    console.log(JSON.stringify(bookingdet));
    return this.http.post(`${this.weflyUrl}`, JSON.stringify(bookingdet), options).pipe(
      map(
        (res: any) => {
          console.log(res);
          this.bookingconfirmation = res;
          this.bookingconf.next(res);
        }
      )
    );
  }
}
