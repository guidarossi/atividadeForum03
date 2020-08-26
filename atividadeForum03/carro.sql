-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Ago-2020 às 19:41
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `locadoraveiculos_`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carro`
--

CREATE TABLE `carro` (
  `idFabricante` int(30) NOT NULL,
  `idEspecificacoes` varchar(110) NOT NULL,
  `idDataLocacao` varchar(15) NOT NULL,
  `ativoCarro` int(11) NOT NULL,
  `Marca` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `carro`
--

INSERT INTO `carro` (`idFabricante`, `idEspecificacoes`, `idDataLocacao`, `ativoCarro`, `Marca`) VALUES
(2, 'gasolina, duas portas, uno.', '25/08/2020', 0, 'Fiat'),
(3, ' bravo, gasolina, 4 portas.', '20/08/2020', 0, 'Fiat'),
(4, 'A3, gasolina, 2 portas', '15/08/2020', 0, 'Audi'),
(5, 'alcool, 4 portas', '12/05/2020', 0, 'volvo'),
(6, 'marea,gasolina,2 portas', '22/07/2020', 0, 'Fiat'),
(7, 'alcool, 4 portas x5', '14/08/2020', 0, 'audi');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `carro`
--
ALTER TABLE `carro`
  ADD PRIMARY KEY (`idFabricante`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carro`
--
ALTER TABLE `carro`
  MODIFY `idFabricante` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
