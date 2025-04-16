// See https://aka.ms/new-console-template for more information

using Geca.Domain;
using Geca.Domain.Grids;
using Geca.Services;

var commandValidator = new CommandValidator();
var loggingService = new LoggingService();
var startingPoint = new StartPosition(0, 0);
var caterpillar = new Caterpillar
{
    Head = new Head(0, 0), Tail = new Tail(0, 0)
};

Grid currentGrid = new StartingGrid();
var radarService = new RadarService();
var caterpillarService = new CaterpillarService();    

radarService.GetRadarGridFromCurrentGrid(caterpillar, currentGrid).PrintGrid();
while (true)
{
    
    Console.WriteLine("Please enter command:");
    var command = Console.ReadLine();
    loggingService.LogCommand(command);

    if (!commandValidator.IsValidMovementCommand(command))
    {
        continue;
    }

    var request = new Request
    {
        Caterpillar = caterpillar,
        Command = command,
        Grid = currentGrid,
        GridStartPosition = startingPoint
    };
    var result = caterpillarService.ProcessCommand(request);
    if (startingPoint.Coordinates != result.StartPosition.Coordinates)
    {
        caterpillar = result.Caterpillar;
        currentGrid = result.Grid;
        startingPoint = result.StartPosition;
        radarService.GetRadarGridFromCurrentGrid(caterpillar, currentGrid).PrintGrid();
    }

}
