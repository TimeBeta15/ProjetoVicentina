import { EmendaImpositiva } from 'src/app/models/EmendaImpositiva';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela_emendaimpositiva',
  templateUrl: './tabela_emendaimpositiva.component.html',
  styleUrls: ['./tabela_emendaimpositiva.component.css']
})
export class Tabela_emendaimpositivaComponent implements OnInit {
  emendaimpositiva: any;

description: any;
EmendaImpositivas: any;
entrada!: number;
saida!: number;
EmendaImpositiva!: EmendaImpositiva
data: any;
delemenimpModal: any;
emenimpModal: any;
searchText: any;

valor = this.saida - this.entrada;

  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.getEmendaImpositiva();
  }
  getEmendaImpositiva()
  {
    this.http.get('https://localhost:7214/api/TabelaEmendaImpositiva')
    .subscribe(response =>{
      this.emendaimpositiva = response
    console.log(this.emendaimpositiva)});
  }
  adicionarEmendaImpositiva() {
    var EmendaImpositiva = { description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};


    this.http.post('https://localhost:7214/api/TabelaEmendaImpositiva',EmendaImpositiva)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getEmendaImpositiva();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(emendaimpositiva: EmendaImpositiva,template:any){
    console.log(emendaimpositiva);
    this.EmendaImpositiva=emendaimpositiva;
  }
  excluirEmenda(template:any)
  {
    this.http.delete(`${environment.apibaseURL}api/TabelaEmendaImpositiva/${this.EmendaImpositiva.id}`).subscribe
    (() => { this.getEmendaImpositiva();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }

  Alterar(emendaimpositiva: EmendaImpositiva,template:any)
  {
  console.log(emendaimpositiva);
  this.EmendaImpositiva= emendaimpositiva;
}

  alterarEmendaImpositiva(template:any) {
    console.log(this.emendaimpositiva)
    var emendaimpositivas = {id:this.EmendaImpositiva.id, description :this.description, data: this.data,entrada: this.entrada,saida: this.saida, valor: this.valor};

    this.http.put(`${environment.apibaseURL}api/TabelaEmendaImpositiva/${emendaimpositivas.id}`, emendaimpositivas)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getEmendaImpositiva();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }
}
