using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDesign.MVVM.ViewModel
{
    internal class CompletedTasksViewModel
    {

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            } 
            else if(strs.Length == 1)
            {
                return strs[0];
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i< strs.Length; i++)
            {
                for (int j = i + 1; j < strs[i].Length; j++)
                {
                    if(i + 1 < strs.Length && j < strs[i+1].Length)
                    {
                        if (strs[i][j].Equals(strs[i + 1][j]))
                        {
                            sb.Append(strs[i][j]);                           
                        } 
                        else
                        {
                            break;
                        }
                    }
                }
            }
            

            return sb.ToString();
        }
    }
}

// 780