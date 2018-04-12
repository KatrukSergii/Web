import { Component, Input } from '@angular/core';
import { Publication } from '../../../../core/models/publication';

@Component({
    selector: 'app-publicationitem',
	templateUrl: './publicationitem.component.html' 
})
export class publicationitemComponent
{
    @Input() Publication: Publication;
    constructor()
    {
    }
}