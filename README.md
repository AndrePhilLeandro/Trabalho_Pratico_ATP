# Trabalho Prático ATP

## Professora: Michelle Nery

**Alunos:**
- André Phillipe Leandro 
- Lucas Ramalho de Barros Torres
- Tadeu Gomes Brito  



## Descrição

Trabalho prático com o objetivo de implementar os conceitos aprendidos ao longo do 1º período da disciplina de **Algoritmos e Técnicas de Programação**.  

O trabalho consiste em 10 mapas de labirintos interativos, onde o objetivo é ir de um ponto **Start (S)** a um ponto **End (E)**, seguindo as seguintes regras:

1. Só existe um ponto **Start** e um ponto **End**;
2. Só existe um único caminho do **Start** até o **End** (não há ciclos);
3. O labirinto não possui caminhos paralelos (ou seja, não há corredores com largura maior que 1 célula, nem salas);
4. O ponto **End** é sempre acessível a partir do ponto **Start** (garantido também pela primeira condição).  

## Explicação e Funcionamento

Os mapas são representados por matrizes de dimensões `m x n` e carregados a partir de arquivos `.txt`.  
O labirinto é projetado de forma que exista apenas um caminho do ponto **S** ao ponto **E**.  

A lógica principal utiliza um vetor para armazenar o caminho correto do ponto inicial ao ponto final.  

- Ao digitar um movimento, o sistema verifica se ele corresponde ao movimento esperado do vetor.
- Se o movimento for válido (`validação true`), o jogador pode prosseguir para o próximo passo.
- Caso contrário, o sistema solicitará que o jogador insira novamente o movimento correto.  

Dessa forma, o objetivo é que o jogador complete o trajeto do ponto **S** ao ponto **E** corretamente.  
