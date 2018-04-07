import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {

  constructor() { }
  Fruits : string[] =['Banana','Apple','Mango'];
  ngOnInit() {
  }
  onClick(name)
  {
    this.Fruits.push(name);
  }
  rock:string="";
  nam:string ="";
  onKeyPress(names)
  {
    this.nam=names;
  }
  myStyles = {
    'background-color': 'lime',
    'font-size': '20px',
    'font-weight': 'bold'
    }
    setMyStyle()
    {
      let style={
        'background-color': 'lime',
        'font-size': '20px',
        'font-weight': 'bold'
      }
      return style; 
    }
//---------using donutChartData---------------------------------------------

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
}
