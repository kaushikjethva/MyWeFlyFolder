import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SearchListingComponent } from './search-listing/search-listing.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { PaymentConfirmationComponent } from './payment-confirmation/payment-confirmation.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SelectFlightComponent } from './select-flight/select-flight.component';
import { PreCheckoutComponent } from './pre-checkout/pre-checkout.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { SeatSelectionComponent } from './seat-selection/seat-selection.component';
import { PaymentComponent } from './payment/payment.component';

const routes: Routes = [
  { path: '', redirectTo:'/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path:"search-listing",component:SearchListingComponent },
  { path:"checkout",component:CheckoutComponent },
  { path:"payment-confirmation",component:PaymentConfirmationComponent },
  { path:"feedback",component:FeedbackComponent },
  { path:"contact-us",component:ContactUsComponent },
  { path:"login",component:LoginComponent },
  { path:"pre-checkout",component:PreCheckoutComponent },
  { path:"select-flight",component:SelectFlightComponent },
  { path:"customer-details",component:CustomerDetailsComponent },
  { path:"seat-selection",component:SeatSelectionComponent },
  { path:"payment",component:PaymentComponent },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
