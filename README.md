# Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:

- Объявляем два массива: первый и вторый такой же длины. 
- Далее используем метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия (<= border), если условие выполняется, то элемент первого массива заносится в count элемента второго массива.
- После присвоения переменная count увеличивается на 1 и возвращается к циклу for, в котором i увеличивается на 1.

! [Блок-схема алгоритма основной части] (MainPart.png)

