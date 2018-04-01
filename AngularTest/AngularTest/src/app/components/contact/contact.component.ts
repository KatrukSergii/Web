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
    selectedTabIndex: number;
    constructor(private contactService: ContactService)
    {
        this.selectedTabIndex = 1;
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
    selectedTabChanged(index: number): void
    {
        this.selectedTabIndex = index;
    }
}