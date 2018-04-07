import { Employee } from './Employee.component';
import { DataService } from './data.service';
import { DoughnutChartComponent, PieChartComponent, BarChartComponent } from 'angular-d3-charts';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {MatButtonModule} from '@angular/material/button';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { NewsComponent } from './news/news.component';
import { ContactComponent } from './contact/contact.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatInputModule} from '@angular/material/input';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { Ng2GoogleChartsModule } from 'ng2-google-charts';
import { FirstComponent } from './first/first.component';
import { SecondComponent } from './second/second.component';

const routes : Routes=[
  {path:'Home',component:HomeComponent},
  {path:'News',component:NewsComponent},
  {path:'About',component:AboutComponent},
  {path:'First',component:FirstComponent},
  {path:'Contact',component:ContactComponent},
  {path:'',redirectTo:'/Home', pathMatch:'full'},
  {path:'**',redirectTo:'/Home',pathMatch:'full'}  
]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    NewsComponent,
    ContactComponent,
    NavBarComponent,
    DoughnutChartComponent,
    PieChartComponent,
    BarChartComponent,
    FirstComponent,
    SecondComponent
  ],
  imports: [
    BrowserModule,BrowserAnimationsModule,RouterModule,RouterModule.forRoot(routes),
    MatToolbarModule,MatIconModule,MatMenuModule,MatSidenavModule,MatButtonModule,
    MatInputModule,FormsModule,MatAutocompleteModule,ReactiveFormsModule,Ng2GoogleChartsModule
  ],
  providers: [DataService,Employee],
  bootstrap: [AppComponent]
})
export class AppModule { }