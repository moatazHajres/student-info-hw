namespace StudentInfo.Model
{
    class Student
    {

        public string studentid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public string address { get; set; }
        public string dept { get; set; }

        public Student(string studentid, string firstName, string lastName, string birthDate, string address, string dept)
        {
            this.studentid = studentid;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.address = address;
            this.dept = dept;
        }
    }
}
