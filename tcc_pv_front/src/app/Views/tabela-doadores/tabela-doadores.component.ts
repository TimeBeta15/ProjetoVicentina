import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Doadores } from 'src/app/models/doadores';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-tabela-doadores',
  templateUrl: './tabela-doadores.component.html',
  styleUrls: ['./tabela-doadores.component.css']
})
export class TabelaDoadoresComponent implements OnInit {
doadores: any
Doador!:Doadores
data: any
formaDoacao: any
valor!: number
telefone: any
nome: any
doadoresModal: any
deldoadoresModal: any
searchText: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getDoadores();

  }
getDoadores()
{
  this.http.get('https://localhost:7214/api/TabelaDoador')
  .subscribe(response =>{
    this.doadores = response
  console.log(this.doadores)
  });
}
adicionarDoador()
{
var doadores = {data :this.data, nome :this.nome, telefone : this.telefone, formaDoacao :this.formaDoacao, valor : this.valor};

this.http.post('https://localhost:7214/api/TabelaDoador', doadores)
.subscribe(
  resultado => {
    console.log(resultado)
    this.getDoadores();
  },
  erro => {
    if(erro.status == 400) {
      console.log(erro);
    }
  }
);
}
excluir(doadores: Doadores,template:any){
  console.log(doadores);
  this.Doador=doadores;
}
excluirDoador(template:any)
{
  this.http.delete(`${environment.apibaseURL}api/TabelaDoador/${this.Doador.id}`).subscribe
  (() => { this.getDoadores();
  let ref = document.getElementById('cancel')
ref?.click();},
erro => {
  if(erro.status == 404){
    console.log('O item não foi localizado');
  }
}
);
}

Alterar(doadores: Doadores,template:any)
{
console.log(doadores);
this.Doador= doadores;
}

alterarDoador(template:any) {
  console.log(this.doadores)
  var doadoresl = {id:this.Doador.id, data :this.data, nome :this.nome, telefone : this.telefone, formaDoacao: this.formaDoacao, valor : this.valor};

  this.http.put(`${environment.apibaseURL}api/TabelaDoador/${doadoresl.id}`, doadoresl)
  .subscribe(
    resultado => {
      console.log(resultado)
      this.getDoadores();
    },
    erro => {
      if(erro.status == 400) {
        console.log(erro);
      }
    }
  );
}
}
