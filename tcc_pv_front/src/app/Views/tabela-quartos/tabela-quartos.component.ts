import { Component, OnInit } from '@angular/core';
import { Quartos } from 'src/app/models/Quartos';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';


@Component({
  selector: 'app-tabela-quartos',
  templateUrl: './tabela-quartos.component.html',
  styleUrls: ['./tabela-quartos.component.css']
})
export class TabelaQuartosComponent implements OnInit {
nome: any
numeroquarto: any
data: any
quartos: any
Quartos!: Quartos
delquartosModal: any
quartosModal: any;
searchText: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void { this.getQuartos()
  }
getQuartos()
{
  this.http.get('https://localhost:7214/api/TabelaQuarto')
    .subscribe(response =>{this.quartos = response
    console.log(this.quartos)})
}
adicionarQuartos() {
  var EntradaProduto = { nome :this.nome, data: this.data,numeroquarto: this.numeroquarto};


  this.http.post('https://localhost:7214/api/TabelaQuarto', EntradaProduto)
            .subscribe(
              resultado => {
                console.log(resultado)
                this.getQuartos();
              },
              erro => {
                if(erro.status == 400) {
                  console.log(erro);
                }
              }
            );

}
excluir(quartos: Quartos,template:any){
  console.log(quartos);
  this.Quartos=quartos;
}
excluirQuartos(template:any)
{
  this.http.delete(`${environment.apibaseURL}api/TabelaQuarto/${this.Quartos.id}`).subscribe
  (() => { this.getQuartos();
  let ref = document.getElementById('cancel')
ref?.click();},
erro => {
  if(erro.status == 404){
    console.log('O item não foi localizado');
  }
}
);
}
Alterar(quartos: Quartos,template:any)
{
console.log(quartos);
this.Quartos= quartos;
}

alterarQuartos(template:any) {
  console.log(this.quartos)
  var quartoss = {id:this.Quartos.id, nome :this.nome, data: this.data,numeroquarto: this.numeroquarto};

  this.http.put(`${environment.apibaseURL}api/TabelaQuartos/${this.quartos.id}`, quartoss)
  .subscribe(
    resultado => {
      console.log(resultado)
      this.getQuartos();
    },
    erro => {
      if(erro.status == 400) {
        console.log(erro);
      }
    }
  );
}



}
