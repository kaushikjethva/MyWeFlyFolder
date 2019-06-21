import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  showSearch:boolean=true;
  constructor() { }

  ngOnInit() {
  }

  updateHomepage($event){        
    this.showSearch = $event;
  }

}
