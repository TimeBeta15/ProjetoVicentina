import { Component, OnInit } from '@angular/core';
import { EntradaProduto } from 'src/app/models/EntradaProduto';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela-entradadeproduto',
  templateUrl: './tabela-entradadeproduto.component.html',
  styleUrls: ['./tabela-entradadeproduto.component.css']
})
export class TabelaEntradadeprodutoComponent implements OnInit {
entradaprodutos: any;
EntradaProduto!: EntradaProduto;
data: any;
quantidade!: number;
nome: any;
validade: any;
categoria: any;
entradaprodutosModal: any;
delentradaprodutosModal: any;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {

    this.getEntradaProduto();

  }
  getEntradaProduto()
  {
    this.http.get('https://localhost:7214/api/EntradaProduto')
    .subscribe(response =>{this.entradaprodutos = response
    console.log(this.entradaprodutos)})
  }

  adicionarEntrada() {
    var EntradaProduto = { nome :this.nome, data: this.data,quantidade: this.quantidade,validade: this.validade, categoria: this.categoria};


    this.http.post('https://localhost:7214/api/EntradaProduto', EntradaProduto)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getEntradaProduto();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(entradaproduto: EntradaProduto,template:any){
    console.log(entradaproduto);
    this.EntradaProduto=entradaproduto;
  }
  excluirEntrada(template:any)
  {
    this.http.delete(`${environment.apibaseURL}api/EntradaProduto/${this.EntradaProduto.id}`).subscribe
    (() => { this.getEntradaProduto();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }

  Alterar(entradaproduto: EntradaProduto,template:any)
  {
  console.log(entradaproduto);
  this.EntradaProduto= entradaproduto;
}

  alterarEntrada(template:any) {
    console.log(this.entradaprodutos)
    var entradaprodutos = {id:this.EntradaProduto.id, nome :this.nome, data: this.data,quantidade: this.quantidade,validade: this.validade, categoria: this.categoria};

    this.http.put(`${environment.apibaseURL}api/EntradaProduto/${entradaprodutos.id}`, entradaprodutos)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getEntradaProduto();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }




}
