import { Injectable } from '@angular/core';

declare let alertify:any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() {
    alertify.set('notifier', 'position', 'top-right');
   }

success(message:string){
  alertify.success(message);
}

warning(message:string){
  alertify.warning(message);
}

error(message:string){
  alertify.error(message);
}

message(message:string){
  alertify.message(message);
}

confirm(message:string,okCallBack:()=>any){
  alertify.confirm(message,function(){
    okCallBack();
  });
}

}