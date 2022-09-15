import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EstoqueComponent } from './estoque.component';

describe('EstoqueComponent', () => {
  let component: EstoqueComponent;
  let fixture: ComponentFixture<EstoqueComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EstoqueComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EstoqueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
