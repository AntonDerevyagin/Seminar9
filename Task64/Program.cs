// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int n = ReadInt("Введите n: ");
int count = 1;
line(n, count);

void line(int n, int count)
{
  if (count > n) return;
  line(n, count + 1);
  Console.Write(count + ", ");
}

int ReadInt(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
