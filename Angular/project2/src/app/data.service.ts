import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { Injectable } from '@angular/core';
import { Employee } from './Employee.component';

@Injectable()
export class DataService {
  private emp = new Employee();
  private messageSource = new BehaviorSubject<object>(this.emp);
  currentMessage = this.messageSource.asObservable();
  constructor() { } 

  changeMessage(message : object)
  {
    //this.messageSource=new BehaviorSubject<object>(message);
    this.messageSource.next(message);
  }
}
