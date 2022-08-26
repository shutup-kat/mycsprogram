using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Solution {
    public string myR(string temp)
    {
        char[] newtemp = temp.ToCharArray();
        Array.Reverse(newtemp);
        
        return new string (newtemp);
    }
    public bool IsPalindrome(string s) {
        string final = "";
        string temp = s.ToLower();
       
        for(int i=0; i<temp.Length; i++)
        {
            if((temp[i] > 47 && temp[i] < 58) || (Char.IsLetter(temp[i]) ) ) 
            {
                    final += temp[i];
                    //Console.WriteLine(final);
            }
        }
        string final1 = myR(final);
        if(final == final1){ return true; }
        else{ return false; }
    }
}

public class Solution {
    
    public int[] TwoSum(int[] nums, int target) {
        List<int> l = nums.ToList();
        List<int> temp = new List<int>();
        for(int i=0; i<l.Count(); i++)
        {
            for(int j=i+1; j<l.Count(); j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    temp.Add(i);
                    temp.Add(j);
                }
            }
        }
        int[] t = temp.ToArray();
        return t;
    }
}


// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */
     
    public static int sockMerchant(int size, List<int> ar)
    {
        Dictionary<int, int> p = new Dictionary<int, int>();
        List<int> found = new List<int>();
        int count = 0;
        for(int i=0; i<size-1; i++)
        {
            for(int j=i+1; j<size; j++)
            {
                if(!found.Contains(ar[i]))
                {
                    //Console.WriteLine(ar[i]);
                    //Console.WriteLine(ar[j]);
                    if(count == 0){count += 1;}
                    if(ar[i] == ar[j]){count+=1;}
                    //Console.WriteLine(count);
                    //Console.WriteLine("\n");
                }
            }
            if(!found.Contains(ar[i]))
            {
                found.Add(ar[i]);
                p.Add(ar[i], count);
                count = 0;
            }
        }   
        int final = 0;
        foreach( int Value in found)
        {
            while(p[Value] >= 1)
            {
                //Console.WriteLine(p[Value]);
                if((p[Value] -=2)>=0){final+=1;}
                //p[Value] -= 2;
                //Console.WriteLine(p[Value]);
                //Console.WriteLine(final);
                //Console.WriteLine("\n");
            }
        }
        return final;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
       
        char[] myp = path.ToCharArray();
        int total = 0, valley = 0;
        bool v = false;
        for(int i=0; i<path.Length; i++)
        {   
            if(myp[i] == 'U')
            { total += 1; }
            else
            { total -= 1; }
            
            if(v == true && total == 0)
            {
                valley += 1;
                v = false;
            }
            if(total == -1)
            { v = true; }  
        }
        return valley;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int size = c.Count;
        int path = 0;
        int cur = 0;
        while(cur <= (size-2))
        {
            Console.WriteLine("cur before if");
            Console.WriteLine(cur);
            if( (cur < size-2) )
            {
                if( (c[cur + 2] != 1) )
                {
                    cur += 2;
                    Console.WriteLine("cur after +2");
                    Console.WriteLine(cur);
                    Console.WriteLine("path in if");
                    Console.WriteLine(path);
                }
                else
                {
                    cur += 1;
                }
            }
            else
            {
                cur += 1;
            }
            path += 1;
        }
        return path;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

class Result
{

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        string kat = s.ToLower();
        int limit = kat.Count(), temp = 0;
        long track = 0, total = 0, full = 0, rem = 0;
        //Console.WriteLine(kat.Count());
        for(int i=0; i<limit; i++)
        {
            if(kat[i] == 'a')
            {
                total += 1;
            }
        }
        full = (n/limit);
        rem = (n%limit);
        total = (total * full);
        for(int i=0; i<rem; i++)
        {
            if(kat[i] == 'a'){total += 1;}
        }
        Console.WriteLine(total);
        return total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
