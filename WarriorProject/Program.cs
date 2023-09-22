/*
 * A feladat a github-on olvasható!
 */

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WarriorProject
{
    public class Position
    {
        private int _x;
        private int _y;

        public double X { get => _x; }
        public double Y { get => _y; }  
        
        public Position(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public void ToConsole()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }

    public class Warrior
    {
        private string _name;
        private Position _position;

        public Warrior(string name, Position position)
        {
            this._name = name;
            this._position = position;
        }
        public void ToConsole()
        {
            Console.WriteLine($"{_name}, {_position}");
        }
        public void MoveHorizontal(int distance)
        {
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
