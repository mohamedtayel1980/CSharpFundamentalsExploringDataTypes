namespace C_FundamentalsExploringDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region byte&sbyte
            byte positiveValue = 200;  // Valid 0-255
            //byte negativeValue = -1; // Invalid, causes error

            Console.WriteLine("Using byte:");
            Console.WriteLine($"Positive Value: {positiveValue}");

            // Trying to exceed the maximum range
            //byte overflowValue = 300; // Invalid, causes compile-time error

            sbyte positiveValue1 = 100;  // Valid -> -128 to  127
            sbyte negativeValue1 = -50;  // Valid

            Console.WriteLine("Using sbyte:");
            Console.WriteLine($"Positive Value: {positiveValue}");
            Console.WriteLine($"Negative Value: {negativeValue1}");

            // Trying to exceed the maximum range
             //sbyte overflowValue1 = 130; // Invalid, causes compile-time error
            #endregion
            
            #region short &ushort 
            // Declaring a short variable
            short temperature = -20;  // Valid, within range
            Console.WriteLine("Using short:");
            Console.WriteLine($"Temperature: {temperature}");

            // Trying to exceed the range
          //short overflowValue = 40000; // Invalid, causes compile-time error

            // Declaring a ushort variable
            ushort distance = 50000;  // Valid, within range
            Console.WriteLine("Using ushort:");
            Console.WriteLine($"Distance: {distance}");

            // Trying to assign a negative value
           //ushort negativeValue = -1; // Invalid, causes compile-time error
            #endregion

            #region int&uint
            int balance = -1500;  // Valid, within range
            Console.WriteLine("Using int:");
            Console.WriteLine($"Account Balance: {balance}");

            // int overflowValue = 3000000000; // Invalid, causes compile-time error

            // Declaring a uint variable
            uint fileSize = 3000000000;  // Valid, within range
            Console.WriteLine("Using uint:");
            Console.WriteLine($"File Size: {fileSize} bytes");

            // Trying to assign a negative value
            // uint negativeValue = -1; // Invalid, causes compile-time error
            #endregion

            #region long&ulong
            // Declaring a long variable
            long worldPopulation = 7800000000;  // Valid, within range
            long lBalance = -5000000000;         // Negative value
            Console.WriteLine("Using long:");
            Console.WriteLine($"World Population: {worldPopulation}");
            Console.WriteLine($"Account Balance: {lBalance}");

            // Trying to exceed the maximum range
            // long overflowValue = 10000000000000000000; // Invalid, causes compile-time error

            // Declaring a ulong variable
            ulong distanceToStar = 9460730472580800; // Distance in meters (light-years)
            Console.WriteLine("Using ulong:");
            Console.WriteLine($"Distance to Star: {distanceToStar} meters");

            // Trying to assign a negative value
            // ulong negativeValue = -1; // Invalid, causes compile-time error
            #endregion

            #region Double&Decimal&Float
            UseDouble();
            UseDecimal();
            UseFloat();
            #endregion

            #region Object
            // Storing an integer in an object
            object intObject = 123;
            Console.WriteLine($"Object holding int: {intObject}");
            Console.WriteLine($"Object holding int: {intObject.GetType()}");
            var intObject1= 224;;
             
            Console.WriteLine($"var is : {intObject1}");
            Console.WriteLine($"var is type of : {intObject1.GetType()}");
            // Storing a string in an object
            object stringObject = "Hello, world!";
            Console.WriteLine($"Object holding string: {stringObject}");
            Console.WriteLine($"Object holding string: {stringObject.GetType()}");

            // Storing a double in an object
            object doubleObject = 45.67;
            Console.WriteLine($"Object holding double: {doubleObject}");
            Console.WriteLine($"Object holding double: {doubleObject.GetType()}");
            // Casting object back to int
            int intValue = (int)intObject;  // Explicit casting is required
            Console.WriteLine($"Casted int from intValue is : {intValue}");

            // Casting object back to string
            string stringValue = (string)stringObject;  // Explicit casting
            Console.WriteLine($"Casted string: {stringValue}");

            // Casting object back to double
            double doubleValue = (double)doubleObject;  // Explicit casting
            Console.WriteLine($"Casted double: {doubleValue}");
            #endregion
        }

        static void UseDouble()
        {
            double sumDouble = 0;
            for (int i = 0; i < 10; i++)
            {
                sumDouble += 0.1;
            }
            Console.WriteLine($"Using double: {sumDouble}"); // Output: 0.9999999999999999

        }
        static void UseDecimal()
        {
            decimal sumDecimal = 0;
            for (int i = 0; i < 10; i++)
            {
                sumDecimal += 0.1m;
            }
            Console.WriteLine($"Using decimal: {sumDecimal}"); // Output: 1.0

        }
        static void UseFloat()
        {
            float sumFloat = 0;
            for (int i = 0; i < 10; i++)
            {
                sumFloat += 0.1f;
            }
            Console.WriteLine($"Using float: {sumFloat}"); // Output: 1.0000001

        }
    }
}
