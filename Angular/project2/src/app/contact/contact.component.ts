import { Component, OnInit, Input } from '@angular/core';
import * as d3 from "d3";
@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  Employee:object=[
    {Name:'ramu',Age:49},
    {Name:'shiva',Age:24},
    {Name:'rang',Age:66},
    {Name:'chandu',Age:41},
    {Name:'harsh',Age:42},
  ]
  constructor() { }
  // @Input() message : string;
  ngOnInit() {
  }
}
