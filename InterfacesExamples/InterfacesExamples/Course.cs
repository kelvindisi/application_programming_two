using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExamples
{
    class Course: ICourse
    {
        private int courseId;
        private string courseName;

        public int PCourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public string PCourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public void getDetails()
        {
            Random rand = new Random();
            PCourseId = rand.Next(100, 500);
            Console.Write("Enter course name: ");
            PCourseName = Console.ReadLine();
        }
        public void printDetails()
        {
            Console.WriteLine("Course ID: {0} Course name: {1}", PCourseId, PCourseName);
        }
    }
}
