import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TaxCalculationResults } from '../Dtos/tax-calculation-results';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class TaxCalculatorService {
  constructor(private http: HttpClient) { }

  getUkIncomeTaxCalculationResults(grossAnnualSalary: number): Observable<TaxCalculationResults> {
    return this.http.get<TaxCalculationResults>(`/api/UKIncomeTax/${grossAnnualSalary}`);
  }
}
