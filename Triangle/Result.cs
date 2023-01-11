using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Result
    {

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

                var obj = new Triangle(int.Parse(edges[0]), int.Parse(edges[1]), int.Parse(edges[2]));
                
                var type = obj.GetTriangleType();

                ret.Add(type.ToString());

            }
            return ret;

        }

    }

}
