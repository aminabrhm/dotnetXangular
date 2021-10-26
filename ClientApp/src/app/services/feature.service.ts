import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {

  name :String;
  constructor(private http: HttpClient) { }

  getFeatures(): Observable <any>{
    return this.http.get<any>('/api/features').pipe(
      tap(data => console.log("data")
        ),
    );
  }
}
