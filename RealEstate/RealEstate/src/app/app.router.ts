import { ModuleWithProviders } from '@angular/core';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from "./components/home/home.component";
import { publicationlistComponent } from './components/customer/publication/publicationlist/publicationlist.component';
import { ContactComponent } from "./components/contact/contact.component";
import { ContractComponent } from "./components/contract/contract.component";
import { publicationitemComponent } from './components/customer/publication/publicationitem/publicationitem.component';
import { PublicationdetailsComponent } from './components/customer/publication/publicationdetails/publicationdetails.component';

const appRoutes: Routes =
    [
        { path: 'home', component: HomeComponent },
        { path: 'contact', component: ContactComponent },
        { path: 'publicationlist', component: publicationlistComponent },
        { path: '', component: HomeComponent }
    ];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes, { useHash: true });
