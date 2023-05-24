// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Array is collection of values with similar datatype otherwise as element.
// its a datastructure of reference type, it is nullable at the time of declation.
//this becos memory for the element is yet to be allocated. it is declared with any datatype
//and all it element will be of that datatype

//Declaration of Array
//int[] array; the variable name is stored in stack and the memory is null in the heap

//Creation of Array
//int[] array = new int[5]; the new keyword is for memory allocation, 
//and the heap is initialised to zero the value or element of an array are stored in the heap

//int[] ar = new int [5];

//checking the initialised value
// foreach(var item in ar)
// {
//   Console.WriteLine(item);
// }

//Manual assignment value
// ar[0] = 1;
// ar[1] = 2;
// ar[2] = 3;
// ar[3] = 4;
// ar[4] = 5;

//Assign value with loop
// for(int i = 0; i < ar.Length; i ++)
// {
//   Console.WriteLine("enter your number");
//   int n = int.Parse(Console.ReadLine());
//   ar[i] = n;
// }
// foreach(var item in ar)
// {
//   Console.WriteLine(item);
// }

//Array access
//it is accessed by referencing the element index inside the square bracket. 
//The index starts from zero, each element can be accessed through the 
//name of the array and the element index placed in the square bracket. array element can be 
//treated as variable.
//example: ar[index] = 100; a value of of 100 is set to the element at the 
//position of index

//manually accessing single dimensional array
// Console.WriteLine(ar[0]);
// Console.WriteLine(ar[1]);
// Console.WriteLine(ar[2]);
// Console.WriteLine(ar[3]);

//Using forloop accessing single dimensional array
// for(int i = 0; i < ar.Length; i++)
// {
//   Console.WriteLine(ar[i]);
// }

//alternatively using for each
// foreach(var item in ar)
// {
//   Console.WriteLine(item);
// }

//Array initialization
//Array values can be set explicitly
// int[] array = new int [] {1,2,3,4,5};
// int[] arra =  {1,2,3,4,5};

//Multidimensional Array (matrice array)
//it is rectangular in appearance, same lenght of all sub array and 
//the dimension is seperated using comma.

// int[] onedimensionalarray;
// int[,] twodimensionalarray;
// int[,,] threedimensionalarray;

//note: no limit to the dimension of an array but inpractice we do not use
//much arrays with more than two dimensions. two dimensional has equal length

//Declaration and allocation
// int[] onedimensionalarra = new int[1];
// int[,] twodimensionalarra = new int [2,3];
// int[,,] threedimensionalarra = new int [2,3,4];
//example: int[,] twodimensionalarra = new int [2,3];
//the above array is two dimensional array, it is 2×3 depicting two rows
//and three columns.

//Two dimensinal array initialisation
//int[,] two = {{1,2,3,4},{5,6,7,8}}; 
//2 rows and 4 columns, 2×4 array or matrix, the length is 4 and no of length is 2

//manual allocation value 
// two[0,0] =1; two[0,1] =2; two[0,2] =3; two[0,3] =4;
// two[1,0] =5; two[1,1] =6; two[1,2] =7; two[1,3] =8;

//using loop to allocate value
//Note: the GetLength() is used to get the lenght of the specified dimension

// int[,] td = new int[2,4];
// for(int i = 0; i < td.GetLength(0); i++)
// {
//   for(int j = 0; j < td.GetLength(1); j++)
//   {
//     Console.WriteLine("enter your number");
   
//     td[i,j] = int.Parse(Console.ReadLine());
//   }
// }

//Accessing the element of a multidimensional array
//int[,] twodm = {{1,2,3,4},{5,6,7,8}};

//Accessing manually
// Console.WriteLine(twodm[0,0]);
// Console.WriteLine(twodm[0,1]);
// Console.WriteLine(twodm[0,2]);
// Console.WriteLine(twodm[0,3]);

//Access using loop
// for(int i = 0; i < twodm.GetLength(0); i++ )
// {
//   for(int j = 0; j < twodm.GetLength(1); j++)
//   {
//      Console.WriteLine(td[i,j]);
//   }
// }

string[] name = {"tit", " tat", "at","asdfg "};

foreach(var item in name)
{
  if(item[0] == 'a')
  {
     Console.WriteLine(item);
  }
  if(item.StartsWith('a'))
  {
     Console.WriteLine(item);
  }
}