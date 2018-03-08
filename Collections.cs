using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class A1
    {
        public int i;
        public string s;
        public A1(int i,string s)
        {
            this.i = i;
            this.s = s;
        }
    }
    class B1
    {
        public int i;
        public string s;
        public B1(int i,string s)
        {
            this.i = i;
            this.s = s;
        }
        public override int GetHashCode()
        {
            return this.i.GetHashCode()+this.s.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is B1))
            {
                return false;
            }
            else
            {
                return this.i == (obj as B1).i && this.s == (obj as B1).s;
                //return this.i == ((B1)obj).i && this.s==((B1)obj).s;
            }
        }
    }
    class C1:IComparable
    {
        public int i;
        public string s;
        public C1(int i,string s)
        {
            this.i = i;
            this.s = s;
        }

        public int CompareTo(object obj)
        {
            return this.i.CompareTo(((C1)obj).i);
        }
    }
    class D1
    {
        public int i;
        public string s;
        public D1(int i,string s)
        {
            this.i = i;
            this.s = s;
        }
    }
    class E1
    {
        public int i;
        public string s;
        public E1(int i,string s)
        {
            this.i = i;
            this.s = s;
        }

    }
    class Collections
    {
        public static void Hashtable()
        {
            Hashtable table = new Hashtable();
            table.Add(1, "sachin");
            table.Add(2, "ramu");
            table.Add(7, "ahiva");
            table.Add(8, "chandu");
            //table.Add(1, "jay");
            //table.Add(1, "sachin");
            //table.Add(2, "sachin");
            table.Add(4, "chetan");
            Console.WriteLine();
            Console.WriteLine("HashTable Program");

            IDictionaryEnumerator enu = table.GetEnumerator();
            Console.WriteLine("--------------------------");
            while(enu.MoveNext())
            {
                Console.WriteLine(enu.Key + " : " + enu.Value);
            }

            Console.WriteLine("--------------------------");

            foreach (DictionaryEntry tab in table)
            {
                Console.WriteLine(tab.Key+" : "+tab.Value);
            }
        }
        public static void ArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add("sachin");
            list.Add(25);
            list.Add("rajiv");
            list.Add("rajiv");
            list.Add(25.3);
            list.Add(26);
            list.Add(26);
            Console.WriteLine();
            Console.WriteLine("ArrayList Program");
            foreach (var lists in list)
            {
                Console.WriteLine(lists);
            }
        }
        public static void SortedList()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "ramu");
            //sl.Add(1, "shiva");
            sl.Add(8, "rajesh");
            sl.Add(4, "kirti");
            sl.Add(2, "janya");
            sl.Add(7, "prakash");
            //sl.Add(2, "ramu");
            //sl.Add(1, "ramu");
            Console.WriteLine();
            Console.WriteLine("SortedList Program");
            IEnumerator enu = sl.GetEnumerator();
            Console.WriteLine("=====================");
            while(enu.MoveNext())
            {
                Console.WriteLine((Object)enu.Current.ToString());
            }
            foreach(KeyValuePair<int,string> kv in sl)
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }
        }
        public static void SortedDictionary()
        {
            SortedDictionary<int, string> d1 = new SortedDictionary<int, string>();
            d1.Add(1, "ramu");
            //d1.Add(1, "shiva");
            d1.Add(3, "rajesh");
            d1.Add(4, "kirti");
            //d1.Add(2, "janya");
            d1.Add(7, "prakash");
            d1.Add(2, "ramu");
            //d1.Add(1, "ramu");

            Console.WriteLine();
            Console.WriteLine("SortedDirectory program");
            foreach(KeyValuePair<int,string> kv in d1)
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }
        }
        public static void Directory()
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(1, "ramu");
            //d1.Add(1, "shiva");
            d1.Add(3, "rajesh");
            d1.Add(4, "kirti");
            //d1.Add(2, "janya");
            d1.Add(7, "prakash");
            d1.Add(2, "ramu");
            //d1.Add(1, "ramu");
            Console.WriteLine();
            Console.WriteLine("Directory Program");

            foreach(KeyValuePair<int,string> kv in d1)
            {
                Console.WriteLine(kv.Key + " : " + kv.Value);
            }
        }
        public static void LinkedListObject()
        {
            LinkedList<E1> list = new LinkedList<E1>();
            list.AddLast(new E1(5, "ramu"));
            list.AddLast(new E1(8, "raju"));
            list.AddLast(new E1(6, "ravi"));
            list.AddFirst(new E1(3, "kiran"));
            list.AddFirst(new E1(5, "ramu"));
            list.AddLast(new E1(5, "kirthi"));
            list.AddFirst(new E1(1, "sanjay"));
            Console.WriteLine();
            Console.WriteLine("LinkedList with Object");
            foreach(E1 e in list)
            {
                Console.WriteLine(e.i+" : "+e.s);
            }
        }

        public static void LinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("shiva");
            list.AddLast("basu");
            list.AddLast("murali");
            list.AddLast("shiva");
            list.AddFirst("mallu");
            list.AddFirst("sanjay");
            list.AddLast("mallu");
            Console.WriteLine();
            Console.WriteLine("LinkedList without Object");
            foreach(string s1 in list)
            {
                Console.WriteLine(s1);
            }
        }
        public static void QueueObject()
        {
            Queue<E1> q1 = new Queue<E1>();
            q1.Enqueue(new E1(5, "ramu"));
            q1.Enqueue(new E1(8, "raju"));
            q1.Enqueue(new E1(6, "ravi"));
            q1.Enqueue(new E1(3, "kiran"));
            q1.Enqueue(new E1(5, "ramu"));
            q1.Enqueue(new E1(5, "kirthi"));
            q1.Enqueue(new E1(1, "sanjay"));
            Console.WriteLine();
            Console.WriteLine("Queue with Object");
            foreach(E1 e in q1)
            {
                Console.WriteLine(e.i+" : "+e.s);
            }
        }
        public static void Queue()
        {
            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("shiva");
            q1.Enqueue("basu");
            q1.Enqueue("murali");
            q1.Enqueue("shiva");
            q1.Enqueue("mallu");
            q1.Enqueue("sanjay");
            q1.Enqueue("mallu");
            Console.WriteLine();
            Console.WriteLine("Queue without Obejct");
            foreach(string q in q1)
            {
                Console.WriteLine(q);
            }
        }
        public static void StackObject()
        {
            Stack<D1> st = new Stack<D1>();
            st.Push(new D1(5, "ramu"));
            st.Push(new D1(8, "raju"));
            st.Push(new D1(6, "ravi"));
            st.Push(new D1(3, "kiran"));
            st.Push(new D1(5, "ramu"));
            st.Push(new D1(5, "kirthi"));
            st.Push(new D1(1, "sanjay"));
            Console.WriteLine();
            Console.WriteLine("Stack with Object");
            foreach (D1 d1 in st)
            {
                Console.WriteLine(d1.i + " : " + d1.s);
            }
        }
        public static void Stack()
        {
            Stack<string> s1 = new Stack<string>();
            s1.Push("shiva");
            s1.Push("basu");
            s1.Push("murali");
            s1.Push("shiva");
            s1.Push("mallu");
            s1.Push("sanjay");
            s1.Push("mallu");

            Console.WriteLine();
            Console.WriteLine("Stack without Object");

            foreach(string s in s1)
            {
                Console.WriteLine(s);
            }
        }
        public static void SortedSetObject()
        {
            SortedSet<C1> set = new SortedSet<C1>();
            set.Add(new C1(5, "ramu"));
            set.Add(new C1(8, "raju"));
            set.Add(new C1(6, "ravi"));
            set.Add(new C1(3, "kiran"));
            set.Add(new C1(5, "ramu"));
            set.Add(new C1(5, "kirthi"));
            set.Add(new C1(1, "sanjay"));
            Console.WriteLine();
            Console.WriteLine("SortedSet with Object");
            foreach(C1 c1 in set)
            {
                Console.WriteLine(c1.i + " : " + c1.s);
            }
        }
        public static void SortedSet()
        {
            SortedSet<string> set = new SortedSet<string>();
            set.Add("shiva");
            set.Add("basu");
            set.Add("murali");
            set.Add("shiva");
            set.Add("mallu");
            set.Add("sanjay");
            set.Add("mallu");
            Console.WriteLine();
            Console.WriteLine("SortedSet Without Object");
            foreach(string s1 in set)
            {
                Console.WriteLine(s1);
            }
        }
        public static void HashSetObject()
        {
            HashSet<B1> set = new HashSet<B1>();
            set.Add(new B1(5, "ramu"));
            set.Add(new B1(8, "raju"));
            set.Add(new B1(6, "ravi"));
            set.Add(new B1(3, "kiran"));
            set.Add(new B1(5, "ramu"));
            set.Add(new B1(5, "kirthi"));
            set.Add(new B1(1, "sanjay"));
            Console.WriteLine();
            Console.WriteLine("HashSet with Object");
            IEnumerator enu = set.GetEnumerator();
            while(enu.MoveNext())
            {
                Console.WriteLine(((B1)enu.Current).i+" : "+ ((B1)enu.Current).s);
            }

            foreach(B1 b1 in set)
            {
                Console.WriteLine(b1.i + " : " + b1.s);
            }
        }
        public static void HashSet()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("shiva");
            set.Add("basu");
            set.Add("murali");
            set.Add("shiva");
            set.Add("mallu");
            set.Add("sanjay");
            set.Add("mallu");

            Console.WriteLine();
            Console.WriteLine("HashSet without Object");
            foreach(string s1 in set)
            {
                Console.WriteLine(s1);
            }

        }
        public static void ListObject()
        {
            List<A1> lists = new List<A1>();
            lists.Add(new A1(5,"ramu"));
            lists.Add(new A1(8,"raju"));
            lists.Add(new A1(6,"ravi"));
            lists.Add(new A1(3,"kiran"));
            lists.Add(new A1(5,"ramu"));
            lists.Add(new A1(5,"kirthi"));
            lists.Add(new A1(1,"sanjay"));

            Console.WriteLine();

            Console.WriteLine("List with Object");

            foreach (A1 a1 in lists)
            {
                Console.WriteLine(a1.i + " : " + a1.s);
            }
        }
        public static void List()
        {
            List<string> list = new List<string>();
            list.Add("shiva");
            list.Add("basu");
            list.Add("murali");
            list.Add("shiva");
            list.Add("mallu");
            list.Add("mallu");

            Console.WriteLine("List without Object");
            foreach(string lists in list)
            {
                Console.WriteLine(lists);
            }
        }
        public static void MethodsUsage()
        {
            List<string> list = new List<string>();
            list.Add("sachin");
            list.Add("rakesh");
            list.Add("ravi");
            list.Add("rajiv");
            list.Add("shiva");
            list.Add("ramesh");

            foreach(string s1 in list)
            {
                Console.Write(s1+"   ");
            }
            Console.WriteLine();

            list.Remove("sachin");

            foreach (string s1 in list)
            {
                Console.Write(s1+"   ");
            }
            Console.WriteLine();
            list.Insert(0, "sachin");

            foreach (string s1 in list)
            {
                Console.Write(s1+"   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            list.Sort();
            foreach (string s1 in list)
            {
                Console.WriteLine(s1);
            }
            Console.WriteLine();
            list.Reverse();
            Console.WriteLine(list[3]);
            Console.WriteLine(list.Capacity);//elements capacity
            Console.WriteLine(list.Count());//counting how many elements
            Console.WriteLine(list.IndexOf("rajiv"));//finding index number
            Console.WriteLine(list.Min() + "\n");//it will find the minimum element
            Console.WriteLine(list.Max()+"\n");//it will find the maximum element
            list.RemoveAt(1);//it is removing element of first index 
            foreach (string s1 in list)
            {
                Console.WriteLine(s1);
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            MethodsUsage();
            List();
            ListObject();

            HashSet();
            HashSetObject();

            SortedSet();
            SortedSetObject();

            Stack();
            StackObject();

            Queue();
            QueueObject();

            LinkedList();
            LinkedListObject();

            Directory();
            SortedDictionary();
            SortedList();

            ArrayList();
            Hashtable();
            Console.ReadKey();
        }
    }
}
