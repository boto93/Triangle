

using Triangle;

var num = int.Parse( Console.ReadLine());
var triangles = new List<string>();
for (int i = 0; i < num; i++)
{
    triangles.Add(Console.ReadLine());

}
var output = Result.triangleType(triangles);    

foreach (var tri in output)
{
    Console.WriteLine(tri);
}
