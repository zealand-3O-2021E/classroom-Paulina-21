namespace ClassRoom
{
    public class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }

        public Student(string name, int month, int day)
        {
            Name = name;
            BirthDay = day;
            BirthMonth = month;
        }
    }
}