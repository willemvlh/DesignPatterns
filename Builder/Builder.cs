using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    class MazeGame
    {
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            return builder.GetMaze();
        }
    }
    abstract class MazeBuilder
    {
        public abstract void BuildMaze();
        public abstract void BuildRoom(int room);
        public abstract void BuildDoor(int roomFrom, int roomTo);
        public abstract Maze GetMaze();
    }

    class FancyMazeBuilder : MazeBuilder
    {
        private Maze _maze;
        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Console.WriteLine($"Creating a fancy door between rooms {roomFrom} and {roomTo}");
            _maze.Doors.Add(new FancyDoor(roomFrom, roomTo));
        }

        public override void BuildMaze()
        {
            _maze = new Maze();
        }

        public override void BuildRoom(int room)
        {
            _maze.Rooms.Add(new FancyRoom(room));
        }

        public override Maze GetMaze()
        {
            return _maze;
        }
    }

    public class Maze
    {
        public IList<Door> Doors { get; } = new List<Door>();
        public IList<Room> Rooms { get; } = new List<Room>();
    }

    public class Room
    {
        public Room(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }

    public class FancyRoom : Room
    {
        public FancyRoom(int number) : base(number)
        {
        }
    }

    public class Door
    {
        private readonly int roomFrom;
        private readonly int roomTo;

        public Door(int roomFrom, int roomTo) {
            this.roomFrom = roomFrom;
            this.roomTo = roomTo;
        }
    }

    public class FancyDoor : Door
    {
        public FancyDoor(int roomFrom, int roomTo) : base(roomFrom, roomTo)
        {
        }
    }
}
