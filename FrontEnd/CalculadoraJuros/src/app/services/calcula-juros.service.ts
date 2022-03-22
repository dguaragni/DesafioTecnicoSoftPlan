import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment as ENV } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { TaxaJuros } from '../models/taxaJuros.model';
import { CalculaJuros } from '../models/calculaJuros.model';

@Injectable({
  providedIn: 'root',
})
export class CalculaJurosService {
  constructor(private http: HttpClient) {}

  obtemTaxaJuros(): Observable<TaxaJuros> {
    let url = ENV.urlApiTaxaJuros;
    return this.http.get<TaxaJuros>(url).pipe();
  }

  calculaJuros(valor: number, meses: number): Observable<CalculaJuros> {
    const params: URLSearchParams = new URLSearchParams();
    let url = ENV.urlApiCalculaJuros;
    params.set('valor', valor.toString());
    params.set('meses', meses.toString());
    url += '?' + params.toString();
    return this.http.get<CalculaJuros>(url).pipe();
  }
}
