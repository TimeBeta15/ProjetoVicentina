/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Tabela_verbamunicipalComponent } from './tabela_verbamunicipal.component';

describe('Tabela_verbamunicipalComponent', () => {
  let component: Tabela_verbamunicipalComponent;
  let fixture: ComponentFixture<Tabela_verbamunicipalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Tabela_verbamunicipalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Tabela_verbamunicipalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
