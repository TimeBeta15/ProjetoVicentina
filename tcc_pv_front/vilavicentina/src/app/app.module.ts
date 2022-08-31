import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Views/home/home.component';
import { CadastroComponent } from './Views/cadastro/cadastro.component';
import { FinanceiroComponent } from './Views/financeiro/financeiro.component';
import { VisitasComponent } from './Views/visitas/visitas.component';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { DoacoesComponent } from './Views/doacoes/doacoes.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CadastroComponent,
    FinanceiroComponent,
    VisitasComponent,
    EstoqueComponent,
    DoacoesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
