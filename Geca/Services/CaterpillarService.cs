using Geca.Domain;
using Geca.Domain.Grids;

namespace Geca.Services;

public class CaterpillarService
{
    private readonly GridService _gridService;
    private readonly LoggingService _loggingService;
    private readonly CommandValidator _commandValidator;
    private readonly RadarService _radarService;
    public CaterpillarService()
    {
        _gridService = new GridService();
        _loggingService = new LoggingService();
        _commandValidator = new CommandValidator();
        _radarService = new RadarService();
    }
    
    public Result ProcessCommand(Request request)
    {
         var commands = request.Command.Split(' ');
         var direction = commands[0].ToLower();
         var meters = int.Parse(commands[1]);
         switch (direction)
         {
             case "u":
                 return MoveHeadUp(meters, request);
             case "d":
                 return MoveHeadDown(meters, request);
             case "l":
                 return MoveHeadLeft(meters,request);
             case "r":
                 return MoveHeadRight(meters,request);
         }
         
         throw new ArgumentException("Invalid direction");
    }

    private Result MoveHeadUp(int meters, Request request)
    {
        var caterpillar = request.Caterpillar;
        var headYCoordinates = caterpillar.Head.Coordinates.Y;
        var headXCoordinates = caterpillar.Head.Coordinates.X;
        var grid = request.Grid;
        var newHeadYCoordinates = headYCoordinates + meters;
        for (int i = headYCoordinates; i <= (newHeadYCoordinates); i++)
        {
            if (i > 29)
            {
                return MoveToNextGrid(request.GridStartPosition, Direction.Up);
            }

            if (grid.Rows[i].Entities[headXCoordinates] is Spice)
            {
                grid.Rows[i].Entities[headXCoordinates] = new Land(i, headXCoordinates);
            }

            if (grid.Rows[i].Entities[headXCoordinates] is Obstacle)
            {
                grid.Rows[i].Entities[headXCoordinates] = new Land(i, headXCoordinates);
                return ObstacleEncountered();
            }

            if (grid.Rows[i].Entities[headXCoordinates] is Booster)
            {
                caterpillar = BoosterEncountered(caterpillar);
            }

            caterpillar.Head.Coordinates.Y = i;
            caterpillar = MoveTail(caterpillar, Direction.Up);
            caterpillar = MoveIntermediateSegments(caterpillar);
            _radarService.GetRadarGridFromCurrentGrid(caterpillar, grid).PrintGrid();
        }
        
        return new Result
        {
            Grid = grid,
            Caterpillar = caterpillar,
            StartPosition = request.GridStartPosition
        };
    }


    private Result MoveHeadDown(int meters, Request request)
    {
        var caterpillar = request.Caterpillar;
        var headYCoordinates = caterpillar.Head.Coordinates.Y;
        var headXCoordinates = caterpillar.Head.Coordinates.X;
        var grid = request.Grid;
        var newHeadYCoordinates = headYCoordinates - meters;
        for (int i = headYCoordinates; i >= (newHeadYCoordinates); i--)
        {
            if (i < 0)
            {
                return MoveToNextGrid(request.GridStartPosition, Direction.Down);
            }

            if (grid.Rows[i].Entities[headXCoordinates] is Spice)
            {
                grid.Rows[i].Entities[headXCoordinates] = new Land(i, headXCoordinates);
            }

            if (grid.Rows[i].Entities[headXCoordinates] is Obstacle)
            {
                return ObstacleEncountered();
            }

            if (grid.Rows[i].Entities[headXCoordinates] is Booster)
            {
                grid.Rows[i].Entities[headXCoordinates] = new Land(i, headXCoordinates);
                caterpillar = BoosterEncountered(caterpillar);
            }

            caterpillar.Head.Coordinates.Y = i;
            caterpillar = MoveTail(caterpillar, Direction.Down);
            caterpillar = MoveIntermediateSegments(caterpillar);
            _radarService.GetRadarGridFromCurrentGrid(caterpillar, grid).PrintGrid();
        }
        
        return new Result
        {
            Grid = grid,
            Caterpillar = caterpillar,
            StartPosition = request.GridStartPosition
        };
    }

    private Result MoveHeadLeft(int meters, Request request)
    {
        var caterpillar = request.Caterpillar;
        var headYCoordinates = caterpillar.Head.Coordinates.Y;
        var headXCoordinates = caterpillar.Head.Coordinates.X;
        var grid = request.Grid;
        var newHeadXCoordinates = headXCoordinates - meters;
        for (int i = headXCoordinates; i >= (newHeadXCoordinates); i--)
        {
            if (i < 0)
            {
                return MoveToNextGrid(request.GridStartPosition, Direction.Left);
            }

            if (grid.Rows[headYCoordinates].Entities[i] is Spice)
            {
                grid.Rows[headYCoordinates].Entities[i] = new Land(headYCoordinates, i);
            }

            if (grid.Rows[headYCoordinates].Entities[i] is Obstacle)
            {
                return ObstacleEncountered();
            }

            if (grid.Rows[headYCoordinates].Entities[i] is Booster)
            {
                grid.Rows[headYCoordinates].Entities[i] = new Land(headYCoordinates, i);
                caterpillar = BoosterEncountered(caterpillar);
            }

            caterpillar.Head.Coordinates.X = i;
            caterpillar = MoveTail(caterpillar, Direction.Left);
            caterpillar = MoveIntermediateSegments(caterpillar);
            _radarService.GetRadarGridFromCurrentGrid(caterpillar, grid).PrintGrid();
        }
        
        return new Result
        {
            Grid = grid,
            Caterpillar = caterpillar,
            StartPosition = request.GridStartPosition
        };
    }

    private Result MoveHeadRight(int meters, Request request)
    {
        var caterpillar = request.Caterpillar;
        var headYCoordinates = caterpillar.Head.Coordinates.Y;
        var headXCoordinates = caterpillar.Head.Coordinates.X;
        var grid = request.Grid;
        var newHeadXCoordinates = headXCoordinates + meters;
        for (int i = headXCoordinates; i <= (newHeadXCoordinates); i++)
        {
            if (i > 29)
            {
                return MoveToNextGrid(request.GridStartPosition, Direction.Right);
            }

            if (grid.Rows[headYCoordinates].Entities[i] is Spice)
            {
                grid.Rows[headYCoordinates].Entities[i] = new Land(headYCoordinates, i);
            }

            if (grid.Rows[headYCoordinates].Entities[i] is Obstacle)
            {
                return ObstacleEncountered();
            }

            if (grid.Rows[headYCoordinates].Entities[i] is Booster)
            {
                grid.Rows[headYCoordinates].Entities[i] = new Land(headYCoordinates, i);
                caterpillar = BoosterEncountered(caterpillar);
            }

            caterpillar.Head.Coordinates.X = i;
            caterpillar = MoveTail(caterpillar, Direction.Right);
            caterpillar = MoveIntermediateSegments(caterpillar);
            _radarService.GetRadarGridFromCurrentGrid(caterpillar, grid).PrintGrid();
        }
        
        return new Result
        {
            Grid = grid,
            Caterpillar = caterpillar,
            StartPosition = request.GridStartPosition
        };
    }

    private Result ObstacleEncountered()
    {
        var message = "Obstacle encountered, Restarting at starting position on the initial starting grid";
        _loggingService.LogCommand(message);
        Console.WriteLine(message);
        return new Result
        {
            Grid = new StartingGrid(),
            Caterpillar = new Caterpillar
            {
                Head = new Head(0, 0),
                Tail = new Tail(0, 0)
            },
            StartPosition = new StartPosition(0, 0)
        };
    }

    private Result MoveToNextGrid(StartPosition oldStartPosition, Direction direction)
    {
        var (newGrid, newStartPosition) = _gridService.GetNextGrid(oldStartPosition, direction);
        return new Result
        {
            Grid = newGrid,
            StartPosition = newStartPosition,
            Caterpillar = new Caterpillar
            {
                Head = new Head(newStartPosition.Coordinates.Y, newStartPosition.Coordinates.X),
                Tail = new Tail(newStartPosition.Coordinates.Y, newStartPosition.Coordinates.X)
            }
        };
    }

    private Caterpillar MoveIntermediateSegments(Caterpillar caterpillar)
    {
        var newSegmentList = new List<IntermediateSegment>(3);
        foreach (var intermediateSegment in caterpillar.Segments)
        {
            var intSeg = new IntermediateSegment(caterpillar.Tail.Coordinates.Y, intermediateSegment.Coordinates.X);
            newSegmentList.Add(intSeg);
        }
        
        caterpillar.Segments = newSegmentList;
        return caterpillar;
    }
    
    private Caterpillar MoveTail(Caterpillar caterpillar, Direction direction)
    {
        var head = caterpillar.Head;
        var tail = caterpillar.Tail;

        //Same x-axis but different y-axis
        if (head.Coordinates.X == tail.Coordinates.X
            && head.Coordinates.Y != tail.Coordinates.Y
            && Math.Abs(head.Coordinates.Y - tail.Coordinates.Y) > 1)
        {
            var difference = head.Coordinates.Y - tail.Coordinates.Y;
            if (difference < 0)
            {
                tail.Coordinates.Y -= 1;
            }
            else
            {
                tail.Coordinates.Y += 1;
            }
        }

        //same y-axis but different y-axis
        if (head.Coordinates.Y == tail.Coordinates.Y
            && head.Coordinates.X != tail.Coordinates.X
            && Math.Abs(head.Coordinates.X - tail.Coordinates.X) > 1)
        {
            var difference = head.Coordinates.X - tail.Coordinates.X;
            if (difference < 0)
            {
                tail.Coordinates.X -= 1;
            }
            else
            {
                tail.Coordinates.X += 1;
            }
        }

        //different x-axis and y-axis 
        if (
            head.Coordinates.X != tail.Coordinates.X
            && head.Coordinates.Y != tail.Coordinates.Y
            && (
                Math.Abs(head.Coordinates.Y - tail.Coordinates.Y) > 1
                || Math.Abs(head.Coordinates.X - tail.Coordinates.X) > 1
            )
        )
        {
            if (direction == Direction.Up)
            {
                tail.Coordinates.Y = head.Coordinates.Y - 1;
                tail.Coordinates.X = head.Coordinates.X;
            }
            
            if (direction == Direction.Right)
            {
                tail.Coordinates.Y = head.Coordinates.Y;
                tail.Coordinates.X = head.Coordinates.X - 1;
            }
            
            if (direction == Direction.Left)
            {
                tail.Coordinates.Y = head.Coordinates.Y;
                tail.Coordinates.X = head.Coordinates.X + 1;
            }
            
            if (direction == Direction.Down)
            {
                tail.Coordinates.Y = head.Coordinates.Y + 1;
                tail.Coordinates.X = head.Coordinates.X;
            }
        }

        return new Caterpillar
        {
            Head = head,
            Tail = tail
        };

    }

    private Caterpillar BoosterEncountered(Caterpillar caterpillar)
    {
        Console.WriteLine("Booster encountered");
        Console.WriteLine("Please enter 'Grow' OR 'Shrink' command");
        var command = Console.ReadLine();
        var message = "";
        if (!_commandValidator.IsValidLinearGrowthCommand(command))
        {
            message = "Booster lost due to invalid command";
            _loggingService.LogCommand(message);
            Console.WriteLine(message);
            return caterpillar;
        }

        var numSegments = caterpillar.Segments.Count;

        if (command.ToLower().Trim().Equals("grow"))
        {
            if (numSegments == 3)
            {
                message = "Maximum number of intermediate segments for caterpillar reached";
                _loggingService.LogCommand(message);
                Console.WriteLine(message);
            }
            
            var intermediateSegments = new IntermediateSegment(caterpillar.Tail.Coordinates.Y, caterpillar.Tail.Coordinates.X);
            caterpillar.Segments.Add(intermediateSegments);
        }

        if (command.ToLower().Trim().Equals("shrink"))
        {
            if (numSegments == 0)
            {
                message = "Caterpillar has no intermediate segments to shrink";
                _loggingService.LogCommand(message);
                Console.WriteLine(message);
            }

            caterpillar.Segments.Remove(caterpillar.Segments.First());
        }

        return caterpillar;
    }

    // private Grid MoveCaterpillar(string command, Grid grid, Caterpillar caterpillar)
    // {
    //     
    // }
}