using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection coll = new int[] { 6, 7, 8, 9 };

            ArrayList arr = new ArrayList();

            arr.Add(5); //boxing is happening
            arr.AddRange(coll);
            arr.Insert(0, 4);
            Console.WriteLine("Element fof Array");
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Capavcity :{0}", arr.Capacity);
            ArrayList objClone = (ArrayList)arr.Clone();  //Creates a shallow copy of object
            Console.WriteLine("After Cloni9ng");
            foreach (var v in objClone)
            {
                Console.WriteLine(v);
            }


            Console.WriteLine("It contains after using contains : {0}", arr.Contains(5));


            Console.WriteLine("It counts : {0}", arr.Count);

            Console.WriteLine("Index of arr elemnet : {0}", arr.IndexOf(7));

            Console.WriteLine("Inserting an elemnt in arr : ");
            arr.Insert(2, 5);

            Console.WriteLine("Removing an element of arr : ");
            arr.Remove(6);


            arr.InsertRange(1, new int[] { 12, 99, 98, 97, 34, 4 });
            foreach (var z in arr)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("remove range");
            arr.RemoveRange(2, 3);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------------------------");
            arr.GetRange(2, 5);





            Array a1 = new int[arr.Count];
            Console.WriteLine("copying element");
            arr.CopyTo(a1);
            foreach (var v in a1)
            {
                Console.WriteLine(v);
            }


            Console.WriteLine("=======================");
            Console.WriteLine("Viewing the contents of the Arraylist using GetEnumerator......");
            IEnumerator en = arr.GetEnumerator();

            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }

            ArrayList myList = new ArrayList();
            myList.Add(23);
            myList.Add(45);
            myList.Add(12);
            myList.Add(5);
            myList.Add(43);
            myList.Add(78);

            foreach (int res in myList)
            {
                Console.WriteLine(res);
            }

            ArrayList newArr = new ArrayList();
            newArr.Add(45);
            newArr.Add("hello");
            newArr.Add('s');
            newArr.Add(3444.45);
            newArr.Add(true);
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
            //newArr.Sort();//runtime error


            Console.WriteLine("Using a generic Collection List Similar to ArrayList");

            List<int> list = new List<int>();
            list.Add(56);
            list.Add(21);
            list.Add(7);
            list.Add(14);
            list.Add(21);
            list.Add(28);
            list.Add(35);
            int findRes = list.Find(x => x.Equals(21));
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            List<string> slist = new List<string>();
            Console.WriteLine("Finding 21 in the list:{0} ", findRes);
            slist.Add("break now?");

            //slist.


            Console.Read();
        }
    }
}