// // // Задание 1.1
// // for (int i = 10; i >= 1; i--)
// // {
// //     Console.WriteLine(i);
// // }
// // //задание 1.2
// // for (int i = 1; i <= 50; i++)
// // {
// //     if (i % 2 == 0)
// //     {
// //         Console.WriteLine(i);
// //     }
// // }
// // //Задание 2. Сумма кратных 3 и количество кратных 7
// // int sum3 = 0;
// // int count7 = 0;

// // for (int i = 1; i <= 100; i++)
// // {
// //     if (i % 3 == 0)
// //     {
// //         sum3 += i;
// //     }
// //     if (i % 7 == 0)
// //     {
// //         count7++;
// //     }
// // }

// // Console.WriteLine($"Сумма чисел, кратных 3: {sum3}");
// // Console.WriteLine($"Количество чисел, кратных 7: {count7}");
// // //Задание 3. Счёт положительных и отрицательных
// // Console.Write("Введите число (0 — стоп): ");
// // int number = Convert.ToInt32(Console.ReadLine());

// // int total = 0;
// // int positives = 0;
// // int negatives = 0;

// // while (number != 0)
// // {
// //     total += number;

// //     if (number > 0)
// //     {
// //         positives++;
// //     }
// //     else if (number < 0)
// //     {
// //         negatives++;
// //     }

// //     Console.Write("Введите число (0 — стоп): ");
// //     number = Convert.ToInt32(Console.ReadLine());
// // }

// // Console.WriteLine($"Сумма: {total}");
// // Console.WriteLine($"Положительных: {positives}");
// // Console.WriteLine($"Отрицательных: {negatives}");
// // //задание 4
// // bool accessGranted = false;
// // string correctPassword = "qwerty";

// // for (int attempt = 1; attempt <= 3; attempt++)
// // {
// //     Console.Write($"Попытка {attempt}. Введите пароль: ");
// //     string password = Console.ReadLine();

// //     if (password == correctPassword)
// //     {
// //         Console.WriteLine("Доступ разрешён");
// //         accessGranted = true;
// //         break;
// //     }
// // }

// // if (!accessGranted)
// // {
// //     Console.WriteLine("Доступ заблокирован");
// // }
// // //задание 5
// // Console.Write("Введите число от 1 до 9: ");
// // int n = int.Parse(Console.ReadLine());

// // for (int i = 1; i <= 10; i++)
// // {
// //     Console.WriteLine($"{n} × {i} = {n * i}");
// // }
// // //задание 6
// // for (int i = 1; i <= 30; i++)
// // {
// //     if (i % 3 == 0)
// //     {
// //         continue; // пропустить кратные 3
// //     }

// //     if (i % 10 == 0 && i > 20)
// //     {
// //         break; // остановить на 30
// //     }

// //     Console.WriteLine(i);
// // }
// //игра угадай число 
// int secret = 42;
// int maxAttempts = 5;
// bool won = false;

// Console.WriteLine("Угадай число (1-100). У вас 5 попыток.");

// for (int attempt = 1; attempt <= maxAttempts; attempt++)
// {
//     Console.Write($"Попытка {attempt}: ");
//     int guess = int.Parse(Console.ReadLine());

//     if (guess == secret)
//     {
//         Console.WriteLine($"Победа! Попыток: {attempt}");
//         won = true;
//         break;
//     }
//     else if (guess < secret)
//     {
//         Console.WriteLine("Больше");
//     }
//     else
//     {
//         Console.WriteLine("Меньше");
//     }
// }

// if (!won)
// {
//     Console.WriteLine($"Вы проиграли, число было {secret}");
// }

#доп.задание
Console.Write("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine());

int sumDigits = 0;
int countDigits = 0;

while (num > 0)
{
    int digit = num % 10;   // последняя цифра
    sumDigits += digit;
    countDigits++;
    num /= 10;              // отбросить её
}

Console.WriteLine($"Сумма цифр: {sumDigits}");
Console.WriteLine($"Количество цифр: {countDigits}");