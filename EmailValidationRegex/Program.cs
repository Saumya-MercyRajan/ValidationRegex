// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Enter Email Id to validate");
string emailId = Console.ReadLine() ?? "";
bool isValid = ValidateEmail(emailId);


static bool ValidateEmail (string emailId)
{
    bool isValid = false;
    if (!String.IsNullOrEmpty(emailId))
    {
        // @"-----"
        //Regex start with ^ and end with $
        // rest all condions in (---+)@(---+).(---+)
        // \w indicates a-z, A-z and 0-9
        // \- accepts - also
        // (\w){2,3} indicates the a-zA-z and 0-9 should be in 2-3 digit
        Regex regex = new Regex(@"^([\w\-]+)@([\w\-]+).(((\w){2,3})+)$");
        //Regex regex = new Regex(@"^([a-zA-Z0-9\-]+)@([a-zA-Z0-9\-]+).(((\w){2,3})+)$");
        Match match = regex.Match(emailId);
        if (match.Success)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
      



    }

    return isValid;
}

