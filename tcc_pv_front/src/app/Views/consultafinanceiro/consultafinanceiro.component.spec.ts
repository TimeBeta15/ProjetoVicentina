import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultafinanceiroComponent } from './consultafinanceiro.component';

describe('ConsultafinanceiroComponent', () => {
  let component: ConsultafinanceiroComponent;
  let fixture: ComponentFixture<ConsultafinanceiroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultafinanceiroComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConsultafinanceiroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
