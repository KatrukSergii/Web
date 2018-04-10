import { Component, OnInit } from '@angular/core';
import { PublicationsService } from '../../../../core/services/publications.service';
import { Publication } from '../../../../core/models/publication';

@Component({
    selector: 'app-publicationlist',
    templateUrl: './publicationlist.component.html'
    //, styleUrls: ['./publicationlist.component.scss']
})
export class publicationlistComponent implements OnInit
{
    Publications: Publication[];
    constructor(private publicationService: PublicationsService)
    {

    }

    ngOnInit(): void
    {
        this.publicationService.Get().subscribe(response => { this.Publications = response; });
    }
}