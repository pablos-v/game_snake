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
        if (key.Key == ConsoleKey.LeftArrow) my_snake.direction = snake.Direction.LEFT;
        else if (key.Key == ConsoleKey.RightArrow) my_snake.direction = snake.Direction.RIGHT;
        else if (key.Key == ConsoleKey.UpArrow) my_snake.direction = snake.Direction.UP;
        else if (key.Key == ConsoleKey.DownArrow) my_snake.direction = snake.Direction.DOWN;
    }
    Thread.Sleep(300);
    my_snake.Move();
}
//Console.ReadLine();