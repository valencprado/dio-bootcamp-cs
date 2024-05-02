-- 1 - Buscar o nome e ano dos filmes

select Id, Nome, Ano from Filmes

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano


select Nome, Ano from Filmes order by Ano

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração

select Nome, Ano, Duracao from Filmes where Id = 28

-- 4 - Buscar os filmes lançados em 1997

select * from Filmes where Ano = 1997

-- 5 - Buscar os filmes lançados APÓS o ano 2000

select * from Filmes where Ano > 2000

-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente

select * from Filmes where Duracao between 100 and 150 order by Duracao

-- 7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente

select COUNT(*) [Quantidade], Ano from Filmes group by Ano order By Quantidade desc

-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome

select PrimeiroNome, UltimoNome from Atores where Genero = 'M'

-- 9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome


select PrimeiroNome, UltimoNome from Atores where Genero = 'F' order by PrimeiroNome

-- 10 - Buscar o nome do filme e o gênero

select f.Nome, g.Genero from Filmes f inner join FilmesGenero fg on f.Id = fg.IdFilme
inner join Generos g on g.Id = fg.IdGenero

-- 11 - Buscar o nome do filme e o gênero do tipo "Mistério"

select f.Nome, g.Genero from Filmes f inner join FilmesGenero fg on f.Id = fg.IdFilme
inner join Generos g on g.Id = fg.IdGenero where Genero = 'Mistério'

-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel

select f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel from Filmes f inner join ElencoFilme ef on f.Id = ef.IdFilme
inner join Atores a on a.Id = ef.IdAtor