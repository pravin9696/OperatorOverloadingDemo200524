using System;
namespace OperatorOverloadingDemo200524
{
   class student
    {
        private int roll;
        private string name;
        private int per;

        //overload true / false operator

        static public bool operator true(student std)
        {
            if (std.per<40)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public bool operator false(student std)
        {
            if (std.per < 40)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public student operator ++(student st)
        {
            Console.WriteLine("++ operator executed!!!!");
            st.per++;
            return st;
        }
        static public  bool operator ==(student st1,student st2)
        {
            if (st1.per==st2.per)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator !=(student st1, student st2)
        {
            if (st1.per != st2.per)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public student()
        {
                
        }
        public student(int r,string nm,int p)
        {
            roll = r;
            name=nm; 
            per=p;
        }
        public void showStudent()
        {
            Console.WriteLine(" Roll= "+roll+" Name="+name+" Per="+per);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(1, "Rajesh", 38);
            student s2 = new student(2, "dinesh", 98);
            s1.showStudent();
            s2.showStudent();
            if (s1==s2)
            {
               Console.WriteLine("Both having same per");
            }
            else
            {
                global::System.Console.WriteLine("different per..."); 
            }

            s1++; //per++
            s1.showStudent();
            ++s1;
            s1.showStudent();
            if (s1)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
    }
}
