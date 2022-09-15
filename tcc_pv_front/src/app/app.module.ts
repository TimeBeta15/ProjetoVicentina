import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Views/home/home.component';
import { CadastroComponent } from './Views/cadastro/cadastro.component';
import { EstoqueComponent } from './Views/estoque/estoque.component';
import { FinanceiroComponent } from './Views/financeiro/financeiro.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CadastroComponent,
    EstoqueComponent,
    FinanceiroComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
