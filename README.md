# Projeto de Integração com Gemini (Google) para Gerenciamento de Agenda de Tarefas

## Descrição do Projeto
Este projeto é uma API desenvolvida em **C# .NET**, projetada para facilitar o gerenciamento de agendas de tarefas. A API utiliza a IA **Gemini da Google** para gerar conteúdos e fornecer insights avançados, aumentando a eficiência no planejamento e organização de tarefas.

## Funcionalidades

### **1. Endpoints Disponíveis**

#### **Integração com Gemini**
- **POST** `/api/agenda`
  - Organiza a agenda com base nos dados fornecidos.

- **POST** `/api/agenda/busca`
  - Realiza buscas específicas na agenda utilizando IA Gemini.

### **2. Integração com Gemini**
A API está integrada à **IA Gemini**, da Google, por meio do seguinte endpoint configurado no arquivo `appsettings.json`:

```json
"Gemini": {
  "ApiUrl": "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=",
  "ApiKey": "<GEMINI_API_KEY>"
}
```

Esta configuração permite enviar requisições para geração de conteúdo relacionado à organização e busca na agenda.

## Pré-requisitos
- **.NET**: Versão 8.0 ou superior.
- **Chave da API Gemini**: É necessário configurar a chave da API no arquivo `appsettings.json`.

## Configuração e Execução

1. **Clone o Repositório**
   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd <NOME_DO_PROJETO>
   ```

2. **Configure as Dependências**
   - Edite o arquivo `appsettings.json` para adicionar a chave da API Gemini:
     ```json
     "Gemini": {
       "ApiUrl": "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=",
       "ApiKey": "<SUA_CHAVE_API>"
     }
     ```

3. **Execute a API**
   - Utilize o comando:
     ```bash
     dotnet run
     ```

## Estrutura do Projeto
- **Controllers**: Contém os controladores responsáveis por gerenciar as rotas e lógica de endpoints da API.
- **Dtos**: Define os Data Transfer Objects usados para transportar dados entre camadas.
- **Services**: Contém as regras de negócio e serviços utilizados pelos controladores.
- **appsettings.json**: Configurações gerais da aplicação, incluindo a integração com a API Gemini.

## Tecnologias Utilizadas
- **C# .NET**
- **Gemini (Google)**

