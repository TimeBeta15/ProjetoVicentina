
import { LoginComponent } from './Views/login/login.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Views/home/home.component';
import { Tabela_caixaComponent } from './Views/tabela_caixa/tabela_caixa.component';
import { Tabela_verbaestadualComponent } from './Views/tabela_verbaestadual/tabela_verbaestadual.component';
import { Tabela_verbamunicipalComponent } from './Views/tabela_verbamunicipal/tabela_verbamunicipal.component';
import { Tabela_emendaparlamentarComponent } from './Views/tabela_emendaparlamentar/tabela_emendaparlamentar.component';
import { Tabela_emendaimpositivaComponent } from './Views/tabela_emendaimpositiva/tabela_emendaimpositiva.component';
import { Tabela_contacorrenteComponent } from './Views/tabela_contacorrente/tabela_contacorrente.component';
import { Tabela_contacapitalComponent } from './Views/tabela_contacapital/tabela_contacapital.component';
import { TabelaDoadoresComponent } from './Views/tabela-doadores/tabela-doadores.component';
import { TabelaEntradadeprodutoComponent } from './Views/tabela-entradadeproduto/tabela-entradadeproduto.component';
import { TabelaFornecedoresComponent } from './Views/tabela-fornecedores/tabela-fornecedores.component';
import { TabelaQuartosComponent } from './Views/tabela-quartos/tabela-quartos.component';
import { TabelaSaidadeprodutoComponent } from './Views/tabela-saidadeproduto/tabela-saidadeproduto.component';
import { TabelaResidentesComponent } from './Views/tabela-residentes/tabela-residentes.component';
import { CadastroadmComponent } from './Views/cadastroadm/cadastroadm.component';


const routes: Routes = [
  {path:'', component: HomeComponent,},
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
  {path:'tabela_residentes', component: TabelaResidentesComponent},
  {path:'cadastroadm', component: CadastroadmComponent},
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
