import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResidentesComponent } from './residentes.component';

describe('ResidentesComponent', () => {
  let component: ResidentesComponent;
  let fixture: ComponentFixture<ResidentesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ResidentesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ResidentesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
