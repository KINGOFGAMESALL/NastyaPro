using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Student
    {
        public string Surname { get; set; }
        public string Group { get; set; }
        public double Average_mark { get; set; }

        public Student(string surname, string group, double average_mark)
        {
            Surname = surname;
            Group = group;
            Average_mark = average_mark;
        }

        public override string ToString()
        {
            return $"{Surname} ({Group}), {Average_mark} average mark";
        }
    }

    public class StudentList
    {
        private List<Student> students;
        private int current;

        public StudentList()
        {
            students = new List<Student>();
            current = -1;
        }

        public void AddStudent(string surname, string group, double average_mark)
        {
            Student newStudent = new Student(surname, group, average_mark);
            students.Add(newStudent);
        }

        public void RemoveStudent()
        {
            if (current != -1)
            {
                students.RemoveAt(current);
                current--;
            }
        }

        public void MoveToFirst()
        {
            current = 0;
        }

        public void MoveToLast()
        {
            current = students.Count - 1;
        }

        public void MoveToNext()
        {
            if (current != students.Count - 1)
            {
                current++;
            }
        }

        public void MoveToPrevious()
        {
            if (current != 0)
            {
                current--;
            }
        }

        public Student GetCurrentStudent()
        {
            if (current != -1)
            {
                return students[current];
            }
            else
            {
                return null;
            }
        }

        public void SetCurrentStudent(string surname, string group, double average_mark)
        {
            if (current != -1)
            {
                students[current] = new Student(surname, group, average_mark);
            }
        }

        public void SortBySurname()
        {
            students.Sort((s1, s2) => s1.Surname.CompareTo(s2.Surname));
        }

        public void SortByAverageMark()
        {
            students.Sort((s1, s2) => s1.Average_mark.CompareTo(s2.Average_mark));
        }

        public void PrintStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentList studentList = new StudentList();

            studentList.AddStudent("Ivanov", "Group1", 4.5);
            studentList.AddStudent("Petrov", "Group2", 3.2);
            studentList.AddStudent("Sidorov", "Group3", 5.0);

            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("1 - add student");
                Console.WriteLine("2 - remove current student");
                Console.WriteLine("3 - move to first student");
                Console.WriteLine("4 - move to last student");
                Console.WriteLine("5 - move to next student");
                Console.WriteLine("6 - move to previous student");
                Console.WriteLine("7 - get current student");
                Console.WriteLine("8 - set current student");
                Console.WriteLine("9 - sort by surname");
                Console.WriteLine("10 - sort by average mark");
                Console.WriteLine("11 - print all students");
                Console.WriteLine("0 - exit");

                string command = Console.ReadLine();

switch (command)
                {
                    case "1":
                        Console.WriteLine("Введите имя корабля:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите тип корабля:");
                        string type = Console.ReadLine();
                        Console.WriteLine("Введите водоизмещение корабля:");
                        double displacement = double.Parse(Console.ReadLine());
                        Console.WriteLine("Корабль добавлен: ");
                        shipList.AddShip(name, type, displacement);
                        break;
                    case "2":
                        shipList.RemoveShip();
                        Console.WriteLine("Текущий корабль удален.");
                        break;
                    case "3":
                        shipList.MoveToFirst();
                        Console.WriteLine("Перешли к первому кораблю.");
                        break;
                    case "4":
                        shipList.MoveToLast();
                        Console.WriteLine("Перешли к последнему кораблю.");
                        break;
                    case "5":
                        shipList.MoveToNext();
                        Console.WriteLine("Перешли к следущему кораблю.");
                        break;
                    case "6":
                        shipList.MoveToPrevious();
                        Console.WriteLine("Перешли к предыдущему кораблю.");
                        break;
                    case "7":
                        Ship currentDog = shipList.GetCurrentShip();
                        if (currentDog != null)
                        {
                            Console.WriteLine(currentDog.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Корабль не выбра.");
                        }
                        break;
                    case "8":
                        Console.WriteLine("Введите имя корабля:");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Введите тип корабля:");
                        string newType = Console.ReadLine();
                        Console.WriteLine("Введите водоизмещения корабля:");
                        double newDisplacement = double.Parse(Console.ReadLine());
                        shipList.SetCurrentShip(newName, newType, newDisplacement);
                        break;
                    case "9":
                        shipList.SortByName();
                        Console.WriteLine("Сортировка по имени произведена:");
                        shipList.PrintShips();
                        break;
                    case "10":
                        shipList.SortByDisplacement();
                        Console.WriteLine("Сортировка по водоизмещению произведена:");
                        shipList.PrintShips();
                        break;
                    case "11":
                        shipList.PrintShips();
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}