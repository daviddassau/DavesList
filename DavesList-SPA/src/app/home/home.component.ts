import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode = false;
  categories: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCategories();
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  getCategories() {
    this.http.get('http://localhost:5000/api/categories').subscribe(response => {
      this.categories = response;
    }, error => {
      console.log(error);
    });
  }

  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

}
