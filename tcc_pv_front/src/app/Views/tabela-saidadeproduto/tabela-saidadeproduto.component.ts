import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { SaidaProduto } from 'src/app/models/SaidaProduto';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-tabela-saidadeproduto',
  templateUrl: './tabela-saidadeproduto.component.html',
  styleUrls: ['./tabela-saidadeproduto.component.css']
})
export class TabelaSaidadeprodutoComponent implements OnInit {
  saidaproduto:any;
  data: any;
  desc: any;
SaidaProduto!: SaidaProduto
  constructor(private Http: HttpClient) { }

  ngOnInit(): void{
    this.getSaidaProduto();
  }
  getSaidaProduto()
  {
    this.Http.get('https://localhost:7214/api/SaidaProduto')
    .subscribe(response =>{
      this.saidaproduto = response
    console.log(this.saidaproduto)});
  }
  adicionarSaidaProduto() {
    var saidaproduto = { description :this.desc, data: this.data};


    this.Http.post('https://localhost:7214/api/SaidaProduto', saidaproduto)
              .subscribe(
                resultado => {
                  console.log(resultado)
                  this.getSaidaProduto();
                },
                erro => {
                  if(erro.status == 400) {
                    console.log(erro);
                  }
                }
              );

  }
  excluir(saidaproduto: SaidaProduto,template:any){
    console.log(saidaproduto);
    this.SaidaProduto=saidaproduto;
  }
  excluirSaidaProduto(template:any)
  {
    this.Http.delete(`${environment.apibaseURL}api/SaidaProduto/${this.SaidaProduto.id}`).subscribe
    (() => { this.getSaidaProduto();
    let ref = document.getElementById('cancel')
  ref?.click();},
  erro => {
    if(erro.status == 404){
      console.log('O item não foi localizado');
    }
  }
  );
  }

}
