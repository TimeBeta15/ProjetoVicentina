import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { TabelaCaixa } from 'src/app/models/TabelaCaixa';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela_caixa',
  templateUrl: './tabela_caixa.component.html',
  styleUrls: ['./tabela_caixa.component.css']
})
export class Tabela_caixaComponent implements OnInit {
  caixas: any;
  caixa: any;
  TabelaCaixa!: TabelaCaixa;
  entrada!: number;
  saida!: number;
  valor = this.saida - this.entrada;
  data: any;
  description: any;
  verbmunModal: any;
  caixaModal: any;
  delcaixaModal: any
  searchText: any;

  constructor(private http: HttpClient) { }

  ngOnInit(
  ) {
    this.getCaixa();
  }


  getCaixa() {
    this.http.get('https://localhost:7214/api/TabelaCaixa')
      .subscribe(response => {
        this.caixa = response
        console.log(this.caixas)
      })
  }

  adicionarCaixa() {
    var TabelaCaixa = { description: this.description, data: this.data, entrada: this.entrada, saida: this.saida, valor: this.valor };

    this.http.post('https://localhost:7214/api/TabelaCaixa', TabelaCaixa)
      .subscribe(
        resultado => {
          console.log(resultado)
          this.getCaixa();
        },
        erro => {
          if (erro.status == 400) {
            console.log(erro);
          }
        }
      );
  }
  excluir(caixa: TabelaCaixa, template: any) {
    console.log(caixa);
    this.TabelaCaixa = caixa;
  }
  excluirCaixa(template: any) {
    this.http.delete(`${environment.apibaseURL}api/Tabelacaixa/${this.TabelaCaixa.id}`).subscribe
      (() => {
        this.getCaixa();
        let ref = document.getElementById('cancel')
        ref?.click();
      },
        erro => {
          if (erro.status == 404) {
            console.log('O item não foi localizado');
          }
        }
      );
  }

  Alterar(caixa: TabelaCaixa, template: any) {
    console.log(caixa);
    this.TabelaCaixa = caixa;
  }

  alterarCaixa(template: any) {
    console.log(this.caixa)
    var caixas = { id: this.TabelaCaixa.id, description: this.description, data: this.data, entrada: this.entrada, saida: this.saida, valor: this.valor };

    this.http.put(`${environment.apibaseURL}api/TabelaCaixa/${caixas.id}`, caixas)
      .subscribe(
        resultado => {
          console.log(resultado)
          this.getCaixa();
        },
        erro => {
          if (erro.status == 400) {
            console.log(erro);
          }
        }
      );
  }

}
