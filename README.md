# TesteMicroUniverso

## Instalação

1. Primeiro, certifique-se de ter os requisitos abaixo instalados:

   - Requisito 1
   - Docker para rodar o BD SQLServer 2022
   - baixar imagem sql server
   - docker pull mcr.microsoft.com/mssql/server:2022-latest
   - crie um arquivo como : docker-compose.yaml
   - version: "1.0"
   - services:
   - sql-server-db:
   - container_name: sql-server-db
   - image: mcr.microsoft.com/mssql/server:2022-latest
   - ports:
   - "1433:1433"
   - environment:
   - SA_PASSWORD: "seuPASSWORD"
   - ACCEPT_EULA: "Y"
- no terminal rode:
- docker-compose up -d

- configurando sql server:
- localhost
- usuario:sa
- senha:seuPASSWORD

1.1 No arquivo: App.Config
- Altere a connectionString
- connectionString="Server=localhost;Database=MicroUniverso;User ID=sa;Password=seuPASSWORD"/>
   - Requisito 2
   - Visual Studio
2. Após baixar os fontes realize as migrações para o Bd ficar na mesma versão.
   - Add-Migration NomeDaMigracao
   - Update-Database
