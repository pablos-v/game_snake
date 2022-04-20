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

snake.FoodCreator food = new snake.FoodCreator(80, 25, 'o');
snake.Point apple = food.CreateApple();
apple.Draw();

while(true)
{
    if (my_snake.Eat(apple))
    {
        apple = food.CreateApple();
        apple.Draw();
    }
    else my_snake.Move();

    Thread.Sleep(150);

    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        my_snake.DirectionListener(key.Key);
    }
}
//Console.ReadLine();