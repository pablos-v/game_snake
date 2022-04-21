Console.SetBufferSize(120, 30);

snake.Walls walls = new snake.Walls(79, 24);
walls.Draw();
snake.Point startPoint = new snake.Point(3, 3, '*');
snake.Snake my_snake = new snake.Snake(startPoint, 6, snake.Direction.RIGHT);
my_snake.Draw();

snake.FoodCreator food = new snake.FoodCreator(80, 25, 'o');
snake.Point apple = food.CreateApple();
apple.Draw();

while(true)
{
    if (walls.IsHit(my_snake) || my_snake.IsHitTail()) break;
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
Console.SetCursorPosition(30, 12);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("GAME OVER !!!");
Console.ReadLine();
