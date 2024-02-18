import { Component } from '@angular/core';
import { ApiService } from 'src/app/services/apiservice.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Vehicle } from '../../model/vehicle.model';
import { feePrice } from 'src/app/model/feePrice.model';

@Component({
  selector: 'app-calculateprice',
  templateUrl: './calculateprice.component.html',
  styleUrls: ['./calculateprice.component.css']
})
export class CalculatePriceComponent {
   vehicleBasePrice: number=0;
  feesPrice?: feePrice;

  vehicleTypes: Vehicle[] = [
    { id: 0, name: 'Common' },
    { id: 1, name: 'Luxury' }
  ];
  vehicleType?: Vehicle; 

  constructor(private apiService: ApiService, private spinner: NgxSpinnerService, private toastr: ToastrService,) {
  }

  ngOnInit(): void {
    this.vehicleType = this.vehicleTypes[0];
  }

  calculateTotal() {
    console.log(this.vehicleType);
    this.apiService.getPrice( this.vehicleType?.id ?? 0, this.vehicleBasePrice ).subscribe((data) => {
      this.feesPrice = data;
  },
      (error) => {
          console.error('The next error has happened: '+error)
          this.spinner.hide();
      });

}
  
}
