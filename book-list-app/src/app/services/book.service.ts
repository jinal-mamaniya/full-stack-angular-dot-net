import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Book } from '../books';
@Injectable({
  providedIn: 'root'
})
export class BookService {

  private apiUrl = 'https://localhost:7123/';
  constructor( private http: HttpClient) { }
 
  getBooks(): Observable<Book[]> {
    return this.http.get<Book[]>(this.apiUrl + 'api/Books');
  }

}
