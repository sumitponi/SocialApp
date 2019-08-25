import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  employees: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValue();
  }

  getValue() {
    this.http.get('http://localhost:5000/api/values/').subscribe(
      Response => {this.employees = Response; } ,
      Error => { console.log(Error); } );
  }

}
