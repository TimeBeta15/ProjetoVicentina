import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultacadastroComponent } from './consultacadastro.component';

describe('ConsultacadastroComponent', () => {
  let component: ConsultacadastroComponent;
  let fixture: ComponentFixture<ConsultacadastroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultacadastroComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConsultacadastroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
