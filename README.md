﻿# Описание - решения задачи 
### Действия поэтапно 
1. Написал строку вывода сообщения для пользователя и строку для ввода c типом данных **string**
---
```sh 
Console.Write("Введите массив строк через запятую : ");

string stroka = Console.ReadLine()!;
```
---
2. Создал массив с типом данных **string** и спомощью метода **Split** его заполнил

```sh 
string [] mass = stroka.Split(',');
```
 **Метод Split**
> Разбивает строку на подстроки на основе указанных символов-разделителей.
---
3. Добавил в код две переменные с типом данных **int** index, и словом **var** newmass, для того чтобы компилятор **C#** автоматические определял какой больше тип данных подхоидит, и тем саммым улучшить читаемость кода. 
---
4. Преобразовал переменную **newmass** в массив, указав размерность массива -  который поступил в начале кода. Также задал значение переменной **index** = 0, для нового массива **newmass**, чтобы была возможность, под разными индексами,заполнить его.

```sh
var newmass = new string [mass.Length];
int index = 0;
```
---
5. Добавил Цикл **for** с переменной **i** и типом данных **int**. Цикл будет выполняться,пока **i меньше 0** 
```sh
for (int i = 0; i < mass.Length; i++)
{

}    
```
---
6. Заполнил тело цикла. Добавил переменную **mass2** со словом **var** - опять же, для улучшения чиатаемаости кода и добавил условие **if**. Для того,чтобы передавать строки масива под различными индексами и проверять размерность строки. Если строка Наример : i = 0 и его длина меньше или равна 3, то мы эту строку заполняем в наш новый массив **newmass**, фиксируем под каким индексом и сразуе же поcле заполнения массива под первым индексом,мы дабовляем второй индекс для дальнейшнего заполнения массива.
```sh
 var mass2 = mass[i];
    if (mass2.Length <=3)
    {
       newmass[index] = mass2;
       index++;        
    }
```
---
7. Для того чтобы вывести свой массив, я воспользовался двумя методами: **Array.Resize**, **string.Join**. 
 В **Array.Resize** я указал свой новый массив **newmass**  и её размерность **index**, которую я получил после завершения цикла. После вывел массив на экран с помощью метода **string.Join**
```sh
Array.Resize(ref newmass, index);
Console.Write(" → " + "["+string.Join(",", newmass) + "]");
```
**Метод Array.Resize, string.Join**
> Метод Array.Resize изменяет размерность одномерного массива, которую я получил после завершения цикла, и тем самым преобразовывает новый массив. 
>>Метод string.Join Соединяет  строки из массива, помещая между ними заданный разделитель.
----
#   F i n a l - c o n t r o l 2  
 