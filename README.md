# Projeto de Gerenciamento de Mat�ria Prima

# Para rodar o projeto temos duas op��es, MySQL e SQLite(Recomendado)


## Compilando utilizando SQLite

### Para rodar localmente com o SQLite, n�o � necess�rio instalar nenhum SGBD ou rodar scripts, na pasta \Assets do projeto cont�m um banco chamado "banco_gerenciamento.db", copie-o para a pasta principal do .net dentro de \bin para modo "Debug" ou \release para modo "Release"


## Compilando utilizando o MySQL:
### Para rodar localmente utilizando o MySQL � necess�rio renomear o arquivo **SelfApp.config** para **App.config**, tamb�m encontrar� no diret�rio \Assets o arquivo Script.sql para cria��o do Banco de Dados.
### Alterar abaixo os campos de database, user e password de acordo com suas configura��es:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<configSections>
	</configSections>
	<appSettings>
		<add key="Conexao" value="server=localhost;port=3306;database=suaDataBase;user=seuUsuario;password=seuPassword"/>
	</appSettings>
</configuration>
```

### Tamb�m deve ajustar a classe **GerenciamentoMateriaPrimaContext.cs** que se encontra no diret�rio \Context

```CSharp
//Substituir o m�todo abaixo abaixo:

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    var connection = $@"Data Source=banco_gerenciamento.db";
    optionsBuilder
        .UseSqlite(connection)
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
}


//Por:
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    var connection = ConfigurationManager.AppSettings["Conexao"];
    var version = new MySqlServerVersion(new Version(8, 0, 33));
    optionsBuilder
        .UseMySql(connection, version)
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
}
```

## A crit�rio de recria��o do banco do SQLite, existe o script "Script_SQLite.sql" no diret�rio \Assets