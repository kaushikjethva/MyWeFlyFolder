import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
//import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
//import {MatAutocompleteModule,MatInputModule} from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { FooterComponent } from './shared/footer/footer.component';
import { SearchbarComponent } from './shared/searchbar/searchbar.component';
import { BannerComponent } from './shared/banner/banner.component';
import { HomeComponent } from './home/home.component';
import { SearchListingComponent } from './search-listing/search-listing.component';
import { BookingHeaderComponent } from './shared/booking-header/booking-header.component';
import { LoginComponent } from './login/login.component';
import { FlightListItemComponent } from './flight-list-item/flight-list-item.component';
import { PaymentComponent } from './payment/payment.component';
import { PaymentConfirmationComponent } from './payment-confirmation/payment-confirmation.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { SeatSelectionComponent } from './seat-selection/seat-selection.component';
import { AddOnsComponent } from './add-ons/add-ons.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { BookingSummaryComponent } from './booking-summary/booking-summary.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SelectFlightComponent } from './select-flight/select-flight.component';
import { PreCheckoutComponent } from './pre-checkout/pre-checkout.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    SearchbarComponent,
    BannerComponent,
    HomeComponent,
    SearchListingComponent,
    BookingHeaderComponent,
    LoginComponent,
    FlightListItemComponent,
    PaymentComponent,
    PaymentConfirmationComponent,
    FeedbackComponent,
    ContactUsComponent,
    CustomerDetailsComponent,
    SeatSelectionComponent,
    AddOnsComponent,
    CheckoutComponent,
    BookingSummaryComponent,
    PageNotFoundComponent,
    SelectFlightComponent,
    PreCheckoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //BrowserAnimationsModule,
    //MatAutocompleteModule,
    //MatInputModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
