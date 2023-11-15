import { Routes } from '@angular/router';
import { UkTaxCalculatorComponent } from './uk-tax-calculator/uk-tax-calculator.component';

export const routes: Routes = [
    { path: 'tax-calculator', component: UkTaxCalculatorComponent },
    { path: '',   redirectTo: '/tax-calculator', pathMatch: 'full' }
];
