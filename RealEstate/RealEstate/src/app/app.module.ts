import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule, Http, XHRBackend, RequestOptions } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { MatTabsModule, MatCardModule, MatDatepickerModule, MatFormFieldModule, MatInputModule, MatNativeDateModule } from '@angular/material';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { ContactComponent } from './components/contact/contact.component';
import { ContractComponent } from './components/contract/contract.component';
import { routing } from './app.router';

import { HomeService } from "./core/services/home.service";
import { ContactService } from './core/services/contact.service';
import { ContractService } from './core/services/contract.service';
import { publicationitemComponent } from './components/customer/publication/publicationitem/publicationitem.component';
import { PublicationdetailsComponent } from './components/customer/publication/publicationdetails/publicationdetails.component';
import { publicationlistComponent } from './components/customer/publication/publicationlist/publicationlist.component';
import { PublicationsService } from './core/services/publications.service';
import { RentalObjectService } from './core/services/rentalObject.service';
import { PublicationRequestService } from './core/services/publicationRequest.service';

@NgModule({
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        FormsModule,
        HttpModule,
        MatCardModule,
        MatDatepickerModule,
        MatFormFieldModule,
        MatInputModule,
        MatNativeDateModule,
        routing,
        HttpClientModule,
        MatTabsModule
    ],
    declarations: [
        HomeComponent,
        ContractComponent,
        ContactComponent,
        AppComponent,
        publicationitemComponent,
        PublicationdetailsComponent,
        publicationlistComponent
    ],
    providers: [
        HomeService,
        ContactService, 
		ContractService,
		PublicationsService,
		RentalObjectService,
		PublicationRequestService
    ],
    bootstrap: [AppComponent]
 })
export class AppModule { }
