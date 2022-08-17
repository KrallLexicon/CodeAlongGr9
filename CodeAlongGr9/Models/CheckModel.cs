namespace CodeAlongGr9.Models
{
    public class CheckModel
    {
        public static string CheckAge(int age)
        {
            if (age >= 18)
                return "You are allowed to vote!";
            else
                return "You are too young to vote!";
        }
    }
}
