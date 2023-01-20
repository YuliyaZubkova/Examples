/* Программа нахождения максимального числа из девяти чисел стихийным способом:

int a1 = 31;
int b1 = 44;
int c1 = 23;
int a2 = 32;
int b2 = 43;
int c2 = 24;
int a3 = 12;
int b3 = 99;
int c3 = 85;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
} 

int a1 = 31;
int b1 = 58;
int c1 = 23;
int a2 = 32;
int b2 = 43;
int c2 = 24;
int a3 = 6752;
int b3 = 94;
int c3 = 85;

/* (более длинный вариант)int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
*/

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
 
Console.WriteLine(max);
