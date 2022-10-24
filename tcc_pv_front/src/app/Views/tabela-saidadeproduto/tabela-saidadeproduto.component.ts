import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { SaidaProduto } from 'src/app/models/SaidaProduto';
@Component({
  selector: 'app-tabela-saidadeproduto',
  templateUrl: './tabela-saidadeproduto.component.html',
  styleUrls: ['./tabela-saidadeproduto.component.css']
})
export class TabelaSaidadeprodutoComponent implements OnInit {
  data: any;
  desc: any;
  constructor(private http: HttpClient) { }

  ngOnInit(){this.getSaidaProduto();
  }
  getSaidaProduto()
  {
    
  }

}
