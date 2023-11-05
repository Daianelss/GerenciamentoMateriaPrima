# Projeto de Gerenciamento de Matéria Prima

## Para rodar localmente é necessário renomear o arquivo **SelfApp.config** para **App.config**


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