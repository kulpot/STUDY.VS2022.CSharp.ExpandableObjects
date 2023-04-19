using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpandableObjects
{
    [TypeConverter(typeof(VertexConverter))]
    class Vertex
    {
        [RefreshProperties(RefreshProperties.Repaint)]
        public int X { get; set; }
        [RefreshProperties(RefreshProperties.Repaint)]
        public int Y { get; set; }
        [RefreshProperties(RefreshProperties.Repaint)]
        public int Z { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", X, Y, Z);
        }
    }
        public class VertexConverter : ExpandableObjectConverter
        {

            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                //return sourceType == typeof(string);
                return true;
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                // 23, 34, 45
                // 23,34,45
                const string PATTERN = @"^(?<X>\d+),\s*(?<Y>\d+),\s*(?<Z>\d+)\s*$";
                Match match = Regex.Match(value.ToString(), PATTERN);

                if (match.Success)
                {
                    Vertex vertex = new Vertex();
                    vertex.X = int.Parse(match.Groups["X"].Value);
                    vertex.Y = int.Parse(match.Groups["Y"].Value);
                    vertex.Z = int.Parse(match.Groups["Z"].Value);
                    return vertex;
                }

                return base.ConvertFrom(context, culture, value);
            }
        }
}
