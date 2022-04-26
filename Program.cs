using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake;

Console.SetWindowSize(80, 26);

// grid painting
Walls walls = new Walls(80, 26);
walls.Draw();


// point painting
Point p = new(4, 5, '*');
MySnake snake = new MySnake(p, 4, Direction.RIGHT);
snake.Draw();

//food painting
FoodCreator foodCreator = new FoodCreator(77, 24, '$');
Point food = foodCreator.CreateFood();
food.Draw();

while (true)
{
    if( walls.IsHit(snake) || snake.IsHitTail() )
    {
        break;
    }
    if (snake.Eat(food))
    {
        food = foodCreator.CreateFood();
        food.Draw();
    }
    else
    {
        snake.Move();
    }

    Thread.Sleep(100);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        snake.HandKey(key.Key);
    }
}






