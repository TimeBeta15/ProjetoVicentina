import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DoacoesComponent } from './doacoes.component';

describe('DoacoesComponent', () => {
  let component: DoacoesComponent;
  let fixture: ComponentFixture<DoacoesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DoacoesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DoacoesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
