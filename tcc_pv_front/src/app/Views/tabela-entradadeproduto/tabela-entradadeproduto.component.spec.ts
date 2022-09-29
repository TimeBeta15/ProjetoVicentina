import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabelaEntradadeprodutoComponent } from './tabela-entradadeproduto.component';

describe('TabelaEntradadeprodutoComponent', () => {
  let component: TabelaEntradadeprodutoComponent;
  let fixture: ComponentFixture<TabelaEntradadeprodutoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TabelaEntradadeprodutoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabelaEntradadeprodutoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
