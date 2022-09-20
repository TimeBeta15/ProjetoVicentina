import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResidenteComponent } from './residente.component';

describe('ResidenteComponent', () => {
  let component: ResidenteComponent;
  let fixture: ComponentFixture<ResidenteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ResidenteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ResidenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
