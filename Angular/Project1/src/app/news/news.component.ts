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
}
