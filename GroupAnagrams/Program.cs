using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s1 = new Solution();

            IList<IList<string>> result = s1.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

           foreach (var group in result)
           {
               Console.WriteLine(string.Join(", ", group));
           }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr= strs[i].ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);
                if (!dict.ContainsKey(sorted))
                {
                    dict.Add(sorted, new List<string>() { strs[i] })  ;   
                }
                else
                {
                    dict[sorted].Add(strs[i]) ;
                }

            }
            return dict.Values.ToList();
        }
    }
}
