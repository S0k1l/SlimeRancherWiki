import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { SlimeComponent } from './pages/slime/slime.component';
import { LocationComponent } from './pages/location/location.component';

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
];
