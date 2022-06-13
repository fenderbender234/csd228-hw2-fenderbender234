using System;
using System.Data;
using System.Text;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;

            string number = "";

            try
            {
                number = args[0];

                if(number != "odd" && number != "even")
                {
                    Console.Write("Wrong input");
                    return;
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            try
            {
                bool result = int.TryParse(args[1], out x);

                if(x <= 0)
                {
                    Console.Write("Wrong input");
                    return;
                }
                if(args.Length > 2)
                {
                    Console.Write("Wrong input");
                    return;
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine(GenerateTable(number, x));
        }

        public static string GenerateTable(string number, int x)
        {

            int counter = 1;

            StringBuilder sb = new StringBuilder(); 

                    //Table Start
                    sb.Append("<table>\r\n");

                    for(int i = 1; i <= x; i++)
                    {
                        //If even should be colored, and an even row is being generated
                        if(number == "even" && (counter) % 2 == 0)
                        {
                            sb.Append("  <tr style=\"background:gray\">\r\n");
                            sb.Append("    <td>Row " + counter + "</td>\r\n");
                            sb.Append("  </tr>\r\n");
                        }
                        //If odd should be colored, and an odd row is being generated
                        else if(number == "odd" && (counter % 2) != 0)
                        {
                            sb.Append("  <tr style=\"background:gray\">\r\n");
                            sb.Append("    <td>Row " + counter + "</td>\r\n");
                            sb.Append("  </tr>\r\n");
                        }
                        //If an even or odd row is not being highlighted, output this html text
                        else
                        {
                            sb.Append("  <tr>\r\n");
                            sb.Append("    <td>Row " + counter + "</td>\r\n");
                            sb.Append("  </tr>\r\n");
                        }

                        counter++;
                    }
            //End table and write StringBuilder to console
            sb.Append("</table>");
            string html = sb.ToString();
            return(html);
        }
    }
}