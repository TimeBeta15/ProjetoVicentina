import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultaestoqueComponent } from './consultaestoque.component';

describe('ConsultaestoqueComponent', () => {
  let component: ConsultaestoqueComponent;
  let fixture: ComponentFixture<ConsultaestoqueComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultaestoqueComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConsultaestoqueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
