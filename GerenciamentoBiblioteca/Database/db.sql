-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de gera��o: 01-Ago-2025 �s 01:42
-- Vers�o do servidor: 10.4.24-MariaDB
-- vers�o do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gerenciamentobiblioteca`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `emprestimos`
--

CREATE TABLE `emprestimos` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_livro` int(11) NOT NULL,
  `data_emprestimo` date NOT NULL,
  `data_devolucao` date DEFAULT NULL,
  `data_devolvido` date DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Em andamento',
  `notificacao_excluida` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `livros`
--

CREATE TABLE `livros` (
  `id` int(11) NOT NULL,
  `titulo` varchar(255) NOT NULL,
  `autor` varchar(255) NOT NULL,
  `ano` int(11) NOT NULL,
  `genero` varchar(100) NOT NULL,
  `numero_paginas` int(11) NOT NULL,
  `qtd_exemplares` int(11) NOT NULL,
  `status` varchar(50) NOT NULL,
  `estado` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `livros`
--

INSERT INTO `livros` (`id`, `titulo`, `autor`, `ano`, `genero`, `numero_paginas`, `qtd_exemplares`, `status`, `estado`) VALUES
(1, 'O Senhor dos An�is', 'J.R.R. Tolkien', 1954, 'Fantasia', 1216, 10, 'Dispon�vel', 'Bom'),
(2, '1984', 'George Orwell', 1949, 'Distopia', 328, 5, 'Dispon�vel', 'Bom'),
(3, 'Dom Casmurro', 'Machado de Assis', 1899, 'Fic��o', 384, 8, 'Dispon�vel', 'Bom'),
(4, 'O Alquimista', 'Paulo Coelho', 1988, 'Drama', 208, 5, 'Dispon�vel', 'Bom'),
(5, 'Harry Potter e a Pedra Filosofal', 'J.K. Rowling', 1997, 'Fantasia', 223, 6, 'Dispon�vel', 'Bom'),
(6, 'A Culpa � das Estrelas', 'John Green', 2012, 'Romance', 336, 2, 'Dispon�vel', 'Bom'),
(7, 'Dom Quixote', 'Miguel de Cervantes', 1605, 'Romance', 1023, 4, 'Dispon�vel', 'Regular'),
(8, 'O Hobbit', 'J.R.R. Tolkien', 1937, 'Fantasia', 310, 5, 'Dispon�vel', 'Bom'),
(9, 'O C�digo Da Vinci', 'Dan Brown', 2003, 'Mist�rio / Suspense', 454, 3, 'Dispon�vel', 'Bom'),
(10, 'O Pequeno Pr�ncipe', 'Antoine de Saint-Exup�ry', 1943, 'Infantil', 96, 7, 'Dispon�vel', 'Bom'),
(11, 'Orgulho e Preconceito', 'Jane Austen', 1813, 'Romance', 279, 3, 'Dispon�vel', 'Bom'),
(12, 'O Apanhador no Campo de Centeio', 'J.D. Salinger', 1951, 'Fic��o', 277, 2, 'Dispon�vel', 'Regular'),
(13, 'A Revolu��o dos Bichos', 'George Orwell', 1945, 'Sat�rico', 112, 4, 'Dispon�vel', 'Bom'),
(14, 'Mem�rias P�stumas de Br�s Cubas', 'Machado de Assis', 1881, 'Romance', 208, 5, 'Dispon�vel', 'Regular'),
(15, 'Ensaio sobre a Cegueira', 'Jos� Saramago', 1995, 'Drama', 320, 3, 'Dispon�vel', 'Regular'),
(16, 'Capit�es da Areia', 'Jorge Amado', 1937, 'Romance', 272, 4, 'Dispon�vel', 'Regular'),
(17, 'Grande Sert�o: Veredas', 'Jo�o Guimar�es Rosa', 1956, 'Romance', 624, 2, 'Dispon�vel', 'Bom'),
(18, 'It: A Coisa', 'Stephen King', 1986, 'Terror / Horror', 1104, 3, 'Dispon�vel', 'Regular');

-- --------------------------------------------------------

--
-- Estrutura da tabela `notificacoes_leitor`
--

CREATE TABLE `notificacoes_leitor` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `mensagem` text NOT NULL,
  `data_hora` datetime DEFAULT current_timestamp(),
  `lida` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `publicacoes`
--

CREATE TABLE `publicacoes` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_livro` int(11) NOT NULL,
  `comentario` text NOT NULL,
  `estrelas` int(11) NOT NULL CHECK (`estrelas` between 1 and 5),
  `data_publicacao` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `email` varchar(200) NOT NULL,
  `data_nascimento` date NOT NULL,
  `senha` varchar(255) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `tipo_usuario` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `data_nascimento`, `senha`, `telefone`, `tipo_usuario`) VALUES
(1, 'Admin', 'admin@email.com', '2025-07-31', '$2a$11$DGasV3nCZYeUbkRjxZgnseT4H4JQt0RbzvDaJIOUcfinPsDgmHnIe', '419', 'Administrador');

--
-- �ndices para tabelas despejadas
--

--
-- �ndices para tabela `emprestimos`
--
ALTER TABLE `emprestimos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_livro` (`id_livro`);

--
-- �ndices para tabela `livros`
--
ALTER TABLE `livros`
  ADD PRIMARY KEY (`id`);

--
-- �ndices para tabela `notificacoes_leitor`
--
ALTER TABLE `notificacoes_leitor`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- �ndices para tabela `publicacoes`
--
ALTER TABLE `publicacoes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_livro` (`id_livro`);

--
-- �ndices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `emprestimos`
--
ALTER TABLE `emprestimos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `livros`
--
ALTER TABLE `livros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `notificacoes_leitor`
--
ALTER TABLE `notificacoes_leitor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `publicacoes`
--
ALTER TABLE `publicacoes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restri��es para despejos de tabelas
--

--
-- Limitadores para a tabela `emprestimos`
--
ALTER TABLE `emprestimos`
  ADD CONSTRAINT `emprestimos_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`),
  ADD CONSTRAINT `emprestimos_ibfk_2` FOREIGN KEY (`id_livro`) REFERENCES `livros` (`id`);

--
-- Limitadores para a tabela `notificacoes_leitor`
--
ALTER TABLE `notificacoes_leitor`
  ADD CONSTRAINT `notificacoes_leitor_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`);

--
-- Limitadores para a tabela `publicacoes`
--
ALTER TABLE `publicacoes`
  ADD CONSTRAINT `publicacoes_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`),
  ADD CONSTRAINT `publicacoes_ibfk_2` FOREIGN KEY (`id_livro`) REFERENCES `livros` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
