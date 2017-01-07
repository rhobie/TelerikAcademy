using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOCSCS_Master
{
    class Chap14_DefiningClasses
    {

        //MAIN
         //Student StudentOne = new Student("Joe Bloggs","JB@gmail.com","022123456","Plants",Subjects.Biology,Universities.VictoriaUniversity);
            //Student StudentTwo = new Student("John M", "jndms@gmail.com", "021987654");
            //Student StudentThree = new Student("John N", "jndns@gmail.com", "021987655");

            //StudentOne.Email = "JBnew@gmail.com";

            //StudentOne.DisplayStudentInfomation();

            //Console.WriteLine();
            //Console.WriteLine();

            //StudentTwo.DisplayStudentInfomation();

            //Console.WriteLine();
            //Console.WriteLine("Number of students: "+Student.StudentCount);


            //StudentTest St = new StudentTest();

            //GSMtest gsmtest = new GSMtest();

            //Console.WriteLine("-------------------");

            //GSM newGSM = new GSM();

            //Console.WriteLine(newGSM);

            //newGSM.CallHistory.Add(new Call());
            //newGSM.CallHistory.Add(new Call());
            //newGSM.CallHistory.Add(new Call());

            //newGSM.GetCallHistory();

            //Console.WriteLine("Phone Bill: $" + newGSM.CalculateCallCosts(5.00));

            //testLibrary.RunLibraryTest();
            //SchoolTest.RunSchoolTest();
            //GenericListTest.RunGenericListTest();
            //FractionTest.RunFractionTest();


            //Console.ReadLine();


        //----------


            //public class Student
    //{
    //    public static int StudentCount = 0;

    //    //REQUIRED:
    //    private string fullName;
    //    private string phoneNumber;
    //    private string email;

    //    //NOT REQUIRED:
    //    private string course;
    //    private Subjects subject;
    //    private Universities university;

    //    public string FullName
    //    {
    //        get { return this.fullName; }
    //        set { this.fullName = value; }
    //    }

    //    public string PhoneNumber
    //    {
    //        get { return this.phoneNumber; }
    //        set { this.phoneNumber = value; }
    //    }

    //    public string Email
    //    {
    //        get { return this.email; }
    //        set { this.email = value; }
    //    }

    //    public string Course
    //    {
    //        get { return this.course; }
    //        set { this.course = value; }
    //    }

    //    public Subjects Subject
    //    {
    //        get { return this.subject; }
    //        set { this.subject = value; }
    //    }

    //    public Universities University
    //    {
    //        get { return this.university; }
    //        set { this.university = value; }
    //    }

    //    public Student(string _fullname, string _email, string _phonenumber)
    //        : this(_fullname, _email, _phonenumber, null, 0, 0) { }

    //    public Student(string _fullname, string _email, string _phonenumber, string _course, Subjects _subject, Universities _university)
    //    {
    //        this.fullName = _fullname;
    //        this.email = _email;
    //        this.phoneNumber = _phonenumber;

    //        this.course = _course;
    //        this.subject = _subject;
    //        this.university = _university;

    //        StudentCount++;
    //    }



    //    public void DisplayStudentInfomation()
    //    {
    //        Console.WriteLine();
    //        Console.WriteLine("Student name is: " + this.fullName);
    //        Console.WriteLine("Student email is: " + this.email);
    //        Console.WriteLine("Student phone number is: " + this.phoneNumber);
    //        Console.WriteLine();


    //        if (this.course != null)
    //        {
    //            Console.WriteLine("Student's course is: " + this.course);
    //            Console.WriteLine("Student's Subject is: " + this.subject);
    //            Console.WriteLine("Student's University is: " + this.university);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Student has not yet chosen a University, subject or course");
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine();
    //    }



    //}
    //public enum Universities
    //{
    //    None, VictoriaUniversity, Massey, Natcoll, AucklandUni
    //}
    //public enum Subjects
    //{
    //    None, Biology, Chemistry, Mathmatics, Design, ComputerScience
    //}


    //public class StudentTest
    //{
    //    static List<Student> StudentList = new List<Student>();


    //    static StudentTest()
    //    {
    //        for (int i = 0; i <= 10; i++)
    //        {
    //            StudentList.Add(new Student("" + i, "" + i, "" + i));
    //        }

    //        foreach (var Student in StudentList)
    //        {
    //            Student.DisplayStudentInfomation();
    //        }

    //    }


    //}
    //10. To the class of mobile phone in the previous two tasks, add a static field nokiaN95, which stores information about mobile
    //phone model Nokia N95. Add a method to the same class, which displays information about this static field.
    //
    //Define a private field and initialize it at the time of its declaration.


    public class GSMtest
    {
        static List<GSM> GsmList = new List<GSM>();

        static GSMtest()
        {
            for (int i = 0; i <= 10; i++)
            {
                GsmList.Add(new GSM());
            }

            GsmList[9].Owner = "Bob";

            foreach (var Gsms in GsmList)
            {
                Gsms.DisplayPhoneInfo();
            }
        }
    }

    public class GSM
    {
        public List<Call> CallHistory = new List<Call>();


        private PhoneModels phoneModel;
        public PhoneModels PhoneModel
        {
            get { return this.phoneModel; }
            set { this.phoneModel = value; }
        }

        private Manufacturers manufacturer;
        public Manufacturers Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        private double price;
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        private string owner;
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        private Battery battery;
        public Battery BatteryObj
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        private Display display;
        public Display DisplayObj
        {
            get { return this.display; }
            set { this.display = value; }
        }

        //CONSTRUCTOR:
        public GSM()
            : this(PhoneModels.S6, Manufacturers.Samsung, 600, "Rob", new Battery(Battery.BatteryModels.model1, Battery.BatteryTypes.LiIon, 500, 200), new Display())
        { }

        public GSM(PhoneModels _phoneModel, Manufacturers _manufacturer, int _price, string _owner, Battery _Battery, Display _Screen)
        {
            PhoneModel = _phoneModel;
            Manufacturer = _manufacturer;
            Price = _price;
            Owner = _owner;
            BatteryObj = _Battery;
            DisplayObj = _Screen;


        }

        public void GetCallHistory()
        {
            foreach (var call in CallHistory)
            {
                Console.WriteLine("Call ID: {2}; Call Date/Time: {0}; Call Duration: {1}", call.CallDateTime.ToString(), call.CallDuration.ToString(), call.CallID);
            }
        }

        public void DeleteCall(int _callID)
        {
            CallHistory.RemoveAt(_callID - 1);
        }

        public void DeleteCallHistory()
        {
            CallHistory.Clear();
        }

        public double CalculateCallCosts(double _costPerMin)
        {
            int totalDuration = 0;
            foreach (var call in CallHistory)
            {
                totalDuration += call.CallDuration;
            }
            double FinalCost = totalDuration * _costPerMin / 60;

            return FinalCost;
        }

        public void DisplayPhoneInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Model: " + this.PhoneModel);
            Console.WriteLine("Manufacturer: " + this.Manufacturer);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Owner: " + this.Owner);
            Console.WriteLine("Battery Model: " + this.BatteryObj.BatteryModel);
            Console.WriteLine("Battery Idle Time: " + this.BatteryObj.IdleTime);
            Console.WriteLine("Battery Talk Time: " + this.BatteryObj.TalkTime);
            Console.WriteLine("Display Screen Size: " + this.DisplayObj.ScreenSize);
            Console.WriteLine("Display Colour: " + this.DisplayObj.Colour);
            Console.WriteLine();
            Console.WriteLine();
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}, BatteryModel: {4}, IdleTime: {5}, TalkTime: {6}", this.PhoneModel, this.Manufacturer, this.Price, this.Owner, this.BatteryObj.BatteryModel, this.BatteryObj.IdleTime, this.BatteryObj.TalkTime);
        }

        //ENUMS---------------------
        public enum PhoneModels
        {
            S1, S2, S3, S4, S5, S6, S7, sevenS, sixS, fiveS, fourS
        }
        public enum Manufacturers
        {
            Samsung, Apple, Google
        }
        //--------------------------

        //INNER CLASS
        public class Battery
        {
            //model, idle time and hours talk

            private BatteryTypes batteryType;
            public BatteryTypes BatteryType
            {
                get { return this.batteryType; }
                set { this.batteryType = value; }
            }

            private BatteryModels batteryModel;
            public BatteryModels BatteryModel
            {
                get { return this.batteryModel; }
                set { this.batteryModel = value; }
            }

            private int idleTime;
            public int IdleTime
            {
                get { return this.idleTime; }
                set { this.idleTime = value; }
            }

            private int talkTime;
            public int TalkTime
            {
                get { return this.talkTime; }
                set { this.talkTime = value; }
            }

            //INNER CLASS CONSTRUCTOR
            public Battery() : this(BatteryModels.model1, BatteryTypes.LiIon, 10000, 1000) { }

            public Battery(BatteryModels _bateryModel, BatteryTypes _batteryTypes, int _idleTime, int _talkTime)
            {
                BatteryModel = _bateryModel;
                IdleTime = _idleTime;
                TalkTime = _talkTime;
            }
            public enum BatteryModels
            {
                model1, model2, model3
            }

            public enum BatteryTypes
            {
                LiIon, NiMH, NiCd
            }
        }

        //SECOND INNER CLASS:
        public class Display
        {
            private ScreenSizes screenSize;
            public ScreenSizes ScreenSize
            {
                get { return this.screenSize; }
                set { this.screenSize = value; }
            }

            private Colours colour;
            public Colours Colour
            {
                get { return this.colour; }
                set { this.colour = value; }
            }

            public Display() : this(ScreenSizes.small, Colours.Black) { }

            public Display(ScreenSizes _screenSize, Colours _colour)
            {
                ScreenSize = _screenSize;
                Colour = _colour;
            }

            public enum ScreenSizes
            {
                small, medium, large, phablet
            }
            public enum Colours
            {
                Red, Black, Green, Blue, Yellow
            }
        }




    }

    public class Call
    {
        public static int CallCount;

        private int callID;
        public int CallID
        {
            get { return this.callID; }
            set { this.callID = value; }
        }

        private DateTime callDateTime;
        public DateTime CallDateTime
        {
            get { return this.callDateTime; }
            set { this.callDateTime = value; }
        }

        private int callDuration;
        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }

        public Call() : this(DateTime.Now, 100) { }

        public Call(DateTime _callDateTime, int _callDuration)
        {
            CallCount++;

            this.CallID = CallCount;
            this.CallDateTime = _callDateTime;
            this.CallDuration = _callDuration;


        }

    }




    public class Library
    {

        private List<Book> bookList = new List<Book>();
        public List<Book> BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }

        private string libraryName;
        public string LibraryName
        {
            get { return libraryName; }
            set { libraryName = value; }
        }

        public void AddBook(Book _book)
        {
            BookList.Add(_book);
        }

        public void RemoveBookByIdex(int _index)
        {
            BookList.RemoveAt(_index);
        }

        public void DeleteByAuthor(string _author)
        {
            //var item = BookList.FirstOrDefault(o => o.Author == _author);

            BookList.RemoveAll(o => o.Author == _author);

            Console.WriteLine("Books with author '{0}' have been deleted", _author);
        }
        public string SearchByAuthor(string _author)
        {
            var item = BookList.FirstOrDefault(o => o.Author == _author);
            if (item != null)
            {
                string bookDetails;

                bookDetails = String.Format("BOOK FOUND WITH AUTHOR " + _author + ":  Book Name: {0}, Book Author: {1}, Book Publisher: {2}", item.Title, item.Author, item.Publisher);

                return bookDetails;
            }
            else
            {
                return "No book found";
            }

        }

        public void PrintAllBooks()
        {
            foreach (var book in BookList)
            {
                Console.WriteLine("Book Title:{0,-20}; Author:{1,-20}; Publisher:{2,-20}; IBSN:{3,-20}", book.Title, book.Author, book.Publisher, book.ISBN);
            }

        }

    }
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private DateTime releaseDate;
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private string iSBN;
        public string ISBN
        {
            get { return iSBN; }
            set { iSBN = value; }
        }

        public Book() : this("PlaceholderTitle", "MiscAuthor", "SomePublisher", "0000-1111-2222", DateTime.Now) { }

        public Book(string _title) : this(_title, "MiscAuthor", "SomePublisher", "0000-1111-2222", DateTime.Now) { }

        public Book(string _title, string _author, string _publisher, string _iSBN, DateTime _releaseDate)
        {
            this.Title = _title;
            this.Author = _author;
            this.Publisher = _publisher;
            this.ISBN = _iSBN;
            this.ReleaseDate = _releaseDate;
        }

    }

    public static class testLibrary
    {
        public static void RunLibraryTest()
        {

            //CREATE LIBRARY:
            Library newLibrary = new Library();

            //ADD BOOKS TO LIBRARY:
            newLibrary.AddBook(new Book("First Book", "Rob", "PenguinPub", "0000-444-4444", DateTime.Now));
            newLibrary.AddBook(new Book("Second Book", "Stephen King", "PenguinPub", "0000-444-4334", DateTime.Now));
            newLibrary.AddBook(new Book("Third Book", "Rob", "PenguinPubbe", "0000-444-37684", DateTime.Now));
            newLibrary.AddBook(new Book());
            newLibrary.AddBook(new Book("This is a book title"));

            Console.WriteLine();

            newLibrary.PrintAllBooks();
            Console.WriteLine();
            //SEARCH BOOK BY AUTHOR:
            Console.WriteLine(newLibrary.SearchByAuthor("Rob"));

            Console.WriteLine();
            Console.WriteLine();

            //DELETE STEPHEN KING BOOKS:
            newLibrary.DeleteByAuthor("Stephen King");
            newLibrary.PrintAllBooks();

            Console.WriteLine();
            Console.WriteLine();

            //DELETE ROB BOOKS:
            newLibrary.DeleteByAuthor("Rob");
            newLibrary.PrintAllBooks();


        }

    }


    //22. We have a school. In school we have classes and students. Each class has a number of teachers. Each
    //teacher has a variety of disciplines taught. 

    //The task is to shape a school with C# classes. You have to define classes with their fields,
    //properties, methods and constructors. Also define a test class, which demonstrates, that the
    //other classes work correctly.
    //
    //-Create classes School, SchoolClass, Student, Teacher, Discipline and define into them their respective
    //fields, as described in the instructions of the task. Do not use the word "Class" as a class name, because
    //in C# it has special meaning. Add methods for printing all the fields from each of the classes.



    public class School
    {
        private List<Student> StudentsInSchool = new List<Student>();
        private List<SchoolClass> ClassesAtSchool = new List<SchoolClass>();

        private string schoolName;
        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        public School(string _schoolName)
        {
            this.SchoolName = _schoolName;
        }

        public void AddStudent(Student newStudent)
        {
            StudentsInSchool.Add(newStudent);
        }

        public void PrintAllStudents()
        {
            foreach (var student in StudentsInSchool)
            {
                Console.WriteLine("Student ID:   {0,-6}Student Name:   {1,-6}", student.StudentId, student.StudentName);
            }
            Console.WriteLine();
        }

        public void AddClass(SchoolClass newClass)
        {
            ClassesAtSchool.Add(newClass);
        }

        public void PrintAllClasses()
        {
            foreach (var schoolClass in ClassesAtSchool)
            {
                Console.WriteLine("CLASSID:{0,-6} CLASSNAME:{1,-1}", schoolClass.UniqueID, schoolClass.ClassName);
            }
            Console.WriteLine();
        }

        //INNER CLASS
        public class Student
        {
            private static int studentCount = 0;

            private int studentId;
            public int StudentId
            {
                get { return studentId; }
                set { studentId = value; }
            }


            private string studentName;
            public string StudentName
            {
                get { return studentName; }
                set { studentName = value; }
            }

            public Student(string _studentName)
            {
                studentCount++;
                StudentId = studentCount;
                StudentName = _studentName;
            }
            public override string ToString()
            {
                return this.StudentName;
            }

        }
        //INNER CLASS
        public class SchoolClass
        {
            private static int classCount = 0;

            private string uniqueID;
            public string UniqueID
            {
                get { return uniqueID; }
                set { uniqueID = value; }
            }

            private string className;
            public string ClassName
            {
                get { return className; }
                set { className = value; }
            }

            public SchoolClass(string _className)
            {
                classCount++;
                UniqueID = "CLASSID:" + classCount;
                ClassName = _className;
            }


            //INNER INNER CLASS:
            public class Teacher
            {
                private string teacherName;
                public string TeacherName
                {
                    get { return teacherName; }
                    set { teacherName = value; }
                }

                //INNER INNER INNER CLASS
                public class Discipline
                {
                    private string disciplineName;
                    public string DisciplineName
                    {
                        get { return disciplineName; }
                        set { disciplineName = value; }
                    }

                    private int lessonCount;
                    public int LessonCount
                    {
                        get { return lessonCount; }
                        set { lessonCount = value; }
                    }

                    private int excerciseCount;
                    public int ExcerciseCount
                    {
                        get { return excerciseCount; }
                        set { excerciseCount = value; }
                    }
                }
            }
        }
    }

    public static class SchoolTest
    {
        public static void RunSchoolTest()
        {
            School newSchool = new School("Wellington School of C#");

            newSchool.AddStudent(new School.Student("Pete"));
            newSchool.AddStudent(new School.Student("Bill"));
            newSchool.AddStudent(new School.Student("Roger"));
            newSchool.AddStudent(new School.Student("Ben"));
            newSchool.AddStudent(new School.Student("Susan"));
            newSchool.AddStudent(new School.Student("Bub"));
            newSchool.AddStudent(new School.Student("Morris"));

            newSchool.PrintAllStudents();

            newSchool.AddClass(new School.SchoolClass("Basic Algorithms"));
            newSchool.AddClass(new School.SchoolClass("Advanced Algorithms"));
            newSchool.AddClass(new School.SchoolClass("Data Structures"));
            newSchool.AddClass(new School.SchoolClass("High Quality Code"));

            newSchool.PrintAllClasses();
        }
    }

    //23. 
    //just to make sure that no element can access an invalid position.

    //GENERIC CLASS:
    public class GenericList<T>
    {
        public T[] someList;

        private int arrayLimit;

        public GenericList(int _arrayLimit)
        {
            T[] theList = new T[_arrayLimit];
            someList = theList;
            arrayLimit = _arrayLimit;
        }

        public void AddItem(T _item)
        {
            bool itemAdded = false;
            IncreaseArraySize();
            for (int i = 0; i <= someList.Length - 1; i++)
            {
                if (someList[i] == null)
                {
                    someList[i] = _item;
                    itemAdded = true;
                    Console.WriteLine("Item ({0}) added at index({1})", _item.ToString(), i);
                    break;
                }
            }
            if (itemAdded == false)
            {
                Console.WriteLine("No room to add item");
            }
        }
        public T AccessByIndex(int _index)
        {
            return someList[_index];
        }

        public void RemoveByIndex(int _index)
        {
            someList[_index] = default(T);

            Console.WriteLine("Item removed at index {0}", _index);
        }
        public void InsertAtPosition(T _item, int _index)
        {
            someList[_index] = _item;
        }
        public void ClearList()
        {
            for (int i = 0; i <= someList.Length - 1; i++)
            {
                someList[i] = default(T);
            }
            Console.WriteLine("List Cleared");
        }
        public int SearchByValue(T _value)
        {
            for (int i = 0; i <= someList.Length - 1; i++)
            {
                if (someList[i].ToString() == _value.ToString())
                {
                    Console.WriteLine("Matching Item found at index:{0}", i);
                    return i;
                }
            }
            Console.WriteLine("No item found");
            return -1;

        }

        public void PrintAllItems()
        {
            for (int i = 0; i <= someList.Length - 1; i++)
            {
                Console.WriteLine("INDEX:{0,-8} NAME:{1,-8}", i, someList[i]);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string returnString = "";
            for (int i = 0; i <= someList.Length - 1; i++)
            {
                returnString += someList[i].ToString() + "; ";
            }
            return returnString;
        }

        private void IncreaseArraySize()
        {
            if (someList[someList.Length - 1] != null)
            {
                Array.Resize(ref someList, someList.Length + 1);
            }
        }
    }

    public static class GenericListTest
    {
        public static void RunGenericListTest()
        {
            GenericList<School.Student> GenericListOfStudents = new GenericList<School.Student>(10);

            //ADD ITEMS:
            GenericListOfStudents.AddItem(new School.Student("Bill"));
            GenericListOfStudents.AddItem(new School.Student("Bob"));
            GenericListOfStudents.AddItem(new School.Student("Jim"));
            GenericListOfStudents.AddItem(new School.Student("Horace"));
            GenericListOfStudents.AddItem(new School.Student("Mark"));
            GenericListOfStudents.AddItem(new School.Student("James"));
            GenericListOfStudents.AddItem(new School.Student("Phill"));
            GenericListOfStudents.AddItem(new School.Student("Peter"));
            GenericListOfStudents.AddItem(new School.Student("Keith"));
            GenericListOfStudents.AddItem(new School.Student("Wayne"));
            Console.WriteLine();

            //AccessByIndex
            Console.WriteLine(GenericListOfStudents.AccessByIndex(3).ToString());//should be 'horace' -YES
            Console.WriteLine();

            //RemoveByIndex
            GenericListOfStudents.RemoveByIndex(3);
            GenericListOfStudents.PrintAllItems();
            Console.WriteLine();

            //InsertAtPosition
            GenericListOfStudents.InsertAtPosition(new School.Student("FELLOW STUDENT"), 3);
            GenericListOfStudents.PrintAllItems();
            Console.WriteLine();

            //SearchByValue
            GenericListOfStudents.SearchByValue(GenericListOfStudents.someList[0]);
            Console.WriteLine();

            //ToString OverLoad:
            Console.WriteLine(GenericListOfStudents.ToString());
            Console.WriteLine();

            ////ClearList();
            //GenericListOfStudents.ClearList();
            //GenericListOfStudents.PrintAllItems();
            //Console.WriteLine();

            //Add items past array size, try to increase size mof array to accomodate:
            GenericListOfStudents.AddItem(new School.Student("Bill"));
            GenericListOfStudents.AddItem(new School.Student("Bob"));
            GenericListOfStudents.AddItem(new School.Student("Jim"));
            GenericListOfStudents.AddItem(new School.Student("Horace"));
            Console.WriteLine();
            GenericListOfStudents.PrintAllItems();
            Console.WriteLine();
            GenericListOfStudents.AddItem(new School.Student("Bob"));
            GenericListOfStudents.AddItem(new School.Student("Jim"));
            Console.WriteLine();
            GenericListOfStudents.PrintAllItems();
            Console.WriteLine();

            //ToString OverLoad:
            Console.WriteLine(GenericListOfStudents.ToString());
            Console.WriteLine();



            Console.WriteLine();

        }
    }

    //25. Define a class Fraction, which contains information about the rational fraction (e.g. ¼ or ½).
    //Define a static method Parse() to create a fraction from a string (for example -3/4). Define the appropriate
    //properties and constructors of the class. Also write property of type Decimal to return
    //the decimal value of the fraction (e.g. 0.25).
    //
    //-Write a class with two private decimal fields, which hold information relevant to the numerator and
    //denominator of the fraction. Among other requirements in the task, redefine in appropriate standard the
    //features for each object: Equals(…), GetHashCode(), ToString().

    //26. Write a class FractionTest, which tests the functionality of the class Fraction from previous task.
    //Pay close attention on testing the function Parse with different input data.
    //
    //-Figure out appropriate tests, for which your function may give incorrect results. Good practice is
    //first to write the tests, then to implement their specific functionality.

    //27. Write a function to cancel a fraction (e.g. if numerator and denominator are respectively 10
    //and 15, fraction to be cancelled to 2/3).
    //
    //-Search for information in Internet for the “greatest common divisor (GCD)” and the Euclidean
    //algorithm for its calculation. Divide the numerator and denominator of their greatest common divisor and you will get the cancelled fraction.

    public class Fraction
    {
        private decimal numerator;
        private decimal denominator;
        private decimal gcd;

        public decimal AsDecimal
        {
            get { return (this.numerator / this.gcd) / (this.denominator / this.gcd); }
        }

        public Fraction(decimal _numerator, decimal _denominator)
        {
            this.numerator = _numerator;
            this.denominator = _denominator;
            this.gcd = GCD(new decimal[] { this.numerator, this.denominator });
        }



        public static Fraction Parse(string _fractionToParse)
        {
            decimal _numerator = 0;
            decimal _denominator = 0;

            string[] stringArray = _fractionToParse.Split('/');
            decimal.TryParse(stringArray[0], out _numerator);
            decimal.TryParse(stringArray[1], out _denominator);

            if (!_fractionToParse.Contains('/') || _denominator == 0)
            {
                return new Fraction(1, 1);
            }
            else
            {
                return new Fraction(_numerator, _denominator);
            }
        }

        //BORKEN::getSTACKOVVVERFLOWW!
        static decimal GCD(decimal[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        static decimal GCD(decimal a, decimal b)
        {
            return (a == 0 || b == 0) ? (int)a | (int)b : GCD(Math.Min(a, b), Math.Max(a, b) % Math.Min(a, b));
        }
        //_----------

        //THESE NEED TO BE DONE:
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
        //--------------------------
    }

    public static class FractionTest
    {
        public static void RunFractionTest()
        {
            string testToParse = "-3/4";

            Console.WriteLine(Fraction.Parse(testToParse).AsDecimal); //-PASS

            Console.WriteLine(Fraction.Parse("3/7").AsDecimal);
            Console.WriteLine(Fraction.Parse("12/12565").AsDecimal);

            //MORE INDEPTH:
            Console.WriteLine(Fraction.Parse("hello").AsDecimal);

            Console.WriteLine(Fraction.Parse("1/0").AsDecimal);

        }
    }


    public class HashingTest
    {
        HashSet<int> myHashSet = new HashSet<int>();

        public HashingTest()
        {
            myHashSet.Add(2);
            myHashSet.Add(3);
            myHashSet.Add(4);
            myHashSet.Add(4);
            myHashSet.Add(5);
            myHashSet.Add(6);
        }

    }


}






    }

