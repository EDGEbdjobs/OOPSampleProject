// See https://aka.ms/new-console-template for more information

using InheritanceExamples;


//CalcMethod addMethod = Add;
//CalcMethod multiply = Multiply;

//var multiplyResult = multiply(4, 3);

//FUNC -- Methods which has return Type. 
//ACTION -- Methods which doesn't have return type.

//Func<int, int> squareMethod = delegate (int x) { return x * x; };

//Func<int,int,int>addMethod = delegate(int x, int y) { return x + y; };


//Func<int, int> squareMethod =  (int x) => { 
//                                              int result = x * x; 
//                                                return result;   
//                                           };

Func<int, int> squareMethod = x => x*x;

Func<int, int, int> addMethod =  (x,y) => x+y;

Action emptyMethod = () => { };

Action<string> printMethod = (message) => { Console.Write(message); };





Console.WriteLine(squareMethod(8));

//int Add(int x, int y)
//{
//    return x + y;
//}

//int Multiply(int x, int y)
//{
//    return x * y;
//}

//delegate int CalcMethod(int x, int y);
