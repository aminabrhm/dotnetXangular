import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  name :String;
  constructor(private http: HttpClient) { }

  getMakes(): Observable <any>{
    return this.http.get<any>('/api/makes').pipe(
      tap(data => console.log("data")
        ),
    );
  }

}
