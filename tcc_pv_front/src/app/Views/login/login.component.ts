import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

public loginForm !: FormGroup;


constructor(private formBuilder : FormBuilder, private http : HttpClient, private router : Router) { }

ngOnInit(): void {
  this.loginForm = this.formBuilder.group({
    name:['',Validators.required],
    password:['',Validators.required]
  });

}

entrar(){
  this.http.get(`${environment.apibaseURL}api/Adm`)
  .subscribe((res:any)=>{
    const user = res.find((a:any)=>{
      return a.name ===  this.loginForm.value.name && a.password ===  this.loginForm.value.password
    });
    if(user){
      this.loginForm.reset();
      this.router.navigate(['home']);
    }else{
      alert("Dados Inválidos");
    }
  })
}

}
