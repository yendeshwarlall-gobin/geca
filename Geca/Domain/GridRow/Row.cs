namespace Geca.Domain;

public class Row
{
    public Row()
    {
        Entities = new Entity[30];
    }

    public Row(int size)
    {
        Entities = new Entity[size];
    }

    public void AddEntity(Entity entity, int position)
    {
        Entities[position] = entity;
    }

    public Entity[] Entities { get; set; }

    public void AddLands(int y)
    {
        for (int i = 0; i < Entities.Length; i++)
        {
            if (Entities[i] == null)
            {
                Entities[i] = new Land(y, i);
            }
        }
    }

    public string GetRowRepresentation()
    {
        var representation = "";

        foreach (var entity in Entities)
        {
            representation += entity.Legend;
        }

        return representation;
    }

    public void Reverse()
    {
        var reversedArray = Entities.Reverse().ToArray();

        for (int i = 0; i < reversedArray.Length; i++)
        {
            if (reversedArray[i].Coordinates.X != i)
            {
                reversedArray[i].Coordinates.X = i;
            }
        }

        Entities = reversedArray;
    }
}