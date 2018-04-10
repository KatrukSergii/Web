import { Component } from '@angular/core';
import { Publication } from '../../../../core/models/publication';

@Component({
    selector: 'app-publicationitem',
    templateUrl: 'publicationitem.component.html' 
    //, styleUrls: ['./publicationitem.component.scss']
})
export class publicationitemComponent
{
    Publication: Publication;
    constructor()
    {
    }
}