import { ModuleWithProviders } from '@angular/core';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from "./components/home/home.component";
import { ContractComponent } from "./components/contract/contract.component";
import { ContactComponent } from "./components/contact/contact.component";

const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'contract', component: ContractComponent },
    { path: '', component: HomeComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes, { useHash: true});
