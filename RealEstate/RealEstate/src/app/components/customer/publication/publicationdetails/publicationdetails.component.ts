import { Component, Input, OnInit, OnChanges, SimpleChanges, SimpleChange } from '@angular/core';
import { Publication } from '../../../../core/models/publication';
import { RentalObjectService } from '../../../../core/services/RentalObjectservice';
import { RentalObject } from '../../../../core/models/RentalObject';
import { retry } from 'rxjs/operator/retry';

@Component({
	selector: 'app-publicationdetails',
	templateUrl: './publicationdetails.component.html'
})
export class PublicationdetailsComponent implements OnInit, OnChanges
{	
ngOnChanges(changes: SimpleChanges): void
{
	if (changes['Publication'])
		this.messages.push('id:' + changes['Publication'].currentValue.RentalObjectId);
}
	currentPubl: Publication;
	messages: string[] = [];
	@Input() set Publication(publication: Publication)
	{
		this.currentPubl = publication;
		this.messages.push('id:'+ publication.RentalObjectId);
		this.rentalObjectService.GetById(this.currentPubl.RentalObjectId).subscribe(response => { this.CurrentRentalObject = response; });
	};
	get Publication() : Publication
	{
		return this.currentPubl;
	}
	CurrentRentalObject: RentalObject;

	constructor(private rentalObjectService: RentalObjectService) 
	{
	}

	ngOnInit(): void
	{
		//this.rentalObjectService.GetById(this.CurrentPublication.RentalObjectId).subscribe(response => { this.CurrentRentalObject = response; });
	}
}