import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { Employee } from '../Employee.component';

@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.css']
})
export class FirstComponent implements OnInit {

  message : any;
  constructor(private data:DataService,private emps:Employee) {
    
  }
  
  ngOnInit() {
    this.data.currentMessage.subscribe(message=>this.message=message);
  }
  
  

  newMessage(id,name,age)
  {
    this.emps.Id=id;
    this.emps.Name=name;
    this.emps.Age=age;
    // console.log(Employee.categorhy);
    //console.log(this.emp.__proto__.constructor.categorhy)
    // this.emp["id"] = 1;
    // this.emp.
    this.data.changeMessage(this.emps);
  }
}
