import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Category } from '../_models/category';
import { Retailer } from '../_models/retailer';
import { CategoryService } from '../_services/category.service';
import { RetailerService } from '../_services/retailer.service';
import { AlertifyService } from '../_services/alertify.service';
import { RetailerCategoryService } from '../_services/retailerCategory.service';
import { RetailerCategory } from '../_models/retailerCategory';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  retailerCategories: RetailerCategory[];
  categories: Category[];
  retailers: Retailer[];
  registerMode = false;

  constructor(
    private http: HttpClient,
    private categoryService: CategoryService,
    private retailerService: RetailerService,
    private retailerCategoryService: RetailerCategoryService,
    private alertify: AlertifyService
    ) {
  }

  ngOnInit() {
    this.loadCategories();
    this.loadRetailers();
    this.loadRetailerCategories();
  }

  loadRetailerCategories() {
    this.retailerCategoryService.getRetailerCategories().subscribe((retailerCategories: RetailerCategory[]) => {
      this.retailerCategories = retailerCategories;
      console.log('retailers and category name', retailerCategories);
    }, error => {
      this.alertify.error(error);
    });
  }

  loadCategories() {
    this.categoryService.getCategories().subscribe((categories: Category[]) => {
      this.categories = categories;
      console.log(categories);
    }, error => {
      this.alertify.error(error);
    });
  }

  loadRetailers() {
    this.retailerService.getRetailers().subscribe((retailers: Retailer[]) => {
      this.retailers = retailers;
    }, error => {
      this.alertify.error(error);
    });
  }

  registerToggle() {
    this.registerMode = true;
  }

  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

}
