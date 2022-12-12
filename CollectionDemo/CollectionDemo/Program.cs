using System.Data;
using System.Xml.Linq;

namespace CollectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hint 1.dictionary,2.list,3.stack,4.queue,5.set 6.exit");
            int num = Convert.ToInt16(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (num)
                {
                    case 1:
                        DoDictionaryDemo();
                        break;
                    case 2:
                        DoListDemo();
                        break;
                    case 3:
                        DoStackDemo();
                        break;
                    case 4:
                        DoQueuesDemo();
                        break;
                    case 5:
                        DosetDemo();
                        break;
                    case 6:
                        flag = false;
                       
                        break;
                }
            }
            Console.WriteLine("exit");



        } 
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("dictionary");
            Dictionary<int, string> dictionay = new Dictionary<int, string>();
            dictionay.Add(1, "Snehal");
            dictionay.Add(2, "Mayur");
            dictionay.Add(3, "vaibhav");
            dictionay.Add(4, "raju");
            dictionay.Add(5, "lata");

            Console.WriteLine("Access of value using key"+dictionay[1]);
        
            foreach(var element in dictionay)
            {
                Console.WriteLine("key :"+element.Key+" value :"+element.Value);
            }

        }
        private static void DoListDemo()
        {
            Console.WriteLine("List");
            List<string> list = new List<string>();
            list.Add("snehal");
            list.Add("mayur");
            list.Add("vaibhav");
            list.Add("raju");
           
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            
         
        }
        private static void DoStackDemo()
        {
            Stack<string> stack = new Stack<string>();
          
            stack.Push("snehal");
            stack.Push("mayur");
            stack.Push("vaibhav");
            stack.Push("raju");
            stack.Push("lata");
            stack.Push("hina");

            Console.WriteLine("the element pop is : "+stack.Pop());
            foreach(var item in stack)
            {
                Console.WriteLine(item); ;
            }
        }
        private static void DoQueuesDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("snehal");
            queue.Enqueue("mayur");
            queue.Enqueue("vaibhav");
            queue.Enqueue("raju");
            queue.Enqueue("lata");

            Console.WriteLine("element is dequeue is :"+queue.Dequeue());
            Console.WriteLine("element is peek is :"+queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item); ;
            }
            Console.WriteLine("----------using enumrators-----------");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void DosetDemo()
        {
            Console.WriteLine("set demo");
            var Set = new HashSet<string>();
            Set.Add("snehal");
            Set.Add("mayur");
            Set.Add("vaibhav");
            Set.Add("raju");
            Set.Add("lata");
            foreach(var data in Set)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("----------using enumrators-----------");
            HashSet<string>.Enumerator enumerator = Set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            
        }
    }
}