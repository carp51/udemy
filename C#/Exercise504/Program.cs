int[,] d = new int[9, 9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        d[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write("{0}*{1}={2} ", i + 1, j + 1, d[i, j]);
    }
    Console.WriteLine();
}