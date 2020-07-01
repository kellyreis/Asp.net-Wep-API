<p align="center">

  <a href="https://github.com/kellyreis/" target="_blank" >
    <img alt="Github - Kelly Reis" src="https://img.shields.io/badge/Github--%23F8952D?style=social&logo=github">
  </a>
  <a href="https://www.linkedin.com/in/keellyreis/" target="_blank" >
    <img alt="Linkedin - Kelly Reis" src="https://img.shields.io/badge/Linkedin--%23F8952D?style=social&logo=linkedin">
  </a>
  <a href="mailto:kelly.fernanda.reis94@gmail.com" target="_blank" >
    <img alt="Email - Kelly Reis" src="https://img.shields.io/badge/Email--%23F8952D?style=social&logo=gmail">
  </a>
  <a href="https://api.whatsapp.com/send?phone=5519999374847" target="_blank" >
    <img alt="Fale comigo no whatsapp - Kelly Reis" src="https://img.shields.io/badge/Whatsapp--%23F8952D?style=social&logo=whatsapp">
  </a>
</p>

<p align="center">
 <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#rocket-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-layout">Informações para Instalação do Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-license">License</a>
</p>

## 💻 Project
**Asp.net-Wep-API** API RESTful para a utilização de uma enquete.

## :rocket: Technologies
Este projeto foi desenvolvido com as seguintes tecnologias:

- [Asp.net](https://github.com/search?q=org%3Amicrosoft+asp.net&unscoped_q=asp.net)
- [C#](https://github.com/search?l=C%23&q=c%23&type=Repositories)
- [entityFramework](https://github.com/search?q=entityFramework&type=Repositories)
- [SqlServer](https://github.com/search?q=SqlServer&type=Repositories)


## :hammer: Tools
- [Visual Studio](https://github.com/github/VisualStudio)


## 🔖 Informações para Instalação do Projeto

<h2>Instalação do Banco de dados</h3>
<p>O banco de dados utilizado e configurado para automatização das tabelas utilizando entityFramework foi o SqlServer. </p>
<p>Dentro de Web.config adicione as informações do seu banco de dados dentro de "connectionString", faça isso antes de rodar a aplicação.
  </p>
  <pre> connectionString='Server={host};Database={databasename};User ID={login};Password={senha};'
</pre>

<p>
pronto! Depois desta configuração as tabelas serão criadas automaticamente pelo entityFramework.
Uma observação, não modifique o "name" da "connectionString" ele esta padrão, está sendo referenciado para automatização do banco de dados.
Com as tabelas criadas, você pode fazer as consultas dos endpoints citados.
</p>

<h2>Endpoints</h2>

<h3>[Get] /poll/:id </h3>
<pre>Retonar os dados de uma enquete e incrementa "Views" com uma requisição. </pre>

![get-pol](https://user-images.githubusercontent.com/25619397/86200394-e7352480-bb32-11ea-8db0-0d4ad53dc856.png)

<h3>[Post] /poll </h3>
<pre>Cria uma nova enquete</pre>

![add](https://user-images.githubusercontent.com/25619397/86200391-e603f780-bb32-11ea-8258-90acc40bf38e.png)

<h3>[Post] /poll/:id/vote </h3>
<pre>Registra um novo voto para uma opção.</pre>

![update](https://user-images.githubusercontent.com/25619397/86200397-e7cdbb00-bb32-11ea-90a9-cd31eb3b4b93.png)

<h3>[Get] /poll/:id/stats </h3>
<pre>Retornar estatísticas sobre a enquete e adiciona mais uma requisição </pre>

![states](https://user-images.githubusercontent.com/25619397/86200396-e7352480-bb32-11ea-8b23-1438dcf49369.png)



