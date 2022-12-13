import {  Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AlertifyService } from '../services/alertify.service';

@Injectable()
export class SecurityGuard implements CanActivate {

  constructor(private router:Router, private alertifyService:AlertifyService) {
    
  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    let securityControl = false;

    if(localStorage.getItem("isLogged") != null && localStorage.getItem("isLogged") == "true"){
      securityControl = true;
    }

    if(securityControl){
      //devam et.
    }
    else{
      this.router.navigate(["giris"]);

      this.alertifyService.error("Lütfen kullanıcı girişi yapınız.");
    }

    return securityControl;
  }
}
