static void Move(snake.Point p, int dx, int dy)
{
    p.x += dx;
    p.y += dy;
}

snake.Point p1 = new snake.Point(1,2,'*');
p1.Draw();
//snake.Point.Move(p1, 10, 10);
Move(p1, 2, 3);


List<int> ls = new List<int>();
ls.Add(10);
ls.Add(11);
ls.Add(21);

ls.RemoveAt(0);
foreach(int i in ls)
{
Console.WriteLine(i);
}

List<snake.Point> lP = new List<snake.Point>();
lP.Add(p1);
lP[0].Draw();

Console.ReadLine();