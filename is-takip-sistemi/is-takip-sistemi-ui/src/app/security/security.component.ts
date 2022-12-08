import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-security',
  templateUrl: './security.component.html',
  styleUrls: ['./security.component.css']
})
export class SecurityComponent {
  frmLogin!: FormGroup;
  submitted!:boolean;
  constructor(private formBuilder: FormBuilder) {

  }

  ngOnInit() {
    this.frmLogin = this.formBuilder.group({
      userName: ["",[Validators.required, Validators.minLength(5), Validators.maxLength(20)]],
      password: ["",[Validators.required, Validators.minLength(5), Validators.maxLength(20)]]
    });
  }

  get component(){return this.frmLogin.controls};

  onSubmit(data: any) {
    this.submitted = true;
    if(this.frmLogin.invalid)
      return;
    console.log(data);
  }
}
