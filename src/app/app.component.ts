import { Component, OnInit, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements  OnInit {
  title = 'Planet Database';

  constructor(private _httpService: HttpClient) { }

  apiValues: string[] = [];
  errorMessage: string;
  IsError: boolean = false;

  ngOnInit():void {


    this._httpService.get('/api/Values')
      .subscribe((result: any[]) => {
        this.apiValues = result;
      },
      error => {
        this.errorMessage = error;
        this.IsError = true;
        console.log(this.errorMessage);
      }
     );
   }
 }

