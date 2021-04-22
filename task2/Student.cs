using System;

namespace task2
{
    class Student
    {
        public string Name{set;get;}
        public byte Course{set;get;}
        public byte Mark{set;get;}

        public virtual void NextCourse(){
            if(Mark>=3) 
                Course++;
        }

        public virtual int Scholarship(){
            if(Mark==5)
                return 3000;
            else if(Mark == 4)
                return 2000;
            else
                return 0;
        }
        public virtual string Info(){
            return $"\nStudent:\n{{\n   Name: {Name},\n   Course: {Course},\n   Mark: {Mark},\n   Scholarship: {Scholarship()}\n}}";
        }
    }
    class PaidStudent : Student
    {
        public bool Paid{get;set;}

        public override void NextCourse()
        {
            if(Mark>=3 && Paid)
                Course++;
        }

        public override int Scholarship()
        {
            return 0;
        }
    }
    class GradStudent : Student
    {
        public string headName{set; get;}

        public override void NextCourse()
        {
            if(Mark>=4)
                Course++;
        }

        public override int Scholarship()
        {
            return 5000;
        }

    }
}
