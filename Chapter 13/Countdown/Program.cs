void Countdown(int num)
{
    if (num == 0) return;
    Console.WriteLine(num);
    Countdown(--num);
}

Countdown(10);