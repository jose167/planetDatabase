import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements  OnInit {
  title = 'Planet Database';

  constructor(private _httpService: HttpClient) { }

  apiPlanets: string[] = [];
  errorMessage: string;
  hasError: boolean = false;

  ngOnInit():void {

    this._httpService.get('/api/planets')
      .subscribe((result: any[]) => {
        this.apiPlanets = result;
      },
      error => {
        this.errorMessage = error;
        this.hasError = true;
        console.log(this.errorMessage);
      }
     );
   }
 }

