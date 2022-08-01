using AgeCategoryApp.Logic;

namespace AgeCategoryApp
{
    public class AgeCategoryAppService
    {
        public string GetAge(int age)
        {
            if (age > 18)
            {
                return "Adult!";
            }
            else if (age > 15 && age < 18)
            {
                return "Puberty!";
            }
            else
            {
                return "Kid!";
            }
        }
    }
}
