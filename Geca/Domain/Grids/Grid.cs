namespace Geca.Domain.Grids;

public class Grid
{
    public Grid()
    {
        Rows = new Row[30];
    }

    public Grid(int size)
    {
        Rows = new Row[size];
    }

    public void AddRow(Row row, int position)
    {
        Rows[position] = row;
    }

    public void ReverseYAxis()
    {
        var reversedArray = Rows.Reverse().ToArray();

        for (int i = 0; i < reversedArray.Length; i++)
        {
            var row = reversedArray[i];
            foreach (var entity in row.Entities)
            {
                entity.Coordinates.Y = i;
            }
            reversedArray[i] = row;
        }

        Rows = reversedArray;
    }
    
    public void ReverseXAxis()
    {
        foreach (var row in Rows)
        {
             row.Reverse();
        }
    }

    public void ReverseXAndYAxis()
    {
        ReverseXAxis();
        ReverseYAxis();
    }

    public Row[] Rows { get; set; }

    public void PrintGrid()
    {
        var gridSize = Rows.Length - 1;
        for (int i = gridSize; i >= 0; i--)
        {
            Console.WriteLine(Rows[i].GetRowRepresentation());
        }
        Console.WriteLine("-----------------------");
    }
}