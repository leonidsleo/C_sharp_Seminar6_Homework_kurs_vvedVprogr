//                      Семинар 6. Курс введение в программирование. C#
//                                        Домашняя работа:
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CreateList(List<int> numbers) // метод создания списка на основе ввода чисел клиентом с клавиатуры
{
Console.WriteLine("Введите число. Для окончания ввода чисел, нажмите ввод (enter) в пустой строке.");
string num2 = "";
while((num2 = Console.ReadLine()) != "")
{
    numbers.Add(Convert.ToInt32(num2));
}
Console.WriteLine("Вы ввели числа [{0}]", string.Join(", ", numbers));
}
// List<int> numbers = new List<int> ();
// CreateList(numbers);

void SearchNum(List<int> numbers) // метод, поиск положительных чисел в списке (массиве)
{
    int num = 0;
    int ind = 0;
    while (ind < numbers.Count) // numbers - наименование списка; Count - оператор длиины списка
    {
        if (numbers[ind] > 0)
        {
            num = num + 1;
        }
        ind = ind + 1;
    }
    Console.WriteLine($"Количество положительных чисел = {num}");
}
// SearchNum(numbers); // вывод метода в консоль

List<int> numbers = new List<int> ();
CreateList(numbers);
SearchNum(numbers);