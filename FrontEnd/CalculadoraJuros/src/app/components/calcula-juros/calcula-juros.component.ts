import { CalculaJuros } from './../../models/calculaJuros.model';
import { CalculaJurosService } from './../../services/calcula-juros.service';
import { Component, OnInit } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-calcula-juros',
  templateUrl: './calcula-juros.component.html',
  styleUrls: ['./calcula-juros.component.css'],
})
export class CalculaJurosComponent implements OnInit {
  taxaJuros = 0;
  valorInicial = 0;
  qtdMeses = 0;
  valorFinalCalculado = 0;

  constructor(private calculaJurosService: CalculaJurosService) {}

  ngOnInit(): void {
    this.obtemTaxaJuros();
  }

  obtemTaxaJuros() {
    this.calculaJurosService.obtemTaxaJuros().subscribe({
      next: (taxa) => (this.taxaJuros = taxa.taxaJuros),
      error: (e) => {
        alert(
          'Falha ao consultar a taxa de juros. Verifique as conexões de rede ou tente novamente mais tarde.'
        );
      },
    });
  }

  calcularJuros() {
    this.calculaJurosService
      .calculaJuros(this.valorInicial, this.qtdMeses)
      .subscribe({
        next: (valor) => (this.valorFinalCalculado = valor.valorFinal),
        error: (e: HttpErrorResponse) => {
          debugger;
          console.log(e.message);
          alert(
            'Falha ao realizar o calculo do valor final com juros. Verifique as conexões de rede ou tente novamente mais tarde.'
          );
        },
      });
  }
}
