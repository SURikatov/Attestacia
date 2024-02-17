#Приветствую тебя!
В этой программе мы создали программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
```sh
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

#Как решалась задача?
Изначально мы создали исходный массив который в последующем будем обрабатывать по условиям задачи выше.
Вторым действием создаем новый массив для хранения наших результатов.
Третьим действием создаем переменную для отслеживания текущего индекса.
Четвертым действием создаем цикл foreach для перебора каждой строки массива, и параллельно проверяем условие длины строки, чтобы не превышало 3 символов.
Пятым действием создаем еще один массив, который содержит только непустые элементы.
И последним шустым действием прописали вывод результата.