import { Component, OnInit } from '@angular/core';

import { ContactService } from "../../core/services/contact.service";

import { Contact } from "../../core/models/contact";

@Component({
    selector: 'app-contact',
    templateUrl: 'contact.component.html'
})

export class ContactComponent implements OnInit
{
    contacts: Contact[] = [];
    selectedContact: Contact;
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