# 💰 Sistema de Conta Bancária

## 📌 Introdução

Este projeto é uma aplicação console em **C#** que simula um sistema bancário simples. O sistema permite utilizar contas bancárias, realizar saques, depósitos, transferências, consultar saldo e emitir extratos.

## 🛠 Tecnologias Utilizadas
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Microsoft Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)
![Microsoft](https://img.shields.io/badge/Microsoft-0078D4?style=for-the-badge&logo=microsoft&logoColor=white)

---

## 🚀 Funcionalidades

✅ **Conta Bancária**
- Cada conta possui:
  - Um número identificador
  - Saldo inicial
  - Um limite de crédito

✅ **Saque**
- Permite sacar dinheiro da conta, considerando o saldo disponível e o limite de crédito.
- Caso o saldo fique negativo, o limite é reduzido proporcionalmente.

✅ **Depósito**
- Permite adicionar dinheiro à conta.
- Caso o saldo esteja negativo, o depósito é utilizado para restaurar o limite de crédito antes de ser adicionado ao saldo.

✅ **Transferência entre Contas**
- Permite transferir dinheiro de uma conta para outra, respeitando saldo e limite de crédito.

✅ **Consulta de Saldo**
- Exibe o saldo atual e o limite de crédito disponível.

✅ **Emissão de Extrato**
- Exibe todas as movimentações realizadas na conta.

✅ **Interface no Console**
- Menu interativo para escolha de operações.

---

## 🎮 Como Usar

1. **Escolher uma conta**
   - O sistema permite selecionar uma das contas bancárias disponíveis.

2. **Selecionar uma operação**
   - Escolha entre Saque, Depósito, Transferência, Consulta de Saldo ou Extrato.

3. **Realizar a transação**
   - Informe os valores conforme solicitado.

4. **Encerrar ou continuar**
   - Pode continuar realizando operações ou sair do programa.

---
## 📄 Estrutura do Código

### **ContaBancaria.cs**
- Implementa as funcionalidades de conta bancária: saque, depósito, extrato, saldo e transferência.

### **Program.cs**
- Interface interativa que permite interação com o usuário via console.

---

## 📌 Exemplo de Uso

```plaintext
Escolha uma conta:
1 - Conta 1
2 - Conta 2
0 - Sair

> 1

Escolha uma operação:
1 - Saque
2 - Depósito
3 - Consulta de Saldo
4 - Emissão de Extrato
5 - Transferência entre Contas
6 - Voltar
0 - Sair

> 2
Informe o valor do depósito: 500
Depósito realizado com sucesso.
```
## 💻 Exemplo de Execução:  

![](https://i.imgur.com/lEr9gv7.gif)

---

## 🔄 Regras e Validações

### 🏦 **Saque**
- Deve ser maior que zero.
- Deve respeitar saldo e limite de crédito.
- Atualiza saldo e movimentação no extrato.

### 💰 **Depósito**
- Deve ser maior que zero.
- Prioriza restaurar limite antes de adicionar ao saldo.

### 🔄 **Transferência**
- O valor deve ser positivo.
- O saldo da conta de origem deve ser suficiente (considerando limite).
- O valor é creditado na conta de destino.

---
## 🛠 Como utilizar:
🚀 Passo a Passo

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project ContaCorrente
```
6. Para executar o arquivo compilado, navegue até a pasta: ./ContaCorrente/bin/Release/net8.0/ e execute o arquivo:
```
ContaCorrente.ConsoleApp.exe
```

