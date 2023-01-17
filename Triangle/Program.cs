using Triangle;

int number = 0;
do
{
    var numStr = Console.ReadLine();    
    int.TryParse(numStr, out number);  
    if (number <= 0)
    {
        Console.WriteLine("Inserire valore numerico positivo");
    }
}while (number <= 0);

var triangles = new List<string>();
for (int i = 0; i < number; i++)
{
    var valid = false;
    do
    {
        try
        {
            var line = Console.ReadLine();
            int temp;
            var tokens = line.Split(" ");

            if (tokens.Length < 1 || !int.TryParse(tokens[0], out temp))
            {
                throw new Exception("primo parametro non numerico");
            }
            if (tokens.Length < 2 || !int.TryParse(tokens[1], out temp))
            {
                throw new Exception("secondo parametro non numerico");
            }
            if (tokens.Length < 3 || !int.TryParse(tokens[2], out temp))
            {
                throw new Exception("terzo parametro non numerico");
            }

            triangles.Add(line);
            valid = true;
        }
        catch (Exception ec)
        {
            valid = false;
            Console.WriteLine($"Input invalido {ec.Message}, riprovare");
        }
    } while (!valid);
}

var output = Result.triangleType(triangles);    

foreach (var tri in output)
{
    Console.WriteLine(tri);
}