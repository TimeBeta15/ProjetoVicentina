import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { produto } from 'src/app/models/Produto';

@Component({
  selector: 'app-tabela_caixa',
  templateUrl: './tabela_caixa.component.html',
  styleUrls: ['./tabela_caixa.component.css']
})
export class Tabela_caixaComponent implements OnInit {
  produtos: any;
  desc: any;
  Produto!: produto
  constructor(private http: HttpClient) { }

  ngOnInit(
  ) {
    this.getProdutos();
  }


  getProdutos()
  {
    this.http.get('https://localhost:7214/api/Produto')
    .subscribe(response =>{this.produtos = response
    console.log(this.produtos)})
  }

  adicionarProduto() {
    var produto = { description :this.desc};

    this.http.post('https://localhost:7214/api/Produto', produto)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getProdutos();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );
  }

  // excluirProduto('https://localhost:7214/api/Produto') {
  //   this.http.delete()
  //             .subscribe(
  //               resultado => {
  //                 console.log('Produto excluído com sucesso.');
  //               },
  //               erro => {
  //                 if(erro.status == 404) {
  //                   console.log('Produto não localizado.');
  //                 }
  //               }
  //             );
  // }

}
