import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './Views/cadastro/cadastro.component';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { FinanceiroComponent } from './Views/financeiro/financeiro.component';
import { ResidenteComponent } from './Views/residente/residente.component';
import { ModaltesteComponent } from './Views/modalteste/modalteste.component';
import { HomeComponent } from './Views/home/home.component';

const routes: Routes = [{path:'',component: HomeComponent,},
{path:'cadastro',component: CadastroComponent,},
{path:'financeiro',component: FinanceiroComponent,},
{path:'estoque',component: EstoqueComponent,},
{path:'modalteste',component: ModaltesteComponent,},
{path:'residente',component: ResidenteComponent,},]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
