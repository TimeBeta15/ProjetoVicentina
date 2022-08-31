import { CadastroComponent } from './Views/cadastro/cadastro.component';
import { HomeComponent } from './Views/home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FinanceiroComponent } from './Views/financeiro/financeiro.component';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { DoacoesComponent } from './Views/doacoes/doacoes.component';
import { VisitasComponent } from './Views/visitas/visitas.component';

const routes: Routes = [ 
  {path:'',component: HomeComponent,},
  {path:'cadastro',component: CadastroComponent,},
  {path:'financeiro',component: FinanceiroComponent,},
  {path:'estoque',component: EstoqueComponent,},
  {path:'doacoes',component: DoacoesComponent,},
  {path:'visitas',component: VisitasComponent,},];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
