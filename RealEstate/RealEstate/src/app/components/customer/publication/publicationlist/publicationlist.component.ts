import { Component, OnInit } from '@angular/core';
import { PublicationsService } from '../../../../core/services/publications.service';
import { Publication } from '../../../../core/models/publication';

@Component({
    selector: 'app-publicationlist',
	templateUrl: './publicationlist.component.html'
})
export class publicationlistComponent implements OnInit
{
	Publications: Publication[];
	CurrentPublication: Publication = new Publication(1,1,null);
    constructor(private publicationService: PublicationsService)
    {
    }

    ngOnInit(): void
    {
        this.publicationService.Get().subscribe(response => { this.Publications = response; });
    }
}