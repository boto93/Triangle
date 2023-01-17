namespace Triangle
{
    public enum TriangleType
    {
        Isosceles,
        Equilateral,
        NoneOfThese
    }
    internal class Triangle
    {
        public List<Edge> Edges { get; set; }

        public Triangle(int a, int b, int c)
        {
            this.Edges = new List<Edge> {
                new Edge{Index=0, Lenght=a },
                new Edge{Index=1, Lenght=b },
                new Edge{Index=2, Lenght=c },
                };
        }

        public TriangleType GetTriangleType()
        {
            var isValid = this.Edges.All(x => x.Lenght < this.Edges.Where(y => y.Index != x.Index).Sum(y => y.Lenght));

            if (!isValid)
            {
                return TriangleType.NoneOfThese;
            }

            var groups = this.Edges.GroupBy(x => x.Lenght);

            switch (groups.Count())
            {
                case 1:
                    return TriangleType.Equilateral;
                case 2:
                    return TriangleType.Isosceles;
                default:
                    return TriangleType.NoneOfThese;
            }
        }
    }
}
