import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Residente } from 'src/app/models/Residente';
@Component({
  selector: 'app-tabela-residentes',
  templateUrl: './tabela-residentes.component.html',
  styleUrls: ['./tabela-residentes.component.css']
})
export class TabelaResidentesComponent implements OnInit {
  residente: any
  Residente!: Residente
  Dataregistro: any
  Nome: any
  DataNasc: any
  genero: any
  aposentado!: boolean
  endereco: any
  emprestimonome!: boolean
  emprestimonomepessoa: any
  grauldependencia: any
  deficiencia!: boolean
  deficiencianome: any
  doenca!: boolean
  doencanome: any
  remediocontrol!: boolean
  remediocontrolnome: any
  motivoprocura: any
  nomeprocura: any
  grauparente: any
  enderecoparente: any
  telefone: any
  residentesModal: any
  delresidentesModal: any







  constructor(private http:HttpClient) { }

  ngOnInit(): void {
    this.getResidente()
  }
  getResidente()
  {
    this.http.get('https://localhost:7214/api/TabelaResidente')
    .subscribe(response =>{
      this.residente = response
    console.log(this.residente)});
  }
  adicionarresidente() {
    var residente = { Dataregistro: this.Dataregistro, nome: this.Nome, dataNasc : this.DataNasc, genero: this.genero, aposentado: this.aposentado,
    endereco: this.endereco, emprestimonome: this.emprestimonome, emprestimonomepessoa: this.emprestimonomepessoa, grauldependencia: this.grauldependencia,
  deficiencia: this.deficiencia, deficiencianome: this.deficiencianome, doenca: this.doenca, doencanome: this.doencanome, remediocontrol: this.remediocontrol,
remediocontrolnome: this.remediocontrolnome, motivoprocura: this.motivoprocura, nomeprocura: this.nomeprocura, grauparente: this.grauparente,
enderecoparente: this.enderecoparente, telefone: this.telefone};


    this.http.post('https://localhost:7214/api/TabelaResidente',residente)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.adicionarresidente();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(residente: Residente,template:any){
    console.log(residente);
    this.Residente=residente;
  }
  excluirResidente(template:any)
  {
    this.http.delete(`${environment.apibaseURL}api/TabelaResidente/${this.residente.id}`).subscribe
    (() => { this.getResidente();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }
  Alterar(residente: Residente,template:any)
  {
  console.log(residente);
  this.Residente= residente;
  }

  alterarResidente(template:any) {
    console.log(this.residente)
    var residente = {id:this.Residente.id, Dataregistro: this.Dataregistro, nome: this.Nome, dataNasc : this.DataNasc, genero: this.genero, aposentado: this.aposentado,
      endereco: this.endereco, emprestimonome: this.emprestimonome, emprestimonomepessoa: this.emprestimonomepessoa, grauldependencia: this.grauldependencia,
    deficiencia: this.deficiencia, deficiencianome: this.deficiencianome, doenca: this.doenca, doencanome: this.doencanome, remediocontrol: this.remediocontrol,
  remediocontrolnome: this.remediocontrolnome, motivoprocura: this.motivoprocura, nomeprocura: this.nomeprocura, grauparente: this.grauparente,
  enderecoparente: this.enderecoparente, telefone: this.telefone};

    this.http.put(`${environment.apibaseURL}api/Tabelaresidente/${residente.id}`, residente)
    .subscribe(
      resultado => {
        console.log(resultado)
        this.getResidente();
      },
      erro => {
        if(erro.status == 400) {
          console.log(erro);
        }
      }
    );
  }
}
