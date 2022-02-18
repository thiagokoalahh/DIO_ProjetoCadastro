# Criando um APP simples de cadastro de séries e filmes em .NET

## Alterações no projeto

No final da explicação do projeto, o especialista Eliézer Zarpelão propõe a adição de filmes ao projeto que até então era só de séries. Então, com base nas classes pré estabelecidas, criei outras para filmes.

### Novos Aquivos

- Filme.cs: Segue a mesma ideia de Serie.cs, adaptando para filmes
- FilmeRepositorio.cs: Segue a mesma ideia de SerieRepositorio.cs, adaptando para filmes também.
- IService: Utilizando a mesma ideia de IRepositorio, para desacoplar o sistema, esta interface estabelece os métodos que os serviços devem ter.
  - SerieService: Armazena uma Lista de séries e agrupa todos os métodos relacionados a série que antes estavam no programa principal.
  - FilmeService: Adaptação de SerieService.
- Program.cs agora em vez de instanciar um repositório, armazena uma lista do tipo IService e adiciona SerieService e FilmeService.
  - Program agora tem como responsabilidade iniciar o app e alterar qual serviço está sendo utilizado no momento.
