using Snake;

Console.WriteLine("Snake");

Point p1 = new(1,3,'*');
p1.Draw();

Point p2 = new(4,5,'#');
p2.Draw();

List<int> numList = new List<int>();

numList.Add(0);
numList.Add(1);
numList.Add(2);

HorizontLine upline = new HorizontLine(0,78,0,'+');
HorizontLine downLine = new HorizontLine(0,78,24, '+');
VerticalLine leftLine = new VerticalLine(0,24,0, '+');
VerticalLine rightLine = new VerticalLine(0,24,78, '+');
upline.Draw();
downLine.Draw();
leftLine.Draw();
rightLine.Draw();



