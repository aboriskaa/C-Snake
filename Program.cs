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
Point p = new(4,5,'*');
MySnake snake = new MySnake(p, 4, Direction.RIGHT);
snake.Draw();
Console.ReadLine();


