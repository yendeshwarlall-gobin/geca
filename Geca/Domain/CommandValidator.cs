namespace Geca.Domain;

public class CommandValidator
{
    public bool IsValidLinearGrowthCommand(string? command)
    {
        if (string.IsNullOrWhiteSpace(command))
        {
            return false;
        }

        if (command.ToLower().Trim().Equals("grow") || command.ToLower().Trim().Equals("shrink"))
        {
            return true;
        }

        return false;
    }


    public bool IsValidMovementCommand(string? command)
    {
        if (string.IsNullOrWhiteSpace(command))
        {
            return false;
        }

        var commands = command.Split(" ");

        if (commands.Length > 2)
        {
            return false;
        }

        if (commands.Length == 2)
        {
            if (commands[0].ToLower().Equals("u")
                || commands[0].ToLower().Equals("d")
                || commands[0].ToLower().Equals("l")
                || commands[0].ToLower().Equals("r")
               )
            {
                var isValidInt = int.TryParse(commands[1], out var meters);

                if (isValidInt && meters is > 0 and <= 5)
                {
                    return true;
                }
            }
        }

        return false;
    }
}