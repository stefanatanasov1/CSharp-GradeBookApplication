using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private string name;
    

        public StandardGradeBook (string name, bool isWeighted) : base(name,isWeighted )
        {  Name = name;
         
           Type = GradeBookType.Standard;
        }
        
    }
}