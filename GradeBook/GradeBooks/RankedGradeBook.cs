using GradeBook.Enums; 
using System;
using System.Linq;

namespace GradeBook.GradeBooks

{ 
    public class RankedGradeBook : BaseGradeBook 
    {
      public RankedGradeBook(string name)  :  base(name)
      {
          Type = GradeBookType.Ranked;
      }
        private readonly double averageGrade;
       
     public override char GetLetterGrade(double averageGrade)
       {  
           if (Students.Count < 5) 
           {
            throw new InvalidOperationException("Ranked grading required at least 5 students.");

           }  

           var threshold = (int)Math.Ceiling(Students.Count * 0.2); // the * 0.2 will give me the 20% of the students count;
           var grades = Students.OrderByDescending(e => e.AverageGrade);
            return base.GetLetterGrade(averageGrade);

            

       }
     
    }
}
