import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InformationsUserComponent } from './informations-user.component';

describe('InformationsUserComponent', () => {
  let component: InformationsUserComponent;
  let fixture: ComponentFixture<InformationsUserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InformationsUserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InformationsUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
