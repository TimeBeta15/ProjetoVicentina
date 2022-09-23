/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Tabela_caixaComponent } from './tabela_caixa.component';

describe('Tabela_caixaComponent', () => {
  let component: Tabela_caixaComponent;
  let fixture: ComponentFixture<Tabela_caixaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Tabela_caixaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Tabela_caixaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
