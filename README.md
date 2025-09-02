
---

## 🧾 Documento Explicativo — Análise de Código C#

### 📌 Objetivo do Código
Este trecho de código tem como objetivo verificar se um número inteiro é par ou ímpar e exibir essa informação no console. Ele demonstra duas abordagens para essa verificação: uma usando o operador ternário e outra com a estrutura condicional `if/else` (comentada).

---

### 🧠 Explicação por Trecho

#### 1. Declaração de Variáveis
```csharp
int numero = 21;
bool ehPar = false;
```
- `numero`: variável inteira que armazena o valor a ser analisado.
- `ehPar`: variável booleana que será usada para armazenar o resultado da verificação de paridade.

---

#### 2. Verificação de Paridade com Operador Ternário
```csharp
//IF ternario
ehPar = numero % 2 == 0;
```
- O comentário indica que será usada uma forma alternativa ao `if`, ou seja, uma expressão condicional.
- `numero % 2 == 0` verifica se o número é divisível por 2. Se o resto da divisão for zero, o número é par.
- O resultado da expressão booleana é atribuído diretamente à variável `ehPar`.

---

#### 3. Impressão com Operador Ternário
```csharp
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
```
- Aqui está o uso efetivo do operador ternário:
  - `ehPar ? "par" : "ímpar"` retorna `"par"` se `ehPar` for `true`, e `"ímpar"` se for `false`.
- A interpolação de string (`$""`) é usada para inserir o valor da variável `numero` diretamente na mensagem.

---

#### 4. Alternativa com Estrutura `if/else` (Comentada)
```csharp
/*
if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}
*/
```
- Este bloco está comentado, mas serve como comparação didática.
- A lógica é idêntica à do operador ternário, mas escrita de forma mais explícita.
- Pode ser mais legível para iniciantes, embora mais verbosa.

---

### ✅ Considerações Técnicas

- **Clareza vs. Concisão**: O operador ternário é mais conciso, mas o `if/else` pode ser mais claro para quem está começando.
- **Boas práticas**: O uso de comentários para contextualizar o código é excelente, especialmente ao mostrar alternativas.
- **Extensibilidade**: O código é simples e direto, mas poderia ser facilmente adaptado para verificar múltiplos números ou ser encapsulado em um método reutilizável.

---
