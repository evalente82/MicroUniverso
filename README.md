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
3. IMAGENS DO SISTEMA
  - TELA DE LOGIN
    
![image](https://github.com/evalente82/MicroUniverso/assets/54483167/b62a0f65-396b-4eb8-be0c-7eed2887043d)

   - CLIQUE EM CADASTRAR PARA VISUALIZAR A TELA DE CADASTRO E OS USUARIOS CADASTRADOS E SUAS SENHAS PARA TESTES

![image](https://github.com/evalente82/MicroUniverso/assets/54483167/3bddaf8c-f830-4181-a496-720b9c804720)

   - APOS LOGAR VOCÊ TERÁ ACESSO AO MENU DA APLICAÇÃO
![image](https://github.com/evalente82/MicroUniverso/assets/54483167/b371773f-e9bb-4526-9a7f-844a415c8190)

   - MENU DE NOTAS

![image](https://github.com/evalente82/MicroUniverso/assets/54483167/f04d6266-0ab9-4ed1-a4ef-b67337db5f1e)

   - MENU DE HISTÓRICO DE APROVAÇÃO

![image](https://github.com/evalente82/MicroUniverso/assets/54483167/e6f32dea-aff5-49b9-8bb1-619b19b6cea8)

   - MENU CONFIGURAÇÃO DE FAIXAS

![image](https://github.com/evalente82/MicroUniverso/assets/54483167/80329547-a5b2-4adc-adf5-91f44b3de41b)


   - Fim.

