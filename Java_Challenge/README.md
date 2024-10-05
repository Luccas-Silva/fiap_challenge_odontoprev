# Java Advanced - Challenge Odontoprev 

## Sumário
- [Objetivo do Projeto](#objetivo-do-projeto)
- [Diagrama de Classes](#diagrama-de-classes)
- [Diagrama de Relacionamento (DER)](#diagrama-de-relacionamento-der)
- [Instrução para rodar a aplicação](#instrução-para-rodar-a-aplicação)
- [Listagem de endpoints (Doc API)](#listagem-de-endpoints-doc-api)
- [Documento de teste via Postman](#documento-de-teste-via-postman)
- [Link Vídeo da Proposta Tecnológica](#link-vídeo-da-proposta-tecnológica)


## Objetivo do Projeto

## Diagrama de Classes

![image](https://github.com/user-attachments/assets/70214640-5bd9-4056-a6d6-d4c07aa3b323)
![image](https://github.com/user-attachments/assets/8421a791-35ee-4ac0-94d9-7028f6d465b8)
![image](https://github.com/user-attachments/assets/61baaca9-4520-47ed-9ca1-d0eac9eb528f)
![image](https://github.com/user-attachments/assets/acd40a19-3abc-4bbc-a71f-bd2d78b259a0)

## Diagrama de Relacionamento (DER)

## Instrução para rodar a aplicação

Para configurar sua aplicação, acesse o arquivo `application.properties`. Neste arquivo, você encontrará propriedades que permitem personalizar o comportamento da sua aplicação.
Para conectar ao banco de dados, localize as propriedades username password. Nestas propriedades, insira respectivamente o nome de usuário e a senha para acessar o seu banco de dados. 

### Exemplo:
```
{
  datasource:
  url: jdbc:oracle:thin:@oracle.fiap.com.br:1521:orcl
  username: usuario
  password: senha
  driver-class-name: oracle.jdbc.OracleDriver
  jpa:
  hibernate:
  ddl-auto: create
  database-platform: org.hibernate.dialect.OracleDialect
}
```
Após realizar as alterações, salve o arquivo e execute a aplicação. A aplicação utilizará as novas credenciais para se conectar ao banco de dados.

## Listagem de endpoints (Doc API)

## Link Vídeo da Proposta Tecnológica

## Documento de teste via Postman    
