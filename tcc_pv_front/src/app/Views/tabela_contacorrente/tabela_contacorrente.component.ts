import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ContaCorrente } from 'src/app/models/ContaCorrente';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela_contacorrente',
  templateUrl: './tabela_contacorrente.component.html',
  styleUrls: ['./tabela_contacorrente.component.css']
})
export class Tabela_contacorrenteComponent implements OnInit {
contacorrente: any;

description: any;
contacorrentes: any;
entrada!: number;
saida!: number;
ContaCorrente!: ContaCorrente
data: any;
delcontcorModal: any;
contcorModal: any;
valor = this.saida - this.entrada;
  constructor(private Http: HttpClient) { }

  ngOnInit(): void{
    this.getContaCorrente();
  }
  getContaCorrente()
  {
    this.Http.get('https://localhost:7214/api/TabelaContaCorrente')
    .subscribe(response =>{
      this.contacorrente = response
    console.log(this.contacorrente)});
  }
  adicionarContaCorrente() {
    var ContaCorrente = { description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};


    this.Http.post('https://localhost:7214/api/TabelaContaCorrente',ContaCorrente)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getContaCorrente();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(contacorrente: ContaCorrente,template:any){
    console.log(contacorrente);
    this.ContaCorrente=contacorrente;
  }
  excluirSaidacontcorre(template:any)
  {
    this.Http.delete(`${environment.apibaseURL}api/TabelaContaCorrente/${this.ContaCorrente.id}`).subscribe
    (() => { this.getContaCorrente();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }

  Alterar(contacorrente: ContaCorrente,template:any)
  {
  console.log(contacorrente);
  this.ContaCorrente= contacorrente;
}

  alterarContaCapital(template:any) {
    console.log(this.contacorrente)
    var contacorrentes = {id:this.ContaCorrente.id, description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};

    this.Http.put(`${environment.apibaseURL}api/TabelaContaCorrente/${contacorrentes.id}`, contacorrentes)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getContaCorrente();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }

}
