using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Student    //Product
    {
        private string id;
        private string firstName;
        private string lastName;
        private string dayOfBirth;
        private string currentClass;
        private string phone;

        public Student(string id, string firstName, string lastName, string dayOfBirth, string currentClass, string phone)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dayOfBirth = dayOfBirth;
            this.currentClass = currentClass;
            this.phone = phone;
        }

        public void ShowInfo()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Thông tin sinh viên: ");
            Console.WriteLine("MSSV:        " + this.id);
            Console.WriteLine("Họ Tên:      " + this.lastName + " " + this.firstName);
            Console.WriteLine("Ngày sinh:   " + this.dayOfBirth);
            Console.WriteLine("Lớp:         " + this.currentClass);
            Console.WriteLine("SĐT:         " + this.phone);
            Console.WriteLine("---------------------");
        }
    }

    public interface IStudentBuilder   //Builder
    {
        IStudentBuilder setId(string id);

        IStudentBuilder setFirstName(string firstName);

        IStudentBuilder setLastName(string lastName);

        IStudentBuilder setDayOfBirth(string dayOfBirth);

        IStudentBuilder setCurrentClass(string currentClass);

        IStudentBuilder setPhone(string phone);

        Student build();
    }

    public class StudentConcreteBuilder : IStudentBuilder //ConcreteBuilder
    {
        private string id;
        private string firstName;
        private string lastName;
        private string dayOfBirth;
        private string currentClass;
        private string phone;

        public IStudentBuilder setId(string id)
        {
            this.id = id;
            return this;
        }

        public IStudentBuilder setFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public IStudentBuilder setLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public IStudentBuilder setDayOfBirth(string dayOfBirth)
        {
            this.dayOfBirth = dayOfBirth;
            return this;
        }

        public IStudentBuilder setCurrentClass(string currentClass)
        {
            this.currentClass = currentClass;
            return this;
        }

        public IStudentBuilder setPhone(string phone)
        {
            this.phone = phone;
            return this;
        }

        public Student build()
        {
            return new Student(this.id, this.firstName, this.lastName, this.dayOfBirth, this.currentClass, this.phone);
        }
    }

    class Program   //Client
    {
        static void Main(string[] args)
        {
            IStudentBuilder studentBuilder = new StudentConcreteBuilder()
                                                .setLastName("Võ")
                                                .setId("18520007")
                                                .setFirstName("Thanh Bình")
                                                .setPhone("+84365965562");
            studentBuilder.build().ShowInfo();
        }
    }
}
