import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  arr:string[]=['ramu','shiva','rajiv'];
  constructor() { }

  ngOnInit() {
  }
//------------donutChartData-------------------------------
  public donutChartData = [{
    id: 0,
    label: 'water',
    value: 20,
    color: 'red',
  }, {
    id: 1,
    label: 'land',
    value: 20,
    color: 'blue',
  }, {
    id: 2,
    label: 'sand',
    value: 30,
    color: 'green',
  }, {
    id: 3,
    label: 'grass',
    value: 20,
    color: 'yellow',
  }, {
    id: 4,
    label: 'earth',
    value: 10,
    color: 'pink',
  }];
//----PieChartData------------------------

public pieChartData = [{
  id: 0,
  label: 'slice 1',
  value: 50,
  color: 'blue',
}, {
  id: 1,
  label: 'slice 2',
  value: 20,
  color: 'black',
}, {
  id: 2,
  label: 'slice 3',
  value: 30,
  color: 'red',
}]
//---------google----------
 public PieChartDatas =  {
  chartType: 'PieChart',
  dataTable: [
    ['Task', 'Hours per Day'],
    ['Work',     11],
    ['Eat',      2],
    ['Commute',  2],
    ['Watch TV', 2],
    ['Sleep',    7]
  ],
  options: {'title': 'Tasks'},
};
//-------------------
public tableChartData =  {
  chartType: 'Table',
  dataTable: [
    ['Department', 'Revenues', 'Another column'],
    ['Shoes', 10700, -100],
    ['Sports', -15400, 25],
    ['Toys', 12500, 40],
    ['Electronics', -2100, 889],
    ['Food', 22600, 78],
    ['Art', 1100, 42]
  ],
  formatters: [
    {
      columns: [1, 2],
      type: 'NumberFormat',
      options: {
        prefix: '&euro;', negativeColor: '#FF0000', negativeParens: true
      }
    }
  ],
  options: {title: 'Countries', allowHtml: true}
};
}
