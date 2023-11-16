import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { TaxCalculationResults } from '../Dtos/tax-calculation-results';
import { TaxCalculatorService } from '../services/tax-calculator.service';

@Component({
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './uk-tax-calculator.component.html',
  styleUrl: './uk-tax-calculator.component.sass'
})
export class UkTaxCalculatorComponent implements OnInit {
  constructor(
    private formBuilder: FormBuilder,
    private taxCalculatorService: TaxCalculatorService
  ) {}

  salaryInputForm!: FormGroup<{salary: FormControl<number | null>}>;
  taxCalculationResults: TaxCalculationResults | null = null;

  ngOnInit(): void {
    this.salaryInputForm = this.formBuilder.group({
      salary: 0
    });
  }

  onSubmit(): void {
    this.taxCalculatorService
      .getUkIncomeTaxCalculationResults(this.salaryInputForm.value.salary!)
      .subscribe(x => {
        this.taxCalculationResults = x;
      }, console.error);
  }
}
