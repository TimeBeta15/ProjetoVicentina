import { CadastroComponent } from './Views/cadastro/cadastro.component';
import { HomeComponent } from './Views/home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [ {path:'',component: HomeComponent,},{path:'cadastro',component: CadastroComponent,}];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
