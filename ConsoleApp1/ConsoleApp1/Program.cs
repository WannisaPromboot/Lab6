using System;

namespace lab
{
    class lab6
    {
        static void Main(string[] args)
        {
            Student tr = new Student("58030218",300);
            try
            {
                //tr.studentID = "your ID";
                //tr.salary = 500f;
                Console.WriteLine("StudentID : " + tr.student);
                Console.WriteLine("Salary   : " + tr.salary);
             
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


        }
    }
    class traineestudent
    {
        private string studentID;
        private int salary;
 

        public traineestudent(string studentID, int salary)
        {
            this.studentID = studentID;   // assign auto variable to the field
            this.salary = salary;
        }

        public string getstudentID
        {
            get { return studentID; }
        }
        public int getsalary
        {
            get { return salary ; }
            set
            {
                if (value >= 300 && value < 450)
                    salary = value;
                else
                    throw (new Exception("Error!!!! invalid salary"));
            }
        }
        
            
        }
    }





