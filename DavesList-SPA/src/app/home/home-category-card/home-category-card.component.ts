import { Component, OnInit, Input } from '@angular/core';
import { Category } from '../../_models/category';

@Component({
  selector: 'app-home-category-card',
  templateUrl: './home-category-card.component.html',
  styleUrls: ['./home-category-card.component.css']
})
export class HomeCategoryCardComponent implements OnInit {
  @Input() category: Category;

  constructor() { }

  ngOnInit() {
  }

}
