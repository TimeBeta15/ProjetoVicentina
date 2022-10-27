import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroadmComponent } from './cadastroadm.component';

describe('CadastroadmComponent', () => {
  let component: CadastroadmComponent;
  let fixture: ComponentFixture<CadastroadmComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastroadmComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastroadmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
