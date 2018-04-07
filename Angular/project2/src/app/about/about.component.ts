import { DataService } from './../data.service';
import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs/Observable';
import {startWith} from 'rxjs/operators/startWith';
import {map} from 'rxjs/operators/map';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {

  constructor(private data:DataService) { }

  myControl: FormControl = new FormControl();

  options = [
    'One',
    'Two',
    'Three',
    'Four',
    'Five',
    'Six',
    'Seven'
  ];

  filteredOptions: Observable<string[]>;

  message:object;
  ngOnInit() {
    this.filteredOptions = this.myControl.valueChanges
      .pipe(
        startWith(''),
        map(val => this.filter(val))
      );

      this.data.currentMessage.subscribe(message=>this.message=message);
  }

  filter(val: string): string[] {
    return this.options.filter(option =>
      option.toLowerCase().indexOf(val.toLowerCase()) === 0);
  }



}
