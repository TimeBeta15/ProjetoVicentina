import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { HomeComponent } from './Views/home/home.component';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { MovimentacaoComponent } from './Views/movimentacao/movimentacao.component';
import { ConsultacadastroComponent } from './Views/consultacadastro/consultacadastro.component';
import { ConsultaestoqueComponent } from './Views/consultaestoque/consultaestoque.component';
import { ConsultafinanceiroComponent } from './Views/consultafinanceiro/consultafinanceiro.component';
import { Tabela_verbamunicipalComponent } from './Views/tabela_verbamunicipal/tabela_verbamunicipal.component';
import { Tabela_verbaestadualComponent } from './Views/tabela_verbaestadual/tabela_verbaestadual.component';
import { Tabela_emendaparlamentarComponent } from './Views/tabela_emendaparlamentar/tabela_emendaparlamentar.component';
import { Tabela_emendaimpositivaComponent } from './Views/tabela_emendaimpositiva/tabela_emendaimpositiva.component';
import { Tabela_contacorrenteComponent } from './Views/tabela_contacorrente/tabela_contacorrente.component';
import { Tabela_contacapitalComponent } from './Views/tabela_contacapital/tabela_contacapital.component';
import { Tabela_caixaComponent } from './Views/tabela_caixa/tabela_caixa.component';
import { TabelaQuartosComponent } from './Views/tabela-quartos/tabela-quartos.component';
import { TabelaDoadoresComponent } from './Views/tabela-doadores/tabela-doadores.component';
import { TabelaFornecedoresComponent } from './Views/tabela-fornecedores/tabela-fornecedores.component';
import { TabelaEntradadeprodutoComponent } from './Views/tabela-entradadeproduto/tabela-entradadeproduto.component';
import { TabelaSaidadeprodutoComponent } from './Views/tabela-saidadeproduto/tabela-saidadeproduto.component';
import { HttpClientModule } from '@angular/common/http'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MenuComponent } from './Views/menu/menu.component';
import { LoginComponent } from './Views/login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    EstoqueComponent,
    MovimentacaoComponent,
    ConsultacadastroComponent,
    ConsultaestoqueComponent,
    ConsultafinanceiroComponent,
    Tabela_caixaComponent,
    Tabela_contacapitalComponent,
    Tabela_contacorrenteComponent,
    Tabela_emendaimpositivaComponent,
    Tabela_emendaparlamentarComponent,
    Tabela_verbaestadualComponent,
    Tabela_verbamunicipalComponent,
    TabelaQuartosComponent,
    TabelaDoadoresComponent,
    TabelaFornecedoresComponent,
    TabelaEntradadeprodutoComponent,
    TabelaSaidadeprodutoComponent,
    MenuComponent,
    LoginComponent,



  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
