DataContext - Representação dos dados na memória.


-- Entity Framework por padrão não entende entidades que não sejam primary key


Select - Entity

ToList() - Executa a query.
o ToList() no final da query significa que só vamos materializar em memória após aplicar todos os filtros possíveis;
Caso contrário, seja feita um filtro após o ToList(), vamos ter inúmeros erros de perfomance, pois a query já vai estar materialziada como um select (*);

AsNoTracking() - Caso eu não queira fazer upload ou remove, e assim, não quiser trazer metadados, posso utilizar o AsNoTracking().
Ajuda bastante na desempenho.

AsNoTracking() - Pode ser prejudicial caso você precise de algum metadado, como referência a alguma FK. Por isso Update e Deelte não é recomendado.

FirstOrDefault() - Executa a query como o ToList(). Caso não encontre, é default retorna nulo.
First() - retorna erro caso não contenha elemento.
Single e SingleOrDefault() - Atua igualmente ao FirstOrDefault().



----------
Mapeamento
Deparamento - Tabela do Banco <-> Classe.
Permite gerar o banco automaticamente.