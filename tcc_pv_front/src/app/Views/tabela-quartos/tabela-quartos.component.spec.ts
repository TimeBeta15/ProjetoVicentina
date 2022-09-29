import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabelaQuartosComponent } from './tabela-quartos.component';

describe('TabelaQuartosComponent', () => {
  let component: TabelaQuartosComponent;
  let fixture: ComponentFixture<TabelaQuartosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TabelaQuartosComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabelaQuartosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
