# Projeto de Gerenciamento de Matéria Prima

# Para rodar o projeto temos duas opções, MySQL e SQLite(Recomendado)


## Compilando utilizando SQLite

### Para rodar localmente com o SQLite, não é necessário instalar nenhum SGBD ou rodar scripts, na pasta \Assets do projeto contém um banco chamado "banco_gerenciamento.db", copie-o para a pasta principal do .net dentro de \bin para modo "Debug" ou \release para modo "Release"


## Compilando utilizando o MySQL:
### Para rodar localmente utilizando o MySQL é necessário renomear o arquivo **SelfApp.config** para **App.config**, também encontrará no diretório \Assets o arquivo Script.sql para criação do Banco de Dados.
### Alterar abaixo os campos de database, user e password de acordo com suas configurações:

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

### Também deve ajustar a classe **GerenciamentoMateriaPrimaContext.cs** que se encontra no diretório \Context

```CSharp
//Substituir o método abaixo abaixo:

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

## A critério de recriação do banco do SQLite, existe o script "Script_SQLite.sql" no diretório \Assets