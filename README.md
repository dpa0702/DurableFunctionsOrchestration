Tech Challenge fase 2
<br/>
O problema
<br/>
O Tech Challenge desta fase será dividido em duas partes.<br/>
Na primeira, seu grupo deve desenvolver uma Function utilizando o template durable. Ela deve simular o processo de aprovação de um pedido. O formato está livre, mas vocês devem criar no formato durable para colocar este modelo em prática.<br/>
Na segunda, vocês precisam criar uma pipeline com CI/CD utilizando o Azure DevOps ou GitActions: a escolha é do grupo. Vocês podem utilizar o projeto desenvolvido na primeira fase do seu curso ou um outro, uma vez que o critério de aceite será a pipeline funcionando como um todo.<br/>

Como esperamos receber os entregáveis?<br/>
Vocês podem nos enviar o link do seu Github junto com o link da pipeline (deixe ela pública; tanto no Azure como no Github nós temos essa possibilidade) ou nos enviar um vídeo do grupo/um integrante do grupo apresentando o projeto, demonstrando como escolheram a arquitetura e o projeto funcionando.<br/>
Lembrando que, caso haja qualquer dúvida, estamos no Discord para lhes ajudar a tirar a nota máxima!<br/>

/************************************************************************************************************************/

Entrega Parte 1: Link github do projeto --> https://github.com/dpa0702/DurableFunctionsOrchestration<br/>

Projeto executando foi iniciado e a partir dele uma requisição de aprovação foi realizada através do valor da statusQueryGetUri.<br/>
Foram realizadas mais de uma requisição e o resultado você pode encontrar no print abaixo:<br/>
![image](https://github.com/dpa0702/DurableFunctionsOrchestration/assets/56276309/1b9e2412-d765-45a5-a9b6-f4b8a22798b8)<br/>
Obs: Algumas requisições foram rejeitadas pois implementamos uma lógica aleatória na regra de aprovação.<br/>

Entrega Parte 2: Link github da pipe do projeto --> https://github.com/dpa0702/DurableFunctionsOrchestration/actions<br/>
A pipe foi publicada com sucesso:<br/>
![image](https://github.com/dpa0702/DurableFunctionsOrchestration/assets/56276309/b7565b74-ecf7-4cca-9625-6d7421154f5f)<br/>

Link Azure DevOps da pipe do projeto --> https://dev.azure.com/dpa07020276/app-devops/_build/results?buildId=6&view=results<br/>
A pipe foi publicada com sucesso:<br/>
![image](https://github.com/dpa0702/DurableFunctionsOrchestration/assets/56276309/57764f2f-3676-4b8a-9346-d51a96540f96)<br/>

Teste Local:<br/>
Start<br/>
![image](https://github.com/dpa0702/DurableFunctionsOrchestration/assets/56276309/80104aa5-4668-46f8-bf93-b5947cbbeb82)<br/>
Enviando requisição<br/>
![image](https://github.com/dpa0702/DurableFunctionsOrchestration/assets/56276309/befd4d75-ffe0-4bf9-ad8f-35cbe7d98776)<br/>

<br/>
*Link de apoio --> https://learn.microsoft.com/pt-br/training/modules/create-long-running-serverless-workflow-with-durable-functions/4-exercise-create-a-workflow-using-durable-functions
