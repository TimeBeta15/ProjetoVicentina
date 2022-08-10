/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ControleComponent } from './controle.component';

describe('ControleComponent', () => {
  let component: ControleComponent;
  let fixture: ComponentFixture<ControleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ControleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ControleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
