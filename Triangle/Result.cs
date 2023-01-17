namespace Triangle
{
    public class Result
    {
        public const string ISOSCELES = "Isosceles";
        public const string EQUILATERAL = "Equilateral";
        public const string NONE_OF_THESE = "None Of These";
       
        /*
         * Complete the 'triangleType' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts STRING_ARRAY triangleToy as parameter.
         */

        public static List<string> triangleType(List<string> triangleToy)
        {
            var ret = new List<string>();
            foreach (var t in triangleToy)
            {
                var edges = t.Split(' ');
                var triangle = new Triangle(int.Parse(edges[0]), int.Parse(edges[1]), int.Parse(edges[2]));
                var triangleType = triangle.GetTriangleType();

                switch (triangleType)
                {
                    case TriangleType.Equilateral:
                        ret.Add(EQUILATERAL);
                        break;
                    case TriangleType.Isosceles:
                        ret.Add(ISOSCELES);
                        break;
                    case TriangleType.NoneOfThese:
                        ret.Add(NONE_OF_THESE);
                        break;
                }
            }
            return ret;
        }
    }
}
