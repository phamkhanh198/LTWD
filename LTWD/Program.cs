using System;

namespace LTWD
{
    class Student
    {
        private string studentID;
        private string fullName; 
        private float averageScore; 
        private string faculty;

        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public Student()
        { 
        }

        public Student(string id, string name, float score, string faculty)
        {
            studentID = id;
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien : ");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] arrStudents = new Student[N];
            Console.WriteLine("\n ====NHAP DANH SACH SINH VIEN====");
            for (int i = 0; i < N; i++) //Lap n lan nhap thong tin sv 
            {
                arrStudents[i] = new Student();
              //  Console.WriteLine("Nhap thong tin sinh vien thu {0}", i + 1);
                Console.Write("Nhap MSSV thu {0}:", i + 1);
                arrStudents[i].StudentID = Console.ReadLine();
                Console.Write("Nhap TenSV thu {0}:", i + 1);
                arrStudents[i].fullName = Console.ReadLine();
                Console.Write("Nhap DiemTB thu {0}:", i + 1);
                arrStudents[i].averageScore = float.Parse(Console.ReadLine());
                Console.Write("Nhap khoa cua sinh vien thu {0}:", i + 1);
                arrStudents[i].faculty = Console.ReadLine();
                Console.WriteLine("\n");
                //SV lam tuong tu cho cac thong tin can nhap
            }
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in arrStudents)
            {
              //  Console.WriteLine("Thong tin sinh vien thu {0}", i + 1);
                Console.WriteLine("MSSV:{0}", sv.StudentID);
                Console.WriteLine("NameSV:{0}", sv.fullName);
                Console.WriteLine("DiemTB:{0}", sv.averageScore);
                Console.WriteLine("Khoa:{0}", sv.faculty);
                Console.WriteLine("\n");
            }
            Console.ReadKey();        
        }
    }
}
