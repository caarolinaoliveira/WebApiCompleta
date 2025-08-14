
# 📦 Estrutura Inicial da Solution `APICompleta`

## 1. Criar a solution em branco

```bash
dotnet new sln -n APICompleta
```
## 2. Crie a seguinte estrutura de pastas 

APICompleta/  
│    
├── src/          # Contém todos os projetos da aplicação  
│   ├── DevIO.Api         # Projeto principal da API  
│   ├── DevIO.Business    # Regras de negócio e entidades  
│   └── DevIO.Data        # Acesso a dados  
│  
├── tests/       # Projetos de testes  
├── sql/         # Scripts e arquivos de banco de dados  
  
## 3. Crie os projetos dentro da pasta src
```bash
cd src
dotnet new webapi -n DevIO.Api --use-controllers
``` 
## 4. Incluir referências entre os projetos
API depende de business

```bash
dotnet add DevIO.Api/DevIo.Api.csproj reference DevIo.Business/DevIo.Business.csproj
```
API depende de Data

```bash
dotnet add DevIO.Api/DevIo.Api.csproj reference DevIo.Data/DevIo.Data.csproj 
```
No visual studio isso é possível fazer pela interface, no VsCode precisa ser pelo terminal.

Resultado no arquivo .csproj da API

```bash 
  <ItemGroup>
    <ProjectReference Include="..\DevIo.Business\DevIo.Business.csproj" />
    <ProjectReference Include="..\DevIo.Data\DevIo.Data.csproj" />
  </ItemGroup>
```
