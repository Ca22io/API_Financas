<h1><bold>Api_Finanças</bold></h1>

<p>
  Essa api simples foi criada apenas para fins de de estudo e prática, procurando maior aprofundamento de código com Asp.Net Core com suas tecnologias e aplicação de um código limpo utilizando os principios SOLID.<br>
  Acredito que ainda tenha muitos ajustes que possam ser relaizados, eu mesmo já localizei alguns e vou atras de fazer as correções.
</p>
<p>
  Caso localize pontos de melhorias e correções vou ficar contente em ouvir seu feedback, pode entrar em contato comigo atraves de:<br>
  <a href="https://www.linkedin.com/in/cassio-bindaco" target="_blank" rel="noopener noreferrer">Linkedin</a> <br>
  <a href="mailto:bindaco77@gmail.com?subject=FeedBack%20de%20OAPI_Finanças" target="_blank" rel="noopener noreferrer">Email</a>



<h2>Rotas do projeto</h2>

<h4>Rotas do CRUD para categorias:</h4>

<img width="1838" height="363" alt="Rotas_API_Financas_Categoria" src="https://github.com/user-attachments/assets/e6b2f303-8695-45e4-9078-8291068e423a" />
<br>

  ⬇️**GET** -- Essa rota permite obter todas as nossas categorias, com uma consulta completas com suas informações.
  
  📤**POST** -- Essa rota permite incluir uma categoria que ainda não tinha sido cadastrada.
  
  ✏️**PUT** -- Essa rota permite fazer a atualização de uma categora. Ex: Corrigir um nome errado.
  
  🗑️**DELETE** -- Essa rota permite excluir uma categoria.
<hr>

<h4>Rotas do CRUD para transações:</h4>
<img width="1838" height="358" alt="Rotas_API_Financas_Transacao" src="https://github.com/user-attachments/assets/fb55e610-83ec-4788-8cc2-f3e80e34d8d5" />

- GET -- Essa rota permite obter todas as transações ou transações de um certo período enviando a data de inicio e fim atraves de query, sempre será retornado as informações
da taransação junto com o nome do tipo e catgeoria vinculada a ela.
  
- POST -- Essa rota permite incluir uma transação, nela é preciso passar as informações de uma transação, incluindo os ids de tipo e categoria que devem ser vinculados.
  
- PUT -- Essa rota permite fazer a atualização de uma transação, sendo possivel alterar apenas a descrição e valor.
  
- DELETE -- Essa rota permite excluir uma transação.

<br>

⚠️**OBS:** O tipo da transação não possui rota pois é predefinico com apenas dois tipos, sendo eles: RECEITA e DESPESA

<hr>

<h3>Como rodar o projeto</h3>

- Copiando repositorio:<br>
  <code>git clone https://github.com/Ca22io/API_Financas</code>
  <br>
- Dependecia:<br>
  Possuir o sdk da versão do .NET 8.0
  <br>
- Rodando o projeto dentro da pasta do mesmo:<br>
  <code>dotnet run</code> ou <code>dotnet build</code>
