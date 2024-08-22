import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { SlimeComponent } from './pages/slime/slime.component';

export const routes: Routes = [
    {
        path: '',
        component: HomeComponent
    },
    {
        path: 'slime/:id',
        component: SlimeComponent
    }
];
