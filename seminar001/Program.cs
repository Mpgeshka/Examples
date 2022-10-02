System.Console.Write("Введите число >");
string inputString = Console.ReadLine();
int value = Convert.ToInt32(inputString);

int square = value * value;
System.Console.WriteLine($"Квадрат числа {value} равен {square}");
