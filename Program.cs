using System.Collections.Generic;
using System;

public class Solution {

    // Complete the isBalanced function below.
    static string balancedString(string s) {
		int pos = 0;
		char[] c_arr = s.ToCharArray();
		Stack<char> st = new Stack<char>();
		for(int i = 0; i< c_arr.Length; i++)
		{
			if(c_arr[i] == '(')
			{
				st.Push('(');
			}
			else
			{
				if(st.Count > 0)
				{
					st.Pop();
				}
				else
				{
					if(pos !=0)
					{
						s = String.Concat(s.Substring(0, pos-1), "(", s.Substring(pos-1));
					}	
					else
					{
						s = String.Concat("(", s.Substring(pos));
					}
					pos++;
				}
			}
			pos++;
		}
		
		s = String.Concat(s, new String(')', st.Count));
		
		return s;
    }

    public static void Main(string[] args) {
        
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = balancedString(s);

            Console.WriteLine(result);
        }
    }
}
