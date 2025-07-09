Projeto: Demonstração de Threads em C#
Este projeto é um aplicativo de console em C# (.NET 8, Visual Studio 2022) que demonstra, na prática, como criar e gerenciar múltiplas threads para executar tarefas em paralelo. 

![image](https://github.com/user-attachments/assets/71b45b14-9682-4ba6-8111-19ea99f0c781)


O código exemplifica:
Thread Principal (Main Thread): executa um loop exibindo valores de 1 a 5 no console, com uma pausa de 1 segundo entre cada valor.

Thread1: criada a partir de um método separado, também exibe valores de 1 a 5, mas com uma pausa de 700 ms, mostrando o uso de métodos personalizados em threads.

Thread2: criada usando uma expressão lambda, exibe valores de 1 a 5 com pausa de 800 ms, mostrando como passar blocos de código diretamente ao construtor da thread.

Durante a execução, as três threads rodam concorrentemente, permitindo observar a alternância entre as mensagens impressas por cada uma no console. Ao final, o programa utiliza o método Join() para garantir que as threads secundárias terminem sua execução antes de encerrar o programa principal.

Este exemplo é ideal para quem deseja entender os conceitos de concorrência, execução paralela e sincronização de threads em C#.

Como executar
Abra o projeto no Visual Studio 2022.

Compile e execute o programa (Ctrl + F5) para visualizar a execução paralela das threads no console.

--------------------------------------------------------------------------------------------------
English
Project: C# Threads Demonstration
This project is a C# console application (.NET 8, Visual Studio 2022) that provides a practical demonstration of how to create and manage multiple threads to execute tasks in parallel. The code illustrates:

Main Thread: runs a loop displaying values from 1 to 5 in the console, with a 1-second pause between each value.

Thread1: created from a separate method, also displays values from 1 to 5 with a 700 ms pause, showing how to run custom methods on separate threads.

Thread2: created using a lambda expression, displays values from 1 to 5 with an 800 ms pause, demonstrating how to pass code blocks directly to the thread constructor.

During execution, all three threads run concurrently, so you can observe the interleaving of output messages in the console. At the end, the program uses the Join() method to ensure that both secondary threads finish before the main program ends.

This example is ideal for those who want to understand concurrency, parallel execution, and thread synchronization concepts in C#.

How to run
Open the project in Visual Studio 2022.

Build and run the program (Ctrl + F5) to see parallel thread execution in the console.

--------------------------------------------------------------------------------------------------
Español
Proyecto: Demostración de Hilos en C#
Este proyecto es una aplicación de consola en C# (.NET 8, Visual Studio 2022) que demuestra de manera práctica cómo crear y gestionar múltiples hilos para ejecutar tareas en paralelo. El código ilustra:

Hilo Principal (Main Thread): ejecuta un bucle que muestra valores del 1 al 5 en la consola, con una pausa de 1 segundo entre cada valor.

Thread1: creada a partir de un método separado, también muestra valores del 1 al 5 con una pausa de 700 ms, mostrando el uso de métodos personalizados en hilos.

Thread2: creada usando una expresión lambda, muestra valores del 1 al 5 con una pausa de 800 ms, demostrando cómo pasar bloques de código directamente al constructor del hilo.

Durante la ejecución, los tres hilos corren de manera concurrente, permitiendo observar la alternancia de mensajes impresos en la consola. Al final, el programa utiliza el método Join() para asegurar que los hilos secundarios finalicen antes de cerrar el programa principal.

Este ejemplo es ideal para quienes desean comprender los conceptos de concurrencia, ejecución paralela y sincronización de hilos en C#.
