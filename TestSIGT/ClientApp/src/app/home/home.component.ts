import { Component, OnInit } from '@angular/core';
import { APIService } from '../Services/api.service';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent implements OnInit {
  public user: User;
  public experiences: Experience[];

  constructor( private service: APIService ) {
   

  }
  //id user 1 for example
  ngOnInit() {
    this.service.getUser(1).subscribe(result => {
      this.user = result;
    }, error => console.error(error));

    this.service.getExperiences(1).subscribe(result => {
      this.experiences = result;
    }, error => console.error(error));

  }
}



