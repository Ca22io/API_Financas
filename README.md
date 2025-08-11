
<img width="1100" height="200" alt="Gemini_Generated_Image_uhjd1iuhjd1iuhjd-cortada" src="https://github.com/user-attachments/assets/e8b40f27-3aad-422d-920c-55b2b02f375f" />


<p align="center">
<img loading="lazy" src="http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO%20&color=GREEN&style=for-the-badge"/>
</p>
<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-green"/>
  <img src="https://img.shields.io/badge/ASP.NET-Framework-blue"/>
  <img src="https://img.shields.io/badge/Entity-Framework-blue"/>
  <img src="https://img.shields.io/badge/SqLite-SQL-blue"/>
</p>

<h2>Descrição do projeto</h2>

<p align="justify">
  Esta API simples foi criada apenas para fins de estudo e prática, buscando o aprofundamento em desenvolvimento com <b>ASP.NET Core</b>, suas tecnologias e a aplicação de código limpo utilizando os princípios <b>SOLID</b>.

  Acredito que ainda existam muitos ajustes que possam ser realizados. Eu mesmo já identifiquei alguns e trabalharei para corrigi-los.
</p>

> Caso identifique pontos de melhoria ou correções, ficarei contente em receber seu feedback. Você pode entrar em contato comigo por:<br>
  <a href="https://www.linkedin.com/in/cassio-bindaco" target="_blank" rel="noopener noreferrer"><img src="https://img.shields.io/badge/Linkedin-blue"/></a>
  <a href="mailto:bindaco77@gmail.com?subject=FeedBack%20de%20OAPI_Finanças" target="_blank" rel="noopener noreferrer"><img src="https://img.shields.io/badge/Gmail-red"/></a>

<h2>Rotas do projeto</h2>

<h3>CRUD para categorias:</h3>

<img width="1838" height="363" alt="Rotas_API_Financas_Categoria" src="https://github.com/user-attachments/assets/e6b2f303-8695-45e4-9078-8291068e423a" />

⬇️**GET** -- Essa rota permite obter todas as nossas categorias, com uma consulta completas com suas informações.

📤**POST** -- Essa rota permite incluir uma categoria que ainda não tinha sido cadastrada.

✏️**PUT** -- Essa rota permite fazer a atualização de uma categoria. Ex: Corrigir um nome errado.

🗑️**DELETE** -- Essa rota permite excluir uma categoria.

> ⚠️**OBS:** Como se trata de um crud bem simples não foi aplicado nenhuma lógica especifica.
  
<hr>

<h3>CRUD para transações:</h3>
<img width="1838" height="358" alt="Rotas_API_Financas_Transacao" src="https://github.com/user-attachments/assets/fb55e610-83ec-4788-8cc2-f3e80e34d8d5" />

⬇️**GET:** ssa rota permite obter todas as transações ou transações de um certo período enviando a data de início e fim via query, sempre será retornado as informações
da transação com o nome do tipo e categoria vinculada a ela.

📤**POST:** Essa rota permite incluir uma transação, nela é precisa passar as informações de uma transação, incluindo os ids de tipo e categoria que devem ser vinculados.

✏️**PUT:** Essa rota permite fazer a atualização de uma transação, sendo possível alterar apenas a descrição e valor.

🗑️**DELETE:** Essa rota permite excluir uma transação.

> ⚠️**OBS:** O tipo da transação não possui rota, pois é predefinido com apenas dois tipos, sendo eles: RECEITA e DESPESA

<h2>Como rodar o projeto</h2>

- Copiando repositório:
  <code>git clone https://github.com/Ca22io/API_Financas</code>
  
- Rodando o projeto dentro da pasta do mesmo:
  <code>dotnet run</code> ou <code>dotnet build</code>

<h2>🆕 Versão 2.0</h2>
<p align="justify">
  A versão 2.0 do projeto foi desenvolvida com o objetivo de aprimorar a estrutura e a organização do código, seguindo os princípios do Clean Code e SOLID. Nesta versão, foram implementadas as seguintes melhorias:
  <ul>
    <li>Refatoração do código para melhorar a legibilidade e a manutenção.</li>
    <li>Implementação de testes unitários para garantir a qualidade do código.</li>
    <li>Adição da camada de serviços no projeto.</li>
    <li>Adição do mapeamento de objetos com AutoMapper.</li>
  </ul>
  Essas melhorias visam tornar o projeto mais robusto e fácil de entender, facilitando futuras manutenções e expansões.
  A versão 1.0 serviu como base para o desenvolvimento, onde foram implementadas melhorias significativas na estrutura e organização do código.
</p>

<h2>Versão 1.0</h2>
<p align="justify">
  A versão 1.0 do projeto foi desenvolvida com o objetivo de criar uma API simples para gerenciar categorias e transações financeiras. Nesta versão, foram implementadas as seguintes funcionalidades:
  <ul>
    <li>CRUD completo para categorias.</li>
    <li>CRUD completo para transações.</li>
    <li>Validações básicas de entrada de dados.</li>
    <li>Documentação da API utilizando Swagger.</li>
  </ul>
</p>
