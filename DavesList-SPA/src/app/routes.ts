import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CategoryComponent } from './category/category.component';
import { RetailerComponent } from './retailer/retailer.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'categories', component: CategoryComponent },
            { path: 'retailers', component: RetailerComponent },
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full' },
];
