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

class Result
{
  /*
  *  Given: 
  *  - ids or "scores", is an int list. index represents member's id
  *  value stored at index i = member's socore. ex: n = [1, 2, 4, 2, 5] 
  *  - q or a nested int list containing member's ids to be compared.
  *  ex: q = [ [0,2], [2,3], [1,3] ] => index's of n to be compared.
  *  
  *  Result: 
  *  - a 1D list that decideds if its valid: 1 or invalid: 0.
  *  given q from above, result = [0, 0, 1]; where the first and second 
  *  pairing are invalid and the las pair is valid.

    ids = [1, 2, 4, 2, 5]; 
    q = [ [0,2], [2,3], [1,3] ];
 to compare: if ids[ q[0][0] ] ?== ids[ q[0][1] ] 
            =>       ids[0]    ?==       ids[2] 
            =>         1       ?==         4  
            => invalid, id's must match.

  *   
  */
  public static List<int> Teams (List<int> ids, List<List<int>> q)
  {
    List<int> final = new List<int>();
    for(int i=0; i<q.Count; i++)
    {
      // Console.WriteLine("ids[ q[{0}][0] ]", i);
      // Console.WriteLine(ids[q[i][0]]);
      // Console.WriteLine("ids[ q[{0}][1] ]", i);
      // Console.WriteLine(ids[q[i][1]]);
      if(ids[ q[i][0] ] == ids[ q[i][1] ] )
      { final.Add(1); }
      else{ final.Add(0); }
    }
    return final;
  }
}

class Program {
  public static void Main (string[] args) {
    // for std input, use text imported lib. 
    // have hard coded input below.
    List<int> id = new List<int>();
    id.Add(2); // [2, 3, 2, 4, 3];
    id.Add(3);
    id.Add(2);
    id.Add(4);
    id.Add(3);
    List<List<int>> q = new List<List<int>>();
    for(int i=0; i<3; i++)
    {
      List<int> nl = new List<int>();
      q.Add(nl);
    }
    
    q[0].Add(0); //adds pair: 0,2 ; is valid
    q[0].Add(2);

    q[1].Add(1); //adds pair: 1,2 ; not valid
    q[1].Add(2);

    q[2].Add(1); //adds pair: 1,4 ; is valid
    q[2].Add(4);

    List<int> r = Result.Teams(id, q);
    foreach (int x in r)
    {
      Console.WriteLine("Valid pairs in order given: {0}",x);
    }
    //Console.WriteLine ("Hello World");
  }
}