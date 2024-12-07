Random rnd = new Random();

int[] d = new int[10];

for (int i = 0; i < d.Length; i++)
{
    d[i] = rnd.Next(1, 101);
}

for (int i = 0; i < d.Length; i++)
{
    Console.WriteLine("d[{0}]={1}", i, d[i]);
}

int sum = 0, min_num = 1000, max_num = -1;
double avg = 0.0;

for (int i = 0; i < d.Length; i++)
{
    sum += d[i];
    min_num = Math.Min(d[i], min_num);
    max_num = Math.Max(d[i], max_num);
}

avg = sum / (double)d.Length;

Console.WriteLine(sum);
Console.WriteLine(avg);
Console.WriteLine(min_num);
Console.WriteLine(max_num);