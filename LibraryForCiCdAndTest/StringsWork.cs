using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForCiCdAndTest
{
    public class StringsWork
    {

        public bool SearchInString(string input, string search)
        {
            if (search == "") {
                throw new ArgumentNullException("search is Null");
            }
            if (input == "") {
                throw new ArgumentNullException("input is Null");
            }
            bool result = false;

            try
            {
                result = input.Contains(search);
            }
            catch (Exception ex) {
                Debug.WriteLine(ex);
                Trace.WriteLine(ex.ToString());
            }
           
            return result;
        }

        public void ChangeInString(string input, string search, string str)
        {
            if (search == "")
            {
                throw new ArgumentNullException("search is Null");
            }
            if (input == "")
            {
                throw new ArgumentNullException("input is Null");
            }
            if (str == "")
            {
                throw new ArgumentNullException("str is Null");
            }
            bool result = false;

            if (SearchInString(input, search))
            {
                input.Replace(search, str);
            }
            else {
                
            }
        }

        public string RemoveSpaces(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            return text.Replace(" ", "");
        }
    }
}
