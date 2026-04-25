using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

var horizontalLine = new string('-', count: 129);

WriteLine(horizontalLine);
WriteLine($"|{"Type",-7}|{"Byte(s) of memory",-3}|{"Min",50}|{"Max",50}|");
WriteLine(horizontalLine);
WriteLine($"|{"sbyte",-7} {sizeof(sbyte),-3} {sbyte.MinValue,65:D} {sbyte.MaxValue,50:D}");
WriteLine($"|{"byte",-7} {sizeof(byte),-3} {byte.MinValue,65:D} {byte.MaxValue,50:D}");
WriteLine($"|{"short",-7} {sizeof(short),-3} {short.MinValue,65:D} {short.MaxValue,50:D}");
WriteLine($"|{"ushort",-7} {sizeof(ushort),-3} {ushort.MinValue,65:D} {ushort.MaxValue,50:D}");
WriteLine($"|{"int",-7} {sizeof(int),-3} {int.MinValue,65:D} {int.MaxValue,50:D}");
WriteLine($"|{"uint",-7} {sizeof(uint),-3} {uint.MinValue,65:D} {uint.MaxValue,50:D}");
WriteLine($"|{"long",-7} {sizeof(long),-3} {long.MinValue,65:D} {long.MaxValue,50:D}");
WriteLine($"|{"ulong",-7} {sizeof(ulong),-3} {ulong.MinValue,65:D} {ulong.MaxValue,50:D}");
unsafe
{
    WriteLine($"|{"Int128",-7} {sizeof(Int128),-3} {Int128.MinValue,65:D} {Int128.MaxValue,50:D}");
    WriteLine($"|{"UInt128",-7} {sizeof(UInt128),-3} {UInt128.MinValue,65:D} {UInt128.MaxValue,50:D}");
    WriteLine($"|{"Half",-7} {sizeof(Half),-3} {Half.MinValue,65} {Half.MaxValue,50}");
}
WriteLine($"|{"float",-7} {sizeof(float),-3} {float.MinValue,65:E7} {float.MaxValue,50:E7}");
WriteLine($"|{"double",-7} {sizeof(double),-3} {double.MinValue,65:E16} {double.MaxValue,50:E16}");
WriteLine($"|{"decimal",-7} {sizeof(decimal),-3} {decimal.MinValue,65} {decimal.MaxValue,50}");