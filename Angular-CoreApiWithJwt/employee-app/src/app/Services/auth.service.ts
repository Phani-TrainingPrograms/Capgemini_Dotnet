import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { AuthResponse } from '../Models/auth-response';
import { LoginModel } from '../Models/login-model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'http://localhost:5099/api/auth';

  private currentSubject = new BehaviorSubject<AuthResponse | null>(null);
  constructor(private http: HttpClient) {
    const user = localStorage.getItem('currentUser');
    if(user){
      this.currentSubject.next(JSON.parse(user))
    }
   }

   login(model: LoginModel): Observable<AuthResponse> {
    return this.http.post<AuthResponse>(`${this.apiUrl}/login`, model)
      .pipe(tap(response => {
        localStorage.setItem('currentUser', JSON.stringify(response));
        this.currentSubject.next(response);
      }));
  }

  logout(): void {
    localStorage.removeItem('currentUser');
    this.currentSubject.next(null);
  }

  get currentUser(): AuthResponse | null {
    return this.currentSubject.value;
  }

  get isAdmin(): boolean {
    return this.currentUser?.roles.includes('Admin') ?? false;
  }

  get isAuthenticated(): boolean {
    return !!this.currentUser;
  }

  get token(): string | null {
    return this.currentUser?.token ?? null;
  }
}
