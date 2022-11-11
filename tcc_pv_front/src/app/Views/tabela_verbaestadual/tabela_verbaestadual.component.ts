import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { VerbaEstadual } from 'src/app/models/VerbaEstadual';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela_verbaestadual',
  templateUrl: './tabela_verbaestadual.component.html',
  styleUrls: ['./tabela_verbaestadual.component.css']
})
export class Tabela_verbaestadualComponent implements OnInit {
  verbaestadual: any;
  VerbaEstadual!: VerbaEstadual;
  entrada!: number;
  saida!: number;
  valor = this.saida - this.entrada;
  data: any;
  description: any;
  verbesModal: any;
  delverbesModal: any;
  editverbesModal: any;

  constructor(private Http :HttpClient) { }

  ngOnInit() { this.getVerbaEstadual();
  }
  getVerbaEstadual()
  {
    this.Http.get('https://localhost:7214/api/TabelaVerbaEstadual')
    .subscribe(response =>{
      this.verbaestadual = response
    console.log(this.verbaestadual)});

  }
  adicionarVerba() {
    var VerbaEstadual = { description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};


    this.Http.post('https://localhost:7214/api/TabelaVerbaEstadual', VerbaEstadual)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getVerbaEstadual();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(verbaestadual: VerbaEstadual,template:any){
    console.log(verbaestadual);
    this.VerbaEstadual=verbaestadual;
  }
  excluirVerba(template:any)
  {
    this.Http.delete(`${environment.apibaseURL}api/TabelaVerbaEstadual/${this.VerbaEstadual.id}`).subscribe
    (() => { this.getVerbaEstadual();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }

  Alterar(verbaestadual: VerbaEstadual,template:any)
  {
  console.log(verbaestadual);
  this.VerbaEstadual= verbaestadual;
}

  alterarVerba(template:any) {
    console.log(this.verbaestadual)
    var verbaestaduals = {id:this.VerbaEstadual.id, description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};

    this.Http.put(`${environment.apibaseURL}api/TabelaVerbaEstadual/${verbaestaduals.id}`, verbaestaduals)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getVerbaEstadual();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }
}
