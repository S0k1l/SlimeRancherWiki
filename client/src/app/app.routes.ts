import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { SlimeComponent } from './pages/slime/slime.component';
import { LocationComponent } from './pages/location/location.component';
import { FoodComponent } from './pages/food/food.component';
import { PlortsComponent } from './pages/plorts/plorts.component';
import { ToysComponent } from './pages/toys/toys.component';

export const routes: Routes = [
    {
        path: '',
        component: HomeComponent
    },
    {
        path: 'slime/:id',
        component: SlimeComponent
    },
    {
        path: 'location/:id',
        component: LocationComponent
    },
    {
        path: 'fruit/:id',
        component: FoodComponent
    },
    {
        path: 'veggie/:id',
        component: FoodComponent
    },
    {
        path: 'meat/:id',
        component: FoodComponent
    },
    {
        path: 'plorts',
        component: PlortsComponent
    },    
    {
        path: 'toys',
        component: ToysComponent
    },   
];
