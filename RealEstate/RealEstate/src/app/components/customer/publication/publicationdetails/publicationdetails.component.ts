import { Component, Input } from '@angular/core';
import { Publication } from '../../../../core/models/publication';
import { RentalObjectService } from '../../../../core/services/rentalObject.service';
import { RentalObject } from '../../../../core/models/RentalObject';
import { retry } from 'rxjs/operator/retry';

@Component({
	selector: 'app-publicationdetails',
    templateUrl: './publicationdetails.component.html',
    styleUrls: ['./publicationdetails.component.css']
})

export class PublicationdetailsComponent 
{	
	currentPubl: Publication;
	CurrentRentalObject: RentalObject;
	messages: string[] = [];
    @Input() set CurrentPublication(pub: Publication)
    {
        this.currentPubl = pub;
		this.rentalObjectService.GetById(pub.rentalObjectId).subscribe(response => { this.CurrentRentalObject = response; });
	};
    get CurrentPublication(): Publication
	{
		return this.currentPubl;
    }
    
	constructor(private rentalObjectService: RentalObjectService) 
	{
	}
}