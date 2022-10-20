import { LoginComponent } from './Views/login/login.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { ResidenteComponent } from './Views/residente/residente.component';
import { HomeComponent } from './Views/home/home.component';
import { MovimentacaoComponent } from './Views/movimentacao/movimentacao.component';
import { Tabela_caixaComponent } from './Views/tabela_caixa/tabela_caixa.component';
import { Tabela_verbaestadualComponent } from './Views/tabela_verbaestadual/tabela_verbaestadual.component';
import { Tabela_verbamunicipalComponent } from './Views/tabela_verbamunicipal/tabela_verbamunicipal.component';
import { Tabela_emendaparlamentarComponent } from './Views/tabela_emendaparlamentar/tabela_emendaparlamentar.component';
import { Tabela_emendaimpositivaComponent } from './Views/tabela_emendaimpositiva/tabela_emendaimpositiva.component';
import { Tabela_contacorrenteComponent } from './Views/tabela_contacorrente/tabela_contacorrente.component';
import { Tabela_contacapitalComponent } from './Views/tabela_contacapital/tabela_contacapital.component';
import { ConsultacadastroComponent } from './Views/consultacadastro/consultacadastro.component';
import { ConsultafinanceiroComponent } from './Views/consultafinanceiro/consultafinanceiro.component';
import { ConsultaestoqueComponent } from './Views/consultaestoque/consultaestoque.component';
import { TabelaDoadoresComponent } from './Views/tabela-doadores/tabela-doadores.component';
import { TabelaEntradadeprodutoComponent } from './Views/tabela-entradadeproduto/tabela-entradadeproduto.component';
import { TabelaFornecedoresComponent } from './Views/tabela-fornecedores/tabela-fornecedores.component';
import { TabelaQuartosComponent } from './Views/tabela-quartos/tabela-quartos.component';
import { TabelaSaidadeprodutoComponent } from './Views/tabela-saidadeproduto/tabela-saidadeproduto.component';


const routes: Routes = [
  {path:'', component: HomeComponent,},
  {path:'estoque' ,component: EstoqueComponent,},
  {path:'residente', component: ResidenteComponent,},
  {path:'movimentacao', component: MovimentacaoComponent},
  {path:'consultacadastro', component: ConsultacadastroComponent},
  {path:'consultafinanceiro', component:ConsultafinanceiroComponent},
  {path:'consultaestoque', component: ConsultaestoqueComponent},
  {path:'tabela_caixa', component: Tabela_caixaComponent},
  {path:'tabela_contacapital', component: Tabela_contacapitalComponent},
  {path:'tabela_contacorrente', component: Tabela_contacorrenteComponent},
  {path:'tabela_emendaimpositiva', component: Tabela_emendaimpositivaComponent},
  {path:'tabela_emendaparlamentar', component: Tabela_emendaparlamentarComponent},
  {path:'tabela_verbaestadual', component: Tabela_verbaestadualComponent},
  {path:'tabela_verbamunicipal', component: Tabela_verbamunicipalComponent},
  {path:'tabela_doadores', component: TabelaDoadoresComponent},
  {path:'tabela_entradadeproduto', component: TabelaEntradadeprodutoComponent},
  {path:'tabela_fornecedores', component: TabelaFornecedoresComponent},
  {path:'tabela_quartos', component: TabelaQuartosComponent},
  {path:'tabela_saidadeproduto', component: TabelaSaidadeprodutoComponent},
  {path:'login', component: LoginComponent},
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
