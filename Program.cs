// Напишите программу, которая на вход принимает число и выдает
// его квадрат (умноженное на само себя)
System.Console.Write("Введите число > ");                                   // Вывод в консоль приглашения для ввода
string inputValue;                                                          // Объявление переменной
inputValue = Console.ReadLine();                                            // Присваивание переменной из консоли
int value = Convert.ToInt32(inputValue);                                    // Ковертация в целое введенной строки

int square = value * value;                                                 // Вычисление квадрата

// Вывод на экран
System.Console.WriteLine("Квадрат числа " + value + " равен " + square);
System.Console.WriteLine($"Квадрат числа {value} равен {square}");
