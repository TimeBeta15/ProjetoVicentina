import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './Views/cadastro/cadastro.component';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { FinanceiroComponent } from './Views/financeiro/financeiro.component';
import { ResidenteComponent } from './Views/residente/residente.component';
import { HomeComponent } from './Views/home/home.component';
import { MovimentacaoComponent } from './Views/movimentacao/movimentacao.component';

const routes: Routes = [{path:'',component: HomeComponent,},
{path:'cadastro',component: CadastroComponent,},
{path:'financeiro',component: FinanceiroComponent,},
{path:'estoque',component: EstoqueComponent,},
{path:'residente',component: ResidenteComponent,},
{path:'movimentacao',component: MovimentacaoComponent},]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
