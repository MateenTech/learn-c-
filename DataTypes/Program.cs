// See https://aka.ms/new-console-template for more information

// Literal String data of type 'string' inside double quotation ("") mark;
Console.WriteLine("\t'string' data type:");
Console.Write("Hi i am literal string inside double quotes!");
Console.WriteLine('\n');

// Character Literal data of type 'char' referred as character (single alphanumeric)
// and is used inside single quotes ('');
Console.WriteLine("'char' data type referred as character:");
Console.Write('M');
Console.Write('a');
Console.Write('t');
Console.Write('e');
Console.Write('e');
Console.Write('n');
Console.WriteLine("");


// 'int' data type short for integer numeric whole numbers (non fraction);
Console.WriteLine("\n'int' data type:");
Console.WriteLine(456);
Console.Write(2+2);


// Floating-point literal are type of data containing decimal number;
// types: float, double, decimal

/*
    Each type has there own precisions

    Float point     |       precision
--------------------|----------------------
    float           |      ~6-9 digits
    double          |      ~15-17 digist
    decimal         |      28-29 digits

 */

Console.WriteLine("\n'Floating-point' literals:");
Console.Write("float: ");
Console.WriteLine(58.20F); // the F is called literal suffix
Console.Write("double: ");
Console.WriteLine(56.568);
Console.WriteLine("decimal: ");
Console.WriteLine(583.0558M); // THE M is called literal suffix of decimal values


Console.WriteLine("\t Boolean 'bool' data type (true/false): ");
Console.WriteLine(true);
Console.WriteLine(false);