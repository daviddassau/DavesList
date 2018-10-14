/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { RetailerService } from './retailer.service';

describe('Service: Retailer', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RetailerService]
    });
  });

  it('should ...', inject([RetailerService], (service: RetailerService) => {
    expect(service).toBeTruthy();
  }));
});
