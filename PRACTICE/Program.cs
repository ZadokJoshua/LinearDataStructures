
using CSharpAlgorithms;
using System.Text;


/*
// Challenge one testing
var stringsChallenge = new AlgorithmChanllenges();
Console.WriteLine(stringsChallenge.ReverseEachWord("What can I do today"));
Console.WriteLine(stringsChallenge.ReverseEachWord(" "));
Console.WriteLine(stringsChallenge.ReverseEachWord("I love Jesus"));
*/

/*
// Binary Search testing and arry rotation
var binaryExample = new AlgorithmChanllenges();
var arr = new int[] { 1, 2, 3 };
Console.WriteLine(binaryExample.BinarySearch(arr, 5));
*/

/*
// Challenge two Rotate Array
var arr = new int[] { 1, 2, 3, 4, 5, 6 };
var binaryExample = new AlgorithmChanllenges();
binaryExample.RotateArray(arr);
foreach (var i in arr)
{
    Console.Write(i + " ");
} 
*/


// LinkedList Class Testing
var demoLinkedlist = new LinkedListAlgorithms<string>();

demoLinkedlist.Print();
demoLinkedlist.AddNodeToFirst("Zadok");
demoLinkedlist.AddNodeToFirst("Joshua");
demoLinkedlist.AddNodeToLast("Sam");
demoLinkedlist.AddNodeToFirst("Edem");
demoLinkedlist.AddNodeToFirst("Dave");
demoLinkedlist.Print();
demoLinkedlist.RemoveNodeInList("Edem");
demoLinkedlist.Print();







