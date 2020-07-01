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

- [Asp.net](https://github.com/Microsoft/TypeScript)
- [C#](https://github.com/expressjs/express)
- [entityFramework](https://github.com/facebook/react)

- [SqlServer](https://github.com/PaulLeCam/react-leaflet)


## :hammer: Tools
- [Visual Studio](https://github.com/facebook/react-native)


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

<h2>O projeto conta com 5 Endpoints</h2>

<h3>[Get] /poll/:id </h3>
<pre>Retonar os dados de uma enquete e incrementa "Views" com uma requisição. </pre>

<h3>[Post] /poll </h3>
<pre>Cria uma nova enquete</pre>

<h3>[Post] /poll/:id/vote </h3>
<pre>Registra um novo voto para uma opção.</pre>

<h3>[Get] /poll/:id/stats </h3>
<pre>Retornar estatísticas sobre a enquete e adiciona mais uma requisição </pre>

