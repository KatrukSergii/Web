import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs';
import { PublicationRequest } from '../models/publicationRequest';

@Injectable()
export class PublicationRequestService {
    constructor(private http: Http) {
    }

    Get(): Observable<PublicationRequest[]> {
        return this.http.get(`api/PublicationRequest`)
            .map((res: Response) => res.json())
            .catch((error: any) => Observable.throw(error.json().error || 'Server error'))
    }
}