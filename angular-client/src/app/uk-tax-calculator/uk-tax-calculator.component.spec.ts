import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UkTaxCalculatorComponent } from './uk-tax-calculator.component';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

describe('UkTaxCalculatorComponent', () => {
  let component: UkTaxCalculatorComponent;
  let fixture: ComponentFixture<UkTaxCalculatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        UkTaxCalculatorComponent,
        HttpClientTestingModule
      ]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UkTaxCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
