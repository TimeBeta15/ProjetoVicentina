import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators} from '@angular/forms'
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-cadastroadm',
  templateUrl: './cadastroadm.component.html',
  styleUrls: ['./cadastroadm.component.css']
})
export class CadastroadmComponent implements OnInit {
  public cadastroForm !: FormGroup;

  constructor(private formBuilder : FormBuilder, private http: HttpClient, private router:Router) { }

  ngOnInit(): void {
    this.cadastroForm = this.formBuilder.group({
      name:['',Validators.required],
      email:['',Validators.required],
      password:['',Validators.required]
    })
  }
  signUp(){
    this.http.post(`${environment.apibaseURL}api/Adm`,this.cadastroForm.value)
    .subscribe(res=>{
      alert("Cadastrado com Sucesso");
      this.cadastroForm.reset();
      this.router.navigate(['']);
    },err=>{
      alert("Tente novamente")
    })
  }

}
