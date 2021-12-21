# Máquina de estados
[![](https://img.shields.io/badge/lang-en-red)](README.md)

**Máquina de estados** é um modelo matemático usado para representar programas de computadores ou circuitos lógicos. O conceito é concebido como uma máquina abstrata que deve estar em um de um número finito de estados, deve possuir um estado por vez e um estado armazena informações sobre o passado. Uma transição indica uma mudança de estado e é descrita por uma condição que precisa ser realizada para que a transição ocorra. [- 🌐 Wikipedia](https://pt.wikipedia.org/wiki/Máquina_de_estados_finita)

## Como é implementado?
Os arquivos com as classes abstratas está na *pasta [State Machine](Assets/Scripts/State%20Machine)* onde [State.cs](Assets/Scripts/State%20Machine/State.cs) representa um estado e [StateManager.cs](Assets/Scripts/State%20Machine/StateManager.cs) é a "gerente de estados" onde devemos executar as funções do estado por lá utilizando o MonoBehaviour do Unity.

OBS: Eu utilizei os vídeos do [IHeartGameDev](https://www.youtube.com/watch?v=Vt8aZDPzRjI) como referência para esses scripts.

### State.cs
Nesse arquivo temos 4 métodos, onde pode acrescentar mais métodos dependendo da complexidade.

`EnterState()` é chamado quando mudamos o estado anterior para o atual.

`UpdateState()` é chamado pelo Update do Unity MonoBehaviour.

`ExitState()` é chamado quando o estado atual muda para outro.

`CheckSwitchState()` é chamado pelo `UpdateState()` para verificar os estados que podemos mudar.

### StateManager.cs
Nesse arquivo só precisamos de um método para mudar de estado e um atributo que armazena o estado atual.

`SwitchState(newState)` usa o `EnterState()` do novo estado e `ExitState()` do estado anterior.

## Examples
Você pode ver os exemplos quando abrir o repositório na Unity. Acessando os arquivos das cenas pela *pasta [Demos](Assets/Demos)*.

## TODO
- [ ] Mais exemplos;
- [ ] Representações com imagens para melhor entendimento no README;
- [x] Suporte ao meu idioma nativo (pt-BR);
- [ ] Implementar máquina de estados hierárquica.