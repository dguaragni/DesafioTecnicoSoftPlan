# DesafioTecnicoSoftPlan
Desafio Técnico da Softplan 

**A solução para o desafio é composta pelos seguintes projetos:**
- Web Api Asp.Net Core .Net 6 responsável por retornar a taxa de juros.
- Web Api Asp.Net Core .Net 6 responsável por realizar o cálculo do Valor Final com a taxa de juros.
- Projeto xUnit com testes unitários das duas APIs.
- Projeto em Angular para realizar o teste de integração com a API.


**Requisitos para executar a solução**
- Visual Studio 2019 ou 2020 atualizados
- NodeJs (Projeto Angular de teste de Integração)


**Para executar a API em .Net Core que retorna a taxa de juros (API 1) devem ser realizados os seguintes passos:**
1) Abrir e Executar o projeto "\BackEnd\DesafioTecnicoSoftPlan\Apresentacao\DesafioSoftplan.Api1\DesafioSoftplan.Api1.csproj"
2) O EndPoint TaxaJuros estará disponível no endereço https://localhost:7166/taxaJuros
3) O mesmo retorna um json com a seguinte estrutura: 
	{"taxaJuros":0.00}


**Para executar a API em .Net Core que calcula os juros (API 2) devem ser realizados os seguintes passos:**
1) Abrir e Executar o projeto "\BackEnd\DesafioTecnicoSoftPlan\Apresentacao\DesafioSoftplan.Api2\DesafioSoftplan.Api2.csproj"
2) O EndPoint CalculaJuros estará disponível no endereço https://localhost:7175/calculaJuros
3) O Endpoint recebe os parâmetros "valorInicial" e "meses" via QueryString
4) O mesmo retorna um json com a seguinte estrutura: 
	{"valorFinal":0.00}

OBS: Caso seja necessário alterar a porta em que a API1 irá rodar, será necessário alterar a propriedade UrlApiTaxaJuros no arquivo "appsettings.json" do diretório "\BackEnd\DesafioTecnicoSoftPlan\Apresentacao\DesafioSoftplan.Api2" 


**Para executar os testes unitários do projeto:**
1) Abrir a solution \BackEnd\DesafioTecnicoSoftPlan\DesafioTecnicoSoftPlan.sln
2) Recompilar a solução
3) Abrir a janela Test Explorer no Visual Studio
4) Executar os testes unitários clicando na opção "Run All Tests in View"


**Para executar o projeto FrontEnd utilizado para realizar os testes de integração devem ser realizados os seguintes passos:**
1) Após instalado o NodeJs
2) Executar o Terminal de sua preferência, acessar o diretório 
3) Executar o comando "npm install -g @angular/cli"
4) Executar o comando "ng serve"
5) No endereço dagdjashdjhasdj estará disponível uma página que realiza o acesso ás APIs que devem estar executando no localhost.
OBS: Caso seja necessário alterar a porta em que a API1 e a API2 estarão disponíveis, será necessário alterar a propriedade UrlApiTaxaJuros no arquivo "appsettings.json" do diretório.
