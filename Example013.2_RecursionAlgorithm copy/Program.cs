// int Factorial (int n)                     // метод который принимает какоето число и возвращает факториал этого числа
// {
//     // 5! = 5*4*3*2*1
//     //      5*4!
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;                 // мы дошли до 1  и должны вернуть 1 - это определение факториала
//     else return n * Factorial(n - 1);    // или надо взять текущее значение и уменожит на факториал предидущего числа
// }
// Console.WriteLine(Factorial(3)); // 1*2*3*=6

// int Factorial (int n)  
double Factorial (int n)   // Чтобы не было переполнения
{
    if (n == 1) return 1;   
    else return n * Factorial(n - 1); 
}
for (int i = 1; i < 40; i++)
{
    // Console.WriteLine(Factorial(i));
    Console.WriteLine($"{i}! = {Factorial(i)}");  // Принудительно показываем факториал !
}
