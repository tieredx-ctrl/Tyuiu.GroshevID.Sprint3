using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GroshevID.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char c in value)
            {
                if (c == 'q')
                {
                    res += '7';
                }
                else
                {
                    res += c;
                }
            }
            return res;
        }
    }
}
