using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1_GettingDataFromAnAPI.Models
{
   public class TerminalIdentifiersModel
    {
        public List<string> TerminalNames { set; get; }


        public override String ToString()
        {
            string res = "";
            foreach (string s in TerminalNames)
            {
                if (res == "") res = s;
                else
                {
                    res += System.Environment.NewLine + s;
                }
                //Console.WriteLine(s);
            }
            return res;
        }
    }
}
