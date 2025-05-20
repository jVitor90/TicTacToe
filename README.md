
#Tic tac toe em C#

Projeto simples desenvolido no curso técnico em desenvolvimento de sistemas no senac de Pindamonhamgaba.



## Funcionalidades

Interface Gráfica Intuitiva: Desenvolvida com Windows Forms, oferece uma experiência visual amigável com botões representando o tabuleiro 3x3.
Modo de Dois Jogadores: Suporta jogadas alternadas entre dois jogadores, com exibição clara de qual símbolo ('X' ou 'O') está ativo.
Manipulação de Eventos com object_sender: Utiliza o parâmetro object_sender para identificar dinamicamente qual botão do tabuleiro foi clicado, otimizando a lógica de manipulação de eventos e reduzindo a redundância no código.
Detecção de Vitória ou Empate: Implementa algoritmos para verificar automaticamente condições de vitória (linhas, colunas ou diagonais) ou empate quando o tabuleiro está cheio, exibindo mensagens informativas ao final de cada partida.
Reinício Rápido: Inclui um botão ou funcionalidade para reiniciar o jogo, limpando o tabuleiro e permitindo uma nova partida sem fechar o aplicativo.
Feedback Visual: Os botões do tabuleiro mudam de estado visualmente (ex.: exibindo 'X' ou 'O') para indicar as jogadas realizadas.



## Estrutura do Código
Form Principal: Contém o layout do tabuleiro e os controles de interação (botões para o tabuleiro e reinício).
Manipulação de Eventos: Utiliza o object_sender para determinar qual botão foi clicado, reduzindo a necessidade de métodos específicos para cada botão e aumentando a eficiência.
Lógica do Jogo: Implementada em métodos que verificam o estado do tabuleiro, alternam entre jogadores e determinam o resultado da partida.
Interface Gráfica: Botões do Windows Forms são usados para representar as células do tabuleiro, com propriedades atualizadas dinamicamente para refletir o estado do jogo.