# Java Advanced - Challenge Odontoprev 


## Sumário
- [Objetivo do Projeto](#projeto-fairytooth-plataforma-de-gestão-da-saúde-bucal-personalizada)
- [Diagrama de Classes](#diagrama-de-classes)
- [Diagrama de Relacionamento (DER)](#diagrama-de-relacionamento-der)
- [Instrução para rodar a aplicação](#instrução-para-rodar-a-aplicação)
- [Listagem de endpoints (Doc API)](#listagem-de-endpoints-doc-api)

##	Projeto FairyTooth: Plataforma de Gestão da Saúde Bucal Personalizada
A proposta é desenvolver uma plataforma digital que centralize as informações dos pacientes, integrando dados clínicos, históricos de tratamentos, hábitos de vida e respostas a questionários de saúde bucal. Essa plataforma funcionaria como um verdadeiro "assistente pessoal" para a saúde bucal, oferecendo:
-	Análise preditiva: Através de algoritmos de machine learning, a plataforma identificaria padrões de comportamento que indicam um maior risco de sinistros, como pacientes que solicitam tratamentos desnecessários ou que apresentam alta rotatividade de dentistas.
-	Recomendações personalizadas: Com base na análise dos dados, a plataforma recomendaria tratamentos preventivos, cuidados específicos e produtos adequados para cada paciente, promovendo a saúde bucal e reduzindo a necessidade de tratamentos mais complexos.
-	Gamificação: A implementação de elementos gamificados, como o sistema de cashback, incentivaria a adesão dos pacientes às recomendações da plataforma e a prática de hábitos saudáveis.
-	Comunicação personalizada: A plataforma permitiria uma comunicação mais próxima e personalizada com os pacientes, através de notificações, lembretes de consultas e materiais educativos.
-	Integração com a rede de dentistas: A plataforma seria integrada à rede de dentistas da Odontoprev, facilitando o agendamento de consultas, o acompanhamento dos tratamentos e a troca de informações entre os profissionais.

## Diagrama de Classes

![image](https://github.com/user-attachments/assets/70214640-5bd9-4056-a6d6-d4c07aa3b323)
![image](https://github.com/user-attachments/assets/8421a791-35ee-4ac0-94d9-7028f6d465b8)
![image](https://github.com/user-attachments/assets/61baaca9-4520-47ed-9ca1-d0eac9eb528f)
![image](https://github.com/user-attachments/assets/acd40a19-3abc-4bbc-a71f-bd2d78b259a0)

## Diagrama de Relacionamento (DER)

![image](https://github.com/user-attachments/assets/684c9e4d-141f-4fe4-89cc-6e088574758b)
![image](https://github.com/user-attachments/assets/64a41d1e-612f-4e95-ae2a-d8807e5e7cb6)

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

### Cliente
* **GET /cliente:** Listagem de endpoints
* **GET /cliente/clientes**: Listar Clientes
* **GET /cliente/{clienteId}**: Obter Cliente
* **POST /cliente:** Criar Cliente
* **DELETE /cliente/{clienteId}**: Deletar Cliente

### Dentista
* **GET /dentista:** Listagem de endpoints
* **GET /dentista/dentistas**: Listar Dentistas
* **GET /dentista/{dentistaId}**: Obter Dentista
* **POST /dentista:** Criar Dentista
* **DELETE /dentista/{dentistaId}**: Deletar Dentista

### Consulta
* **GET /consulta:** Listagem de endpoints
* **GET /consulta/consultas**: Listar Consultas
* **GET /consulta/{consultaId}**: Obter Consulta
* **POST /consulta:** Criar Consulta
* **DELETE /consulta/{consultaId}**: Deletar Consulta
