import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabelaResidentesComponent } from './tabela-residentes.component';

describe('TabelaResidentesComponent', () => {
  let component: TabelaResidentesComponent;
  let fixture: ComponentFixture<TabelaResidentesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TabelaResidentesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabelaResidentesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
