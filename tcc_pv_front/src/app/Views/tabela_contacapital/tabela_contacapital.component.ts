import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ContaCapital } from 'src/app/models/ContaCapital';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela_contacapital',
  templateUrl: './tabela_contacapital.component.html',
  styleUrls: ['./tabela_contacapital.component.css']
})
export class Tabela_contacapitalComponent implements OnInit {
contacapital: any;

description: any;
contacapitals: any;
entrada!: number;
saida!: number;
ContaCapital!: ContaCapital
data: any;
delcontcapModal: any;
contcapModal: any;
valor = this.saida - this.entrada;
searchText: any;

  constructor(private Http: HttpClient) { }

  ngOnInit(): void{
    this.getContaCapital();
  }
  getContaCapital()
  {
    this.Http.get('https://localhost:7214/api/TabelaContaCapital')
    .subscribe(response =>{
      this.contacapital = response
    console.log(this.contacapital)});
  }
  adicionarContaCapital() {
    var ContaCapital = { description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};


    this.Http.post('https://localhost:7214/api/TabelaContaCapital',ContaCapital)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getContaCapital();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(contacapital: ContaCapital,template:any){
    console.log(contacapital);
    this.ContaCapital=contacapital;
  }
  excluirSaidaProduto(template:any)
  {
    this.Http.delete(`${environment.apibaseURL}api/TabelaContaCapital/${this.ContaCapital.id}`).subscribe
    (() => { this.getContaCapital();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }

  Alterar(contacapital: ContaCapital,template:any)
  {
  console.log(contacapital);
  this.ContaCapital= contacapital;
}

  alterarContaCapital(template:any) {
    console.log(this.contacapital)
    var contacapitals = {id:this.ContaCapital.id, description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};

    this.Http.put(`${environment.apibaseURL}api/TabelaContaCapital/${contacapitals.id}`, contacapitals)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getContaCapital();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }

}
