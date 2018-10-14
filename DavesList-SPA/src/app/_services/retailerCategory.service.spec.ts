/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { RetailerCategoryService } from './retailerCategory.service';

describe('Service: RetailerCategory', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RetailerCategoryService]
    });
  });

  it('should ...', inject([RetailerCategoryService], (service: RetailerCategoryService) => {
    expect(service).toBeTruthy();
  }));
});
