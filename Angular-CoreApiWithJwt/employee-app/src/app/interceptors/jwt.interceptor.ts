import { HttpInterceptorFn, HttpRequest, HttpHandler, HttpInterceptor } from '@angular/common/http';
import { AuthService } from '../Services/auth.service';
import { inject } from '@angular/core';

export const jwtInterceptor: HttpInterceptorFn = (req, next) => {
  const authService = inject(AuthService);
  const token = authService.token;
  if(token){
   req = req.clone({
    setHeaders:{
      Authorization : `Bearer ${token}`
    }
   });
  }
  return next(req);
};
