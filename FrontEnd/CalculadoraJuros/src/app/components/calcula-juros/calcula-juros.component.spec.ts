import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculaJurosComponent } from './calcula-juros.component';

describe('CalculaJurosComponent', () => {
  let component: CalculaJurosComponent;
  let fixture: ComponentFixture<CalculaJurosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CalculaJurosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CalculaJurosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
