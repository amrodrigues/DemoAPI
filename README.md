## Visão Geral do Projeto
Este projeto demonstra a criação de uma API simples com endpoints para gerenciar (ou neste caso, simular o retorno de) informações sobre alunos e uma previsão do tempo básica. A documentação da API é automaticamente gerada e disponibilizada através do Swagger UI.

## Exemplo de Endpoint (Aluno)
Para ilustrar como os endpoints são criados e documentados, veja o exemplo do AlunoController.cs:
![ControllerAluno](https://github.com/user-attachments/assets/4431dfc1-5eed-41d8-b7f8-b24801f49d7f)

 
Neste exemplo:

A anotação [ApiController] indica que esta classe é um controller de API.
[Route("[controller]")] define a rota base para este controller como /Aluno.
O método GetAlunos() é decorado com [HttpGet("alunos")], o que o mapeia para a rota GET /Aluno/alunos.
Ele retorna um objeto Aluno de exemplo.
Documentação da API com Swagger UI
A documentação interativa completa da API é gerada automaticamente a partir do código e está disponível através do Swagger UI.

 
Ao abrir a página do Swagger UI:

![Api](https://github.com/user-attachments/assets/d74253e8-479b-4e7f-a2f7-a581cc75e974)

## Endpoints (Rotas da API):
Você verá uma lista agrupada de todos os recursos disponíveis. Por exemplo, o grupo "Aluno" conterá o endpoint GET /Aluno/alunos, que corresponde exatamente ao método GetAlunos() no AlunoController que vimos acima.
Clique em qualquer endpoint para expandir e ver seus detalhes: descrição, parâmetros de entrada/saída e formatos de resposta.
Utilize o botão "Try it out" para executar requisições diretamente do seu navegador e testar a API.

## Schemas (Modelos de Dados):
No final da página, esta seção mostra a estrutura dos objetos de dados utilizados pela API (como o modelo Aluno que define os campos Nome, Id, Email, etc.).
Esta ferramenta é essencial para desenvolvedores que desejam entender e interagir rapidamente com a API.

 
