import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Doadores } from 'src/app/models/doadores';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-tabela-doadores',
  templateUrl: './tabela-doadores.component.html',
  styleUrls: ['./tabela-doadores.component.css']
})
export class TabelaDoadoresComponent implements OnInit {
doadores: any
Doador!:Doadores
data: any
formapagamento: any
valor!: number
telefone: any
nome: any

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getDoadores

  }
getDoadores()
{
  this.http.get('https://localhost:7214/api/TabelaDoador')
  .subscribe(response =>{
    this.doadores = response
  console.log(this.doadores)});
}
adicionarDoador()
{
var doadores
}
}
