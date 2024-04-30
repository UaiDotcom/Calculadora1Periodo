Calculadora1Periodo
Trabalho Prático - Interdisciplinar - Valor: 10 pontos
Programação de Computadores & Matemática
Professores: Lucas Schmidt & Vângellis Oliveira

Calculadora Didática
O objetivo deste trabalho é o desenvolvimento de uma
calculadora didática de conversão de bases.
Com o desenvolvimento deste trabalho, você irá aperfeiçoar o
desenvolvimento de algoritmos, a criação de novos programas
e a aplicação de técnicas de programação. Além disso, irá
aprofundar seus conhecimentos nos processos de conversão
de base além de construir uma ferramenta de apoio durante
de toda a sua jornada nos cursos de Tecnologia da
Informação da Faculdade Cotemig.
Veja as orientações a seguir, para melhor entendimento:
Iniciando seu trabalho, primeiramente, seu programa deverá apresentar um menu,
semelhante ao informado abaixo:
|------------------------------------------------------------------|
| Menu de conversão de base: |
|------------------------------------------------------------------|
| 1. Decimal -> Binario |
| 2. Binário -> Decimal |
| 3. Decimal -> Octal |
| 4. Octal -> Decimal |
| 5. Decimal -> Hexadecimal |
| 6. Hexadecimal -> Decimal |
| 7. Binario -> Octal |
| 8. Octal -> Binario |
| 9. Binario -> Hexadecimal |
| 10. Hexadecimal -> Binario |
| 11. Octal -> Hexadecimal |
| 12. Hexadecimal -> Octal |
|------------------------------------------------------------------|
| 0. Sair |
|------------------------------------------------------------------|
| opção: _ |
|------------------------------------------------------------------|
Quando o usuário escolher uma das opções do menu, o programa irá solicitar o número
que deseja ser convertido para a base escolhida. Após a digitação do número escolhido
pelo usuário, o programa deverá mostrar os passos utilizados para o cálculo da conversão.
Sendo assim, a cada opção do menu escolhida, um algoritmo válido de conversão deverá
ser aplicado e exemplificado, conforme a opção do usuário.

Exemplo:
|------------------------------------------------------------------|
| opção: 1 |
| |
| Informe um número decimal para ser convertido para binário: 194 |
|------------------------------------------------------------------|
| Passo 1: 194 / 2 -> Quociente: 97, Resto: 0 |
| Passo 2: 97 / 2 -> Quociente: 48, Resto: 1 |
| Passo 3: 48 / 2 -> Quociente: 24, Resto: 0 |
| Passo 4: 24 / 2 -> Quociente: 12, Resto: 0 |
| Passo 5: 12 / 2 -> Quociente: 6, Resto: 0 |
| Passo 6: 6 / 2 -> Quociente: 3, Resto: 0 |
| Passo 7: 3 / 2 -> Quociente: 1, Resto: 1 |
| Passo 8: 1 / 2 -> Quociente: 0, Resto: 1 |
| Passo 9: Junte os valores dos restos dos passos 8,7,6,5,4,3,2,1 |
|------------------------------------------------------------------|
| Resultado: 11000010 |
|------------------------------------------------------------------|
Premissas:
1. Utilize variáveis, operadores, estruturas de decisão e repetição;
2. Utilize a estrutura switch para a criação do menu;
3. Utilize funções ou procedimentos para estruturar os algoritmos do menu e de cada
conversão a ser solicitada pelo usuário. Todas as opções do menu deverão ter a
sua própria implementação. Exemplo:
a. public static long decimalToBinary(long value) { // código com os passos }
b. public static long binaryToDecimal(long value) { // código com os passos }
c. public static long decimalToOctal(long value) { // código com os passos }
d. public static long octalToDecimal(long value) { // código com os passos }
e. public static string decimalToHex(long value) { // código com os passos }
f. etc..
4. O programa deverá permitir realizar quantas conversões o usuário quiser, até ele
solicitar no menu a opção 0. Sair
5. Faça as devidas validações, para que não permitia valores de entrada inválidos
6. Os passos para execução do algoritmo de conversão de base são essenciais, não
sendo permitido o uso de métodos ou funções prontas em bibliotecas.
Implemente o seu algoritmo!
7. Máximo de integrantes: 2 pessoas
Dica: Busque aplicar algoritmos que você estudou ou já conhece. Consulte seus
professores para orientação sobre os algoritmos, se necessário! ;)
