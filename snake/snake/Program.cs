
void Draw(int x, int y, char symb)
{
    Console.SetCursorPosition(x, y);
    Console.Write(symb);
    Console.WriteLine();
}

Draw(5, 5, '*');
Draw(3, 4, '#');
Draw(1, 2, '#');
Console.ReadLine();