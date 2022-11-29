# C# - CRUDFuncionarios

Aplicação console escrita em [**C#**](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) para testes de integração da ferramenta **ORM** [**Entity Framework**](https://www.entityframeworktutorial.net/what-is-entityframework.aspx) com banco de dados [**MySQL online**](https://www.freesqldatabase.com/).

<br>

Dois pacotes foram utilizados na aplicação:
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) (v. 6.0.10)
- [MySql.EntityFrameworkCore](https://www.nuget.org/packages/MySql.EntityFrameworkCore/7.0.0-preview5) (v. 6.0.7)

<br>

## Funcionalidades

A aplicação apresenta ao usuário um menu de opções com acesso a operações **CRUD** (_create_, _read_, _update_, _delete_) para gerenciar uma lista de funcionários.

<br>

<div align='center'>
<img src='./images/App screenshot.png' height=300px>
</div>

<br>

## Rodar a aplicação*

Após baixar todos os arquivos do repositório, instale as dependências rodando o comando abaixo no diretório onde estão os arquivos:

```
dotnet restore
```

Rode a aplicação utilizando o comando:

```
dotnet run
```

<br>

#### *Certifique-se de ter instalado o [.NET Runtime**](https://download.visualstudio.microsoft.com/download/pr/8cf88855-ed09-4002-95db-8bb0f0eff051/f9006645511830bd3b840be132423768/dotnet-runtime-6.0.11-win-x64.exe) (v. 6.0).



#### **Já incluso no [.NET SDK](https://dotnet.microsoft.com/en-us/download).