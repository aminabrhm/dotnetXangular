import { VehicleService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';
import { FeatureService } from 'src/app/services/feature.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})

export class VehicleFormComponent implements OnInit {

  makes: any[]
  models:any[]
  feature: any[]
  vehicle:any ={}
  constructor(private makeService: VehicleService,
    private featureService:FeatureService
    ) { }

  ngOnInit(): void {
    this.makeService.getMakes().subscribe(
      makes => { this.makes = makes
      console.log(makes);
      }
    )  
    this.featureService.getFeatures().subscribe(
      feature => { this.feature = feature
        console.log(feature);
      }
    )  
  }

  onMakeChange(){
    console.log("vehicle");
    console.log(this.vehicle)
    var selectedMake= this.makes.find(m=>m.id == this.vehicle.make)
    this.models =selectedMake? selectedMake.models : []
  }
}
