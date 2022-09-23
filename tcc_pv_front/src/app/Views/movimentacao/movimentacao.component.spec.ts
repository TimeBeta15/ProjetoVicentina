import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovimentacaoComponent } from './movimentacao.component';

describe('MovimentacaoComponent', () => {
  let component: MovimentacaoComponent;
  let fixture: ComponentFixture<MovimentacaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MovimentacaoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MovimentacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
