using Snake;

//Console.WriteLine("Snake");
Console.SetBufferSize(150, 150);

// grid painting
HorizontLine upline = new HorizontLine(0, 78, 0, '+');
HorizontLine downLine = new HorizontLine(0, 78, 24, '+');
VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
upline.Draw();
downLine.Draw();
leftLine.Draw();
rightLine.Draw();

// point painting
Point p = new(4, 5, '*');
MySnake snake = new MySnake(p, 4, Direction.RIGHT);
snake.Draw();

while(true)
{
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if(key.Key == ConsoleKey.LeftArrow)
            snake.direction = Direction.LEFT;
        else if (key.Key == ConsoleKey.RightArrow)
            snake.direction = Direction.RIGHT;
        else if (key.Key == ConsoleKey.UpArrow)
            snake.direction = Direction.UP;
        else if (key.Key == ConsoleKey.DownArrow)
            snake.direction = Direction.DOWN;
    }
    Thread.Sleep(100);
    snake.Move();
}

//Console.ReadLine();




