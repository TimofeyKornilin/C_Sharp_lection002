// программа определения максимума среди 9ти чисел разными способами
// функция которая берёт 3 числа и справнивает их и выдаёт максимальное

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 34;
int b1 = 26;
int c1 = 67;
int a2 = 3;
int b2 = 226;
int c2 = 673;
int a3 = 335;
int b3 = 2011;
int c3 = 7;

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);