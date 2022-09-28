/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Tabela_verbaestadualComponent } from './tabela_verbaestadual.component';

describe('Tabela_verbaestadualComponent', () => {
  let component: Tabela_verbaestadualComponent;
  let fixture: ComponentFixture<Tabela_verbaestadualComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Tabela_verbaestadualComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Tabela_verbaestadualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
