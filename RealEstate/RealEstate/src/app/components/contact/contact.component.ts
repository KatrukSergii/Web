import { Component, OnInit, ViewChild } from '@angular/core';

import { ContactService } from "../../core/services/contact.service";

import { Contact } from "../../core/models/contact";
import { MatDatepicker } from '@angular/material';
import { retry } from 'rxjs/operators/retry';

@Component({
    selector: 'app-contact',
    templateUrl: 'contact.component.html'
})

export class ContactComponent implements OnInit
{
    contacts: Contact[] = []; 
    selectedContact: Contact;
    date: Date = new Date(2001,1,1);
    set birthDate(value: Date)
    {
        if (this.selectedContact != null)
            this.selectedContact.birthDate = value;

    }
    get birthDate()
    {
        if(this.selectedContact != null)
            return this.selectedContact.birthDate;
        return this.date
    }
    constructor(private contactService: ContactService)
    {
    }

    setSelectedContact(contact: Contact) : void
    {
        this.selectedContact = contact;
    }

    ngOnInit(): void
    {
        this.contactService.GetContacts().subscribe(response => { this.contacts = response; });
        this.selectedContact = this.contacts[0];
    }
}