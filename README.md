#Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение задачи состоит из нескольких этапов:
1. Задаем размер первоначального массива (***massiv***) и вводим значения массива поэлементно (используя цикл ***for***). Все элементы строкового типа (***string***). Строки **5-9**
1. После чего, также используя цикл ***for***, проверяем длину каждого элемента массива. В случае, если длина элемента **меньше или равна 3**, то выводим его в новый массив (***massivNew***)
1. На последнем этапе выводим первоначальный и новый массив на экран.