#region Control Flow
#region Challenge1:
for (int i1 = 1; i1 <= 10; i1++)
{
    Console.WriteLine("Number: " + i1);
}
#endregion


Console.WriteLine("---------------");

#region Bonus!

int x = 5;
while (x >= 1)
{
    Console.WriteLine("Number: " + x);
    x--;
}

#endregion


Console.WriteLine("---------------");

#endregion


#region Arrays


#region Challenge1:

string[] daysOfWeek = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };
for (int i = 0; i < daysOfWeek.Length; i++)
{
    Console.WriteLine(daysOfWeek[i]);
}

#endregion


Console.WriteLine("---------------");

#region Challenge2:
int[] num = { 69, 70 };
int sum = 0;
for (int i = 0;i < num.Length; i++)
{
    sum += num[i];
}
Console.WriteLine("sum: " + sum);

#endregion



Console.WriteLine("---------------");

#region Bonus!

//It's a matrix of arrays (columns,rows)
string[,] dimension = { { "2", "1" }, { "3", "4" } };
for (int i = 0; i < dimension.GetLength(0); i++)
{
    for (int j = 0; j < dimension.GetLength(1); j++)
    {
        Console.Write(dimension[i, j] + " ");
    }
    Console.WriteLine();
}

#endregion



#endregion