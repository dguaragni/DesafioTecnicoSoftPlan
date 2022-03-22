import { CalculaJurosComponent } from './components/calcula-juros/calcula-juros.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'calculaJuros', pathMatch: 'full' },
  { path: 'calculaJuros', component: CalculaJurosComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
