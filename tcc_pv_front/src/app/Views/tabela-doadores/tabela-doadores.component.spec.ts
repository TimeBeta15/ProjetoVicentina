import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TabelaDoadoresComponent } from './tabela-doadores.component';

describe('TabelaDoadoresComponent', () => {
  let component: TabelaDoadoresComponent;
  let fixture: ComponentFixture<TabelaDoadoresComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TabelaDoadoresComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TabelaDoadoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
