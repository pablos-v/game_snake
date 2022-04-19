static void Move(snake.Point p, int dx, int dy)
{
    p.x += dx;
    p.y += dy;
}

snake.Point p1 = new snake.Point(1,2,'*');
p1.Draw();
//snake.Point.Move(p1, 10, 10);
Move(p1, 2, 3);
p1.Draw();
Console.ReadLine();