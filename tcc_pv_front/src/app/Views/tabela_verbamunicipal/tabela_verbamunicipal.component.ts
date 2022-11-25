import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { VerbaMunicipal } from 'src/app/models/VerbaMunicipal';


@Component({
  selector: 'app-tabela_verbamunicipal',
  templateUrl: './tabela_verbamunicipal.component.html',
  styleUrls: ['./tabela_verbamunicipal.component.css']
})
export class Tabela_verbamunicipalComponent implements OnInit {

  verbamunicipal: any;
  VerbaMunicipal!: VerbaMunicipal;
  entrada!: number;
  saida!: number;
  valor = this.saida - this.entrada;
  data: any;
  description: any;
  verbmunModal: any;
  delverbmunModal: any;
  editverbmunModal: any
  searchText: any;

  constructor(private Http: HttpClient) { }

  ngOnInit() {
    this.getVerbaMunicipal();
  }
  getVerbaMunicipal() {
    this.Http.get('https://localhost:7214/api/TabelaVerbaMunicipal')
      .subscribe(response => {
        this.verbamunicipal = response
        console.log(this.verbamunicipal)
      });

  }
  adicionarVerba() {
    var VerbaMunicipal = { description: this.description, data: this.data, entrada: this.entrada, saida: this.saida, valor: this.valor };


    this.Http.post('https://localhost:7214/api/TabelaVerbaMunicipal', VerbaMunicipal)
      .subscribe(
        resultado => {
          console.log(resultado)
          this.getVerbaMunicipal();
        },
        erro => {
          if (erro.status == 400) {
            console.log(erro);
          }
        }
      );

  }
  excluir(verbamunicipal: VerbaMunicipal, template: any) {
    console.log(verbamunicipal);
    this.VerbaMunicipal = verbamunicipal;
  }
  excluirVerba(template: any) {
    this.Http.delete(`${environment.apibaseURL}api/TabelaVerbaMunicipal/${this.VerbaMunicipal.id}`).subscribe
      (() => {
        this.getVerbaMunicipal();
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

  Alterar(verbamunicipal: VerbaMunicipal, template: any) {
    console.log(verbamunicipal);
    this.VerbaMunicipal = verbamunicipal;
  }

  alterarVerba(template: any) {
    console.log(this.verbamunicipal)
    var verbamunicipals = { id: this.VerbaMunicipal.id, description: this.description, data: this.data, entrada: this.entrada, saida: this.saida, valor: this.valor };

    this.Http.put(`${environment.apibaseURL}api/TabelaVerbaMunicipal/${verbamunicipals.id}`, verbamunicipals)
      .subscribe(
        resultado => {
          console.log(resultado)
          this.getVerbaMunicipal();
        },
        erro => {
          if (erro.status == 400) {
            console.log(erro);
          }
        }
      );
  }
}
