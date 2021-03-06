import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap';
import { CarouselModule } from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AlertifyService } from './_services/alertify.service';
import { RetailerComponent } from './retailer/retailer.component';
import { appRoutes } from './routes';
import { AuthGuard } from './_guards/auth.guard';
import { FooterComponent } from './footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CategoryService } from './_services/category.service';
import { HomeCategoryCardComponent } from './home/home-category-card/home-category-card.component';
import { RetailerService } from './_services/retailer.service';
import { RetailerCategoryService } from './_services/retailerCategory.service';

@NgModule({
   declarations: [
      AppComponent,
      CategoryComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      RetailerComponent,
      FooterComponent,
      HomeCategoryCardComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes),
      CarouselModule.forRoot(),
      FontAwesomeModule
   ],
   providers: [
      AuthService,
      AlertifyService,
      AuthGuard,
      CategoryService,
      RetailerService,
      RetailerCategoryService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
