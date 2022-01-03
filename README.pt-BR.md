# Máquina de Estados e Máquina de Estados Hierárquica
[![](https://img.shields.io/badge/lang-en-red)](README.md)

**Máquina de Estados** é um modelo matemático usado para representar programas de computadores ou circuitos lógicos. O conceito é concebido como uma máquina abstrata que deve estar em um de um número finito de estados, deve possuir um estado por vez e um estado armazena informações sobre o passado. Uma transição indica uma mudança de estado e é descrita por uma condição que precisa ser realizada para que a transição ocorra. [- 🌐 Wikipedia](https://pt.wikipedia.org/wiki/Máquina_de_estados_finita)

**Máquina de Estados Hierárquica** captura os aspectos comuns organizando os estados como uma hierarquia. Os estados no nível superior na hierarquia executam o tratamento de mensagem comum, enquanto os estados de nível inferior herdam a comunalidade dos níveis superiores e executam as funções específicas do estado. [- EventHelix](https://www.eventhelix.com/design-patterns/hierarchical-state-machine/)

<br />

![](Images/State%20Machine.png)
*Representação da Máquina de Estados*

<br />

![](Images/Hierarchical%20State%20Machine.png)
*Representação da Máquina de Estados Hierárquica*

<br />

## Como é implementado?
OBS: Eu utilizei os vídeos do [IHeartGameDev](https://www.youtube.com/watch?v=Vt8aZDPzRjI) como referência para esses scripts.

## Máquina de Estados
Os arquivos com as classes abstratas está na *pasta [State Machine](Assets/Scripts/State%20Machine)* onde [State.cs](Assets/Scripts/State%20Machine/State.cs) representa um estado e [StateManager.cs](Assets/Scripts/State%20Machine/StateManager.cs) é o "gerente de estados" onde devemos manipular e armazenar os estados e executar os métodos fornecidos pelo estado no Unity MonoBehaviour.

### State.cs
Nesse arquivo temos 4 métodos, onde pode acrescentar mais métodos dependendo da complexidade.

`EnterState()` é chamado quando mudamos o estado anterior para o atual.

`UpdateState()` é chamado pelo Update do Unity MonoBehaviour.

`ExitState()` é chamado quando o estado atual muda para outro.

`CheckSwitchState()` é chamado pelo `UpdateState()` para verificar os estados que podemos mudar.

### StateManager.cs
Nesse arquivo só precisamos de um método para mudar de estado e um atributo que armazena o estado atual.

`SwitchState(newState)` usa o `EnterState()` do novo estado e `ExitState()` do estado anterior.

<br />

![](Images/State%20Machine%20Implementation.png)
*Implementação representada*

<br />

## Máquina de Estados Hierárquica
Os arquivos com as classes abstratas estão na *pasta [HierarchicalStateMachine](Assets/Scripts/Hierarchical%20State%20Machine)* onde [HierarchicalState.cs](Assets/Scripts/Hierarchical%20State%20Machine/HierarchicalState.cs) representa um estado, com propriedades de sua hierarquia e [HierarchicalStateManager.cs](Assets/Scripts/Hierarchical%20State%20Machine/HierarchicalStateManager.cs) é o "gerente de estados" onde devemos armazenar o estado raiz e executar os métodos fornecidos por ele e seus "filhos".

### HierarchicalState.cs
Neste arquivo temos 9 métodos, incluindo os métodos do **State.cs** e acesso ao estado "pai", o estado "filho" e ao contexto.

`UpdateStates()` é chamado no método Update MonoBehaviour para atualizar os estados de toda a hierarquia.
`SetSuperState(newSuperState)` é chamado quando você define um novo estado "filho", então o estado "filho" precisa conhecer seu estado "pai".
`SetSubState(newSubState)` é chamado quando você define um estado "filho".
`InitializeSubState()` é chamado no construtor da classe, para verificar qual estado "filho" iremos inicializar.
`SwitchState(newState)` é o mesmo que **StateManager.cs**, mas precisamos saber se estamos no estado raiz para realizar a troca de estado no Manager ou definir um novo estado "filho".

### HierarchicalStateManager.cs
Neste arquivo, precisamos apenas de um atributo para armazenar o estado raiz, então o método `SwitchState(newState)` do script **HierarchicalState.cs** pode alterá-lo.

<br />

![](Images/Hierarchical%20State%20Machine%20Implementation.png)
*Implementação representada*

<br />

## Examples
Você pode ver os exemplos quando abrir o repositório na Unity. Acessando os arquivos das cenas pela *pasta [Demos](Assets/Demos)*.

## TODO
- [ ] Mais exemplos;
- [x] Representações com imagens para melhor entendimento no README;
- [x] Suporte ao meu idioma nativo (pt-BR);
- [x] Implementar máquina de estados hierárquica.