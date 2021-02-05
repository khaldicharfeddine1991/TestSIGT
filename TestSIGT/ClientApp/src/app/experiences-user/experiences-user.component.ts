import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-experiences-user',
  templateUrl: './experiences-user.component.html',
  styleUrls: ['./experiences-user.component.css']
})
export class ExperiencesUserComponent implements OnInit {
  @Input()
  public experiences: any[];
  constructor() { }

  ngOnInit() {
  }

}
