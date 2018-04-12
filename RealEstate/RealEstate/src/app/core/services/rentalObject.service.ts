import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Observable } from 'rxjs';
import { RentalObject } from '../models/rentalObject';

@Injectable()
export class RentalObjectService 
{
	constructor(private http: Http) 
	{
    }

    Get(): Observable<RentalObject[]> 
	{
        return this.http.get(`api/RentalObject`)
            .map((res: Response) => res.json())
            .catch((error: any) => Observable.throw(error.json().error || 'Server error'))
	}

    GetById(id: number): Observable<RentalObject> 
	{
		return this.http.get(`api/RentalObject/${id}`)
			.map((res: Response) => res.json())
			.catch((error: any) => Observable.throw(error.json().error || 'Server error'))
	}
}