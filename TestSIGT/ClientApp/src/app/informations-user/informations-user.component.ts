import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-informations-user',
  templateUrl: './informations-user.component.html',
  styleUrls: ['./informations-user.component.css']
})
export class InformationsUserComponent implements OnInit {

  @Input()
  public user: any;

  constructor() { }

  ngOnInit() {
  }

}
