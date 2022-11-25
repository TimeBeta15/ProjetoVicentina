import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Fornecedores } from 'src/app/models/Fornecedores';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-tabela-fornecedores',
  templateUrl: './tabela-fornecedores.component.html',
  styleUrls: ['./tabela-fornecedores.component.css']
})
export class TabelaFornecedoresComponent implements OnInit {
fornecedores: any
Fornecedor!:Fornecedores
data: any
nome: any
telefone: any
nomeproduto: any
categoria: any
forenecedoresModal: any
delfornecedoresModal: any
quantidade!: number
searchText: any;

  constructor(private Http: HttpClient) { }

  ngOnInit(): void {
    this.getFornecedores();

  }
getFornecedores()
{
  this.Http.get('https://localhost:7214/api/TabelaFornecedor')
  .subscribe(response =>{
    this.fornecedores = response
    console.log(this.fornecedores)
  });
}
adicionarFornecedor()
{
  var Fornecedores = { data: this.data, nome: this.nome, telefone: this.telefone, categoria: this.categoria, nomeproduto: this.nomeproduto, quantidade: this.quantidade};


    this.Http.post('https://localhost:7214/api/TabelaFornecedor', Fornecedores)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getFornecedores();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );
}
excluir(fornecedores: Fornecedores,template:any){
  console.log(fornecedores);
  this.Fornecedor=fornecedores;
}
excluirFornecedor(template:any)
  {
    this.Http.delete(`${environment.apibaseURL}api/TabelaFornecedor/${this.Fornecedor.id}`).subscribe
    (() => { this.getFornecedores();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }
  Alterar(verbamunicipal: Fornecedores,template:any)
  {
  console.log(verbamunicipal);
  this.Fornecedor= verbamunicipal;
}

  alterarFornecedor(template:any) {
    console.log(this.fornecedores)
    var fornecedoress = {id:this.Fornecedor.id, data: this.data, nome: this.nome, telefone: this.telefone, categoria: this.categoria, nomeproduto: this.nomeproduto, quantidade: this.quantidade};

    this.Http.put(`${environment.apibaseURL}api/TabelaFornecedor/${fornecedoress.id}`, fornecedoress)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getFornecedores();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }
}
