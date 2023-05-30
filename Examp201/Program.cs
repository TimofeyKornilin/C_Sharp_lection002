// программа определения максимума среди 9ти чисел разными способами
// способ всплывающего пузырька

int a1 = 34;
int b1 = 26;
int c1 = 67;
int a2 = 3;
int b2 = 226;
int c2 = 673;
int a3 = 3359;
int b3 = 2;
int c3 = 7;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);