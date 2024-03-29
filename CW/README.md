**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.**
-
Примеры:\
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]\
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]\
[“Russia”, “Denmark”, “Kazan”] → []

обратим внимание на формат вывода - в двойных кавычках,через запятую и всё заключено в квадратные скобки. Если массив пустой, то путые квадратные скобки.

1. Создадим функцию **InputArray** ввода текстового массива с клавиатуры. Пустой ввод будет означать окончание ввода. Поскольку неизвестно, сколько введут значений, то длина массива заранее неизвестна и каждый раз надо будет увеличивать длину массива на 1, если введенное значение не пустое, для этого используем функцию **Array.Resize**. Изначально создаём массив из одного пустого элемента. Сначала выводим приглашение ввести тектовое значение, далее введенный с клавиатуры текст присваивается текстовой переменной, и если введено не пустое значение, то увеличиваем на 1 длину массива и новому элементу присваиваем эту текстовую переменную.

2. Также создадим функцию **PrintArray** вывода на консоль элементов массива в заданном формате. Для этого проверяем, если первый элемент массива пустое значение, то просто выводим пару квадратных скобок **[]**, что означает пустой массив. Если первый элемент массива не пустое значение, то запускаем цикл поочерёдного вывода элементов массива. В начале и в конце выводим символы квадратных скобок **[** и **]**. Для того, чтобы напечатался символ двойных ковычек используем перед ним знак обратного слэша.

3. После того, как отработала функция ввода массива с клавиатуры, то начинаем формировать массив из элементов первого массива, удовлетворяющих условию в данном случае, длина элемента не более 3х символов. Длина второго массива также заранее не известна, поэтому вначале создадим его состоящим из одного элемента, а потом запускаем цикл перебора элементов первого массива, и при каждом обнаружении подходящего элемента будем увеличивать длину второго массива на 1 и добавлять значение элемента первого массива.

4. После формирования искомого массива из элементов первого массива запускаем функцию печати с заданным форматом обоих массивов.

Формально пустое значение "" тоже представляет текст не более трёх символов, но к сожалению, в этой программе ввод пустых значений не предусмотрен )).
