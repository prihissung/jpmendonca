using System.Collections.Generic;
using System.Text;

namespace classcourse
{
     interface ICourse
     { 
        
            IEnumerable<ICourse> GetAllCourse();
            void AddCourse(Course course);
            void UpdateCourse(ICourse course);
            ICourse GetCourse(int? id);
            void DeleteCourse(int? id);
     }
}
//teste