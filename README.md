# Escalonador de Processos - SO
Trabalho prático da matéria de Sistemas Operacionais - PUC Minas 2019

### Premissa
O trabalho consiste em uma simulação com GUI da forma como um escalonador de processos funciona. Deve-se implementar 2 algoritmos de escalonamento, um preemptivo e outro não. Deve-se também implementar a gerência de memória a gosto do aluno. O programa deve oferecer pelo menos 8 aplicações para escolha e cada processo deve possuir um tamanho e um tempo de execução.

### Proposta
Foram escolhidos os algoritmos de escalonamento FCFS (não preemptivo) e Round Robin (preemptivo). 

![image](https://user-images.githubusercontent.com/34424312/57983335-e6bcf580-7a26-11e9-995d-6507e09e8f86.png)

O gerenciamento de memória foi implementado com swap se ela estiver cheia na hora de executar um dos processos.

![image](https://user-images.githubusercontent.com/34424312/57983345-0fdd8600-7a27-11e9-87f5-8b1532d084b5.png)

### Especificações
- Linguagem: C#
- Interface: GTK#

### Para testar
- Instale o .NET Core SDK: https://dotnet.microsoft.com/download
- Instale o Mono: https://www.mono-project.com/download/stable/
- Instale a IDE: https://www.monodevelop.com/download/
- [Download .exe](https://drive.google.com/file/d/10U59FBbDmKWDlMLwXK-BbYZXGvCwW3xe/view?usp=sharing)
