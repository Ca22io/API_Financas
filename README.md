<h1 align="center"><b>Api_Finanças</b></h1>

<p align="center">
<img loading="lazy" src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge"/>
</p>
<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-green"/>
  <img src="https://img.shields.io/badge/ASP.NET-Framework-blue"/>
  <img src="https://img.shields.io/badge/Entity-Framework-blue"/>
  <img src="https://img.shields.io/badge/SqLite-SQL-blue"/>
</p>

<h2>Descrição do projeto</h2>

 Esta API simples foi criada apenas para fins de estudo e prática, buscando o aprofundamento em desenvolvimento com **ASP.NET Core**, suas tecnologias e a aplicação de código limpo utilizando os princípios **SOLID**.

 Acredito que ainda existam muitos ajustes que possam ser realizados. Eu mesmo já identifiquei alguns e trabalharei para corrigi-los.

> Caso identifique pontos de melhoria ou correções, ficarei contente em receber seu feedback. Você pode entrar em contato comigo por:<br>
  <a href="https://www.linkedin.com/in/cassio-bindaco" target="_blank" rel="noopener noreferrer">Linkedin</a> <br>
  <a href="mailto:bindaco77@gmail.com?subject=FeedBack%20de%20OAPI_Finanças" target="_blank" rel="noopener noreferrer">E-mail</a>

<h2>Rotas do projeto</h2>

<h4>CRUD para categorias:</h4>

<img width="1838" height="363" alt="Rotas_API_Financas_Categoria" src="https://github.com/user-attachments/assets/e6b2f303-8695-45e4-9078-8291068e423a" />

  ⬇️**GET** -- Essa rota permite obter todas as nossas categorias, com uma consulta completas com suas informações.

  📤**POST** -- Essa rota permite incluir uma categoria que ainda não tinha sido cadastrada.

  ✏️**PUT** -- Essa rota permite fazer a atualização de uma categoria. Ex: Corrigir um nome errado.

  🗑️**DELETE** -- Essa rota permite excluir uma categoria.

  ⚠️**OBS:** Como se trata de um crud bem simples não foi aplicado nenhuma lógica especifica.
  
<hr>

<h4>CRUD para transações:</h4>
<img width="1838" height="358" alt="Rotas_API_Financas_Transacao" src="https://github.com/user-attachments/assets/fb55e610-83ec-4788-8cc2-f3e80e34d8d5" />

⬇️**GET:** ssa rota permite obter todas as transações ou transações de um certo período enviando a data de início e fim via query, sempre será retornado as informações
da transação com o nome do tipo e categoria vinculada a ela.

📤**POST:** Essa rota permite incluir uma transação, nela é precisa passar as informações de uma transação, incluindo os ids de tipo e categoria que devem ser vinculados.

✏️**PUT:** Essa rota permite fazer a atualização de uma transação, sendo possível alterar apenas a descrição e valor.

🗑️**DELETE:** Essa rota permite excluir uma transação.

⚠️**OBS:** O tipo da transação não possui rota, pois é predefinido com apenas dois tipos, sendo eles: RECEITA e DESPESA

<hr>

<h3>Como rodar o projeto</h3>

- Copiando repositório:
  <code>git clone https://github.com/Ca22io/API_Financas</code>
  
- Dependência:
  Possuir o sdk da versão do .NET 8.0 instalado
  
- Rodando o projeto dentro da pasta do mesmo:
  <code>dotnet run</code> ou <code>dotnet build</code>
