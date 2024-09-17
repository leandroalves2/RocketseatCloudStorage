# Rocketseat Cloud Storage

## Descrição

O **Rocketseat Cloud Storage** é uma aplicação ASP.NET Core criada no evento de 2024 pela Rocketseat, que integra com o Google Drive para permitir o upload de arquivos de perfil. A aplicação inclui um serviço de armazenamento baseado no Google Drive e uma API para gerenciamento de usuários e uploads de fotos de perfil.

## Estrutura do Projeto

- **`RocketseatCloudStorage.Application`**: Contém os casos de uso e serviços de aplicação.
- **`RocketseatCloudStorage.Domain`**: Define entidades e interfaces de armazenamento.
- **`RocketseatCloudStorage.Infrastructure`**: Implementações específicas de armazenamento, como o Google Drive.
- **`RocketseatCloudStorage`**: Contém controladores e configurações principais da API.

## Funcionalidades

- **Upload de Arquivos**: Permite que os usuários façam upload de arquivos para o Google Drive através da API.
- **Previsão do Tempo**: Um exemplo de controlador que retorna previsões do tempo.
- **Gerenciamento de Usuários**: Inclui a lógica para o gerenciamento de usuários e autenticação.

## Configuração

### Google Drive API

Para utilizar a integração com o Google Drive, você deve configurar as credenciais de OAuth 2.0:

1. Acesse o [Console de APIs do Google](https://console.developers.google.com/).
2. Crie um novo projeto ou selecione um existente.
3. Habilite a API do Google Drive.
4. Configure as credenciais de OAuth 2.0 e obtenha o `ClientId` e `ClientSecret`.
5. Atualize o arquivo `appsettings.json` com suas credenciais:

   ```json
   {
     "CloudStorage": {
       "ClientId": "<YOUR_CLIENT_ID>",
       "ClientSecret": "<YOUR_CLIENT_SECRET>"
     }
   }
