using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private string name;

        public StandardGradeBook (string name) : base(name)
        {  
           Type = GradeBookType.Standard;
        }
        
    }
}