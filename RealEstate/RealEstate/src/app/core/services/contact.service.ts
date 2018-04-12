import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs';
import { Contact } from '../models/contact';

@Injectable()
export class ContactService {
    constructor(private http: Http) {

    }


    GetContacts(): Observable<Contact[]> {
        return this.http.get(`api/contact`)
            .map((res: Response) => res.json())
            .catch((error: any) => Observable.throw(error.json().error || 'Server error'))
    }
}