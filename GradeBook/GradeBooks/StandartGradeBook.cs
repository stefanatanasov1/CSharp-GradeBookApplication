using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandartGradeBook : BaseGradeBook
    {
        private string name;

        public StandartGradeBook (string name) : base(name)
        {  
           Type = GradeBookType.Standard;
        }
        
    }
}