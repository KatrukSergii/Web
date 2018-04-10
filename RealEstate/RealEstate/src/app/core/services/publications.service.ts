import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs';

@Injectable()
export class PublicationsService
{
    constructor(private http: Http)
    {
    }

    Get(): Observable<any[]> {
        return this.http.get(`api/publications`)
            .map((res: Response) => res.json())
            .catch((error: any) => Observable.throw(error.json().error || 'Server error'))
    }
}