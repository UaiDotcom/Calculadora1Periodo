# EN - US

# Base Conversion Calculator - 1st Semester

## Didactic Calculator

The objective of this project is to develop a didactic base conversion calculator. By developing this project, you will improve your skills in algorithm development, creating new programs, and applying programming techniques. Additionally, you will deepen your knowledge of base conversion processes and build a support tool for your entire journey in the Information Technology courses at Faculdade Cotemig.

Please follow the instructions below for a better understanding:
To start your work, your program should present a menu similar to the one shown below:


| Base Conversion Menu:                                            |
|------------------------------------------------------------------|
| 1. Decimal -> Binary                                             |
| 2. Binary -> Decimal                                             |
| 3. Decimal -> Octal                                              |
| 4. Octal -> Decimal                                              |
| 5. Decimal -> Hexadecimal                                        |
| 6. Hexadecimal -> Decimal                                        |
| 7. Binary -> Octal                                               |
| 8. Octal -> Binary                                               |
| 9. Binary -> Hexadecimal                                         |
| 10. Hexadecimal -> Binary                                        |
| 11. Octal -> Hexadecimal                                         |
| 12. Hexadecimal -> Octal                                         |
| 0. Exit                                                          |

When the user selects an option from the menu, the program will prompt for the number to be converted to the chosen base. After the user enters the chosen number, the program should show the steps used for the conversion calculation. Thus, for each menu option selected, a valid conversion algorithm should be applied and exemplified, according to the user's choice.

Example:

| Enter a decimal number to be converted to binary: 194            |
|------------------------------------------------------------------|
| Step 1: 194 / 2 -> Quotient: 97, Remainder: 0                    |
| Step 2: 97 / 2 -> Quotient: 48, Remainder: 1                     |
| Step 3: 48 / 2 -> Quotient: 24, Remainder: 0                     |
| Step 4: 24 / 2 -> Quotient: 12, Remainder: 0                     |
| Step 5: 12 / 2 -> Quotient: 6, Remainder: 0                      |
| Step 6: 6 / 2 -> Quotient: 3, Remainder: 0                       |
| Step 7: 3 / 2 -> Quotient: 1, Remainder: 1                       |
| Step 8: 1 / 2 -> Quotient: 0, Remainder: 1                       |
| Step 9: Gather the remainders from steps 8, 7, 6, 5, 4, 3, 2, 1  |
|------------------------------------------------------------------|
| Result: 11000010                                                 |
|------------------------------------------------------------------|

Assumptions:
1. Use variables, operators, decision structures, and loops.
2. Use the switch structure to create the menu.
3. Use functions or procedures to structure the algorithms for the menu and each conversion requested by the user. All menu options should have their own implementation. Example:
   a. public static long decimalToBinary(long value) { // code with steps }
   b. public static long binaryToDecimal(long value) { // code with steps }
   c. public static long decimalToOctal(long value) { // code with steps }
   d. public static long octalToDecimal(long value) { // code with steps }
   e. public static string decimalToHex(long value) { // code with steps }
   f. etc.
4. The program should allow performing as many conversions as the user wants until they select option 0 to exit the menu.
5. Perform the necessary validations to prevent invalid input values.
6. The steps for executing the base conversion algorithm are essential, and the use of ready-made methods or functions from libraries is not allowed. Implement your own algorithm!
7. Maximum team size: 2 people.
Tip: Try to apply algorithms you have studied or already know. Consult your professors for guidance on the algorithms if necessary! ;)

---

**Note: The code is written in C# and is in Portuguese.**




PT- BR


Calculadora de  Conversões de Base - 1 Período

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
| 0. Sair |
| opção: _ |

Quando o usuário escolher uma das opções do menu, o programa irá solicitar o número
que deseja ser convertido para a base escolhida. Após a digitação do número escolhido
pelo usuário, o programa deverá mostrar os passos utilizados para o cálculo da conversão.
Sendo assim, a cada opção do menu escolhida, um algoritmo válido de conversão deverá
ser aplicado e exemplificado, conforme a opção do usuário.

Exemplo:

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
