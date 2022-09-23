/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Tabela_emendaimpositivaComponent } from './tabela_emendaimpositiva.component';

describe('Tabela_emendaimpositivaComponent', () => {
  let component: Tabela_emendaimpositivaComponent;
  let fixture: ComponentFixture<Tabela_emendaimpositivaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Tabela_emendaimpositivaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Tabela_emendaimpositivaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
