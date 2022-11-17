import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { EmendaParlamentar } from 'src/app/models/EmendaParlamentar';

@Component({
  selector: 'app-tabela_emendaparlamentar',
  templateUrl: './tabela_emendaparlamentar.component.html',
  styleUrls: ['./tabela_emendaparlamentar.component.css']
})
export class Tabela_emendaparlamentarComponent implements OnInit {

  constructor(private http : HttpClient) { }
emendaparlamentar: any;
description: any;
EmendaImpositivas: any;
entrada!: number;
saida!: number;
EmendaParlamentar!: EmendaParlamentar
data: any;
delemenparlModal: any;
emendaparlModal: any;
valor = this.saida - this.entrada;
  ngOnInit() {
    this.getEmendaParlamentar();
  }
getEmendaParlamentar()
{
  this.http.get('https://localhost:7214/api/TabelaEmendaParlamentar')
  .subscribe(response =>{
    this.emendaparlamentar = response
  console.log(this.emendaparlamentar)});
}
adicionarEmendaParlamentar() {
  var EmendaParlamentar = { description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};


  this.http.post('https://localhost:7214/api/TabelaEmendaParlamentar',EmendaParlamentar)
            .subscribe(
              resultado => {
                console.log(resultado)
                this.getEmendaParlamentar();
              },
              erro => {
                if(erro.status == 400) {
                  console.log(erro);
                }
              }
            );

}
excluir(emendaparlamentar: EmendaParlamentar,template:any){
  console.log(emendaparlamentar);
  this.EmendaParlamentar=emendaparlamentar;
}
excluirEmenda(template:any)
{
  this.http.delete(`${environment.apibaseURL}api/TabelaEmendaParlamentar/${this.EmendaParlamentar.id}`).subscribe
  (() => { this.getEmendaParlamentar();
  let ref = document.getElementById('cancel')
ref?.click();},
erro => {
  if(erro.status == 404){
    console.log('O item não foi localizado');
  }
}
);
}
Alterar(emendaparlamentar: EmendaParlamentar,template:any)
{
console.log(emendaparlamentar);
this.EmendaParlamentar= emendaparlamentar;
}

alterarEmendaParlamentar(template:any) {
  console.log(this.emendaparlamentar)
  var emendaparlamentares = {id:this.EmendaParlamentar.id, description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};

  this.http.put(`${environment.apibaseURL}api/TabelaEmendaParlamentar/${emendaparlamentares.id}`, emendaparlamentares)
  .subscribe(
    resultado => {
      console.log(resultado)
      this.getEmendaParlamentar();
    },
    erro => {
      if(erro.status == 400) {
        console.log(erro);
      }
    }
  );
}

}
