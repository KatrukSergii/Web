import { Component, OnInit } from '@angular/core';

import { HomeService } from "../../core/services/home.service";

@Component({
    selector: 'app-home',
    templateUrl: 'home.component.html'
})

export class HomeComponent implements OnInit {

    results: any[] = [];
    constructor(private homeService: HomeService)
    {
    }

    ngOnInit(): void {
        this.homeService.GetHomeMessage().subscribe(response => { this.results = response; });
    }

}