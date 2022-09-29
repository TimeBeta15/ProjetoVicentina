import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabelaSaidadeprodutoComponent } from './tabela-saidadeproduto.component';

describe('TabelaSaidadeprodutoComponent', () => {
  let component: TabelaSaidadeprodutoComponent;
  let fixture: ComponentFixture<TabelaSaidadeprodutoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TabelaSaidadeprodutoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabelaSaidadeprodutoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
