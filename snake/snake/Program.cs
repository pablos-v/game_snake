Console.SetBufferSize(120, 30);
//Frame
snake.HorizLine lineUp = new snake.HorizLine(0, 78, 0, '-');
snake.HorizLine lineDown = new snake.HorizLine(0, 78, 24, '-');
snake.VertLine lineLeft = new snake.VertLine(0, 0, 24, '|');
snake.VertLine lineRight = new snake.VertLine(78, 0, 24, '|');
lineDown.Draw();
lineUp.Draw();
lineLeft.Draw();
lineRight.Draw();

snake.Point p = new snake.Point(3, 3, '+');
snake.Snake my_snake = new snake.Snake(p, 6, snake.Direction.RIGHT);
my_snake.Draw();
while(true)
{
    if(Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        my_snake.DirectionListener(key.Key);
    }
    Thread.Sleep(150);
    my_snake.Move();
}
//Console.ReadLine();