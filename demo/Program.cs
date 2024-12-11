namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Daclare Variables
            ////Variable => location in memory
            ////variable Declaration : datatype , size , name , value , address
            //int Number;  // allocats variableNmae 4 byte
            //Number = 5;

            //Console.WriteLine(Number); 
            #endregion


            #region Memory
            //CTS => common type system (.net نظام  موحد لجميع انواع اللغات داخل )
            //CLS => common language system (مجموعة قواعد تضمن توافق الكود بين اللغات المختلفة.)

            //Memory(Ram)
            //Stack : value datatype  , fixed size
            //Heap : Refrence datatype , dynamic size  
            #endregion


            #region Datatype
            //Datatype
            //1-Value datatype :Stuct(local variable , function ) and Unume (int , float)
            //2-Reference datatype : class (string - array - object - delegate) and interface and string 


            //double a = 2.5;
            //decimal b = 2.5m;
            //float c = 2.5f;

            //discard
            //int x = 1000_000_000;

            //Console.WriteLine(); => output Straem
            //Console.ReadLine(); => input Stream

            #endregion


            #region Bult in Datatype
            //Bult in Datatype Value (Struct)
            //-byte 1byte
            //-short 2byte
            //-int , float 4byte
            //-log , double 8byt
            //-decimal 16byte 
            //-char 2byte
            //-bool 1byte
            //-Datetime 16byte

            //Bult in Datatype Referencr (Class)
            //-string - array - object - delegate 
            #endregion


            #region BCL VS C# Keword
            //BCL VS C# Keword
            //Short => Int16
            //int => int32
            //Long => Int64
            //float => Single
            // Decimal => decimal
            // Byte => byte 
            #endregion


            #region Reference Type 
            //Reference Type 
         
            point p1;
            //=> p1 declare reference from type 'point' 
            //=> p1 can refer to object from 'point'
            //=> 8 byte will be allocated for a reference at stack
            //=> 0 byte will be allocated for a reference at heap
            p1 = new point();
            // 1. Allocate Required Bytes at Heap (8 + )
            // 2. Initialize (Cross Out) Allocated Bytes at heap with the defualt value at datatype
            // 3. Call User Defined Constructor If Exist
            // 4. Assign the Object To Reference (P1) 
            //Console.WriteLine(p1); //demo.point
            //Console.WriteLine(p1.x); //5
            //Console.WriteLine(p1.y); //6



            point p2 = new point();
            p2 = p1 ;
            p2.x = 10;
            //Console.WriteLine(p1.x); //5
            //Console.WriteLine(p2.x); //6 
            #endregion

            #region object
            //object => parent of all datatype

            //1.Generics
            //    Public Void Print(T item)
            //  {
            //    Console.writeline(item);
            //  }
            //    Print(int 5);
            //    Print(string 'menna');
            //    Print(char 'm');


            //2.object
            //    Public Void Print(object item)
            //  {
            //    Console.writeline(item);
            //  }
            //    Print(2);
            //    Print('menna');
            //    Print('m'); 
            #endregion


            #region object => EX
            object test;
            //declare for reference from type object 
            //test => can refer intance from type object or any type inherted from object
            test = new object();
            test = 1;
            test = 'm';
            test = "menna";
            test = new point();

            //Console.WriteLine(test); //demo.point


            point p3 = new point();
            //Console.WriteLine(p3.ToString()); //demo.point

            //p3 => inhert 
            //p3.GetType();
            //p3.GetHashCode(); //id : implicate for the address of the object  
            //p3.ToString();
            //p3.Equals();
            #endregion


            #region Value Types Casting

            //1. Casting=> convert any datatype to any datatype

            //Implicit Casting  => from int To (double or float)
            //int x = 5;
            //double y = x;
            //Console.WriteLine(y); // valid

            //int num = 10;
            //float f = num; // Implicit casting من int إلى float
            //Console.WriteLine(f); // valid


            //Explicit Casting => from (double or float) To int
            //double x = 2.5;
            //int y = (int)x;
            //Console.WriteLine(y);

            //float f = 10.5f;
            //int num = (int)f; // Explicit casting من float إلى int
            //Console.WriteLine(num);


            //2. Parse : convert string to integer
            //string strNum = "123";
            //int num = int.Parse(strNum); // تحويل النص إلى عدد صحيح
            //Console.WriteLine(num);

            //Console.WriteLine("enter your age");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter your GPA");
            //double gpa = double.Parse(Console.ReadLine());

            //Console.WriteLine("my age " + Age);
            //Console.WriteLine("my gpa " + gpa);


            //3. convert : convert any datatype to any datatype
            //Console.WriteLine("enter your age");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("my age " + Age);

            //string strNum = "123";
            //int num = Convert.ToInt32(strNum); // تحويل النص إلى عدد صحيح

            //object obj = 10.5;
            //double d = Convert.ToDouble(obj); // تحويل object إلى double

            //Console.WriteLine(num);
            //Console.  WriteLine(d);


            //4. tryparse =>  :  true or false   يتم رمي استثناء (FormatException) إذا كان النص غير صالح
            //EX-1)
            //Console.WriteLine("enter your age");
            //int Age;
            //bool flag = int.TryParse(Console.ReadLine() , out Age);

            //Console.WriteLine("my age " + Age);
            //Console.WriteLine("my flag " + flag);

            //EX-2)
            //string strNum = "abc";
            //if (int.TryParse(strNum, out int result))
            //{
            //    Console.WriteLine($"true  {result}");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //EX-3)
            //string strDecimal = "12.34";
            //if (double.TryParse(strDecimal, out double result))
            //{
            //    Console.WriteLine($" true : {result}");
            //}
            //else
            //{
            //    Console.WriteLine(" false!");
            //}


            //EX-4)
            //string strBool = "true";
            //if (bool.TryParse(strBool, out bool result))
            //{
            //    Console.WriteLine($" true: {result}");
            //}
            //else
            //{
            //    Console.WriteLine(" false!");
            //}



            #endregion


            #region Operators
            //Operators

            //Unary:  ++ , --
            //Binary: + , - , * , / ,%
            //Assignment:  = , += , -= , *= , /= , %/
            //Relational: == , != , >= , <= , > , <
            //Logical: ! , && , ||
            //Bitwise: | , & , ^ , << , >>
            //Ternary: =?:  condition ? trueExpression : falseExpression;


            #endregion


        }
    }
}
