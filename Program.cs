// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x1 = 1;
int y1 = 3;
char sym1 = '*';

static void Draw(int x, int y, char sym)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(sym);
}

Draw(x1, y1, sym1);