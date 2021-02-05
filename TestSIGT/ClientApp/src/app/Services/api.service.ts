import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class APIService {

  private Url = "https://localhost:44395";

 
  constructor(private http: HttpClient) {
  }

 public  getUser(id) {
    return this.http.get<User>(this.Url + '/api/user/' + id);

  }
  getExperiences(id) {
    return this.http.get<Experience[]>(this.Url + '/api/Experience/' + id);
  }
}
