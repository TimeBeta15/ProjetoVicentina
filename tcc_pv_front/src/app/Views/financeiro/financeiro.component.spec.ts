import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FinanceiroComponent } from './financeiro.component';

describe('FinanceiroComponent', () => {
  let component: FinanceiroComponent;
  let fixture: ComponentFixture<FinanceiroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FinanceiroComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FinanceiroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
