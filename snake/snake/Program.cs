//Frame
snake.HorizLine lineUp = new snake.HorizLine(0, 78, 0, '-');
snake.HorizLine lineDown = new snake.HorizLine(0, 78, 24, '-');
snake.VertLine lineLeft = new snake.VertLine(0, 0, 24, '|');
snake.VertLine lineRight = new snake.VertLine(78, 0, 24, '|');
lineDown.Draw();
lineUp.Draw();
lineLeft.Draw();
lineRight.Draw();

Console.ReadLine();