/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DoacoesComponent } from './doacoes.component';

describe('DoacoesComponent', () => {
  let component: DoacoesComponent;
  let fixture: ComponentFixture<DoacoesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DoacoesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DoacoesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
