// 
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