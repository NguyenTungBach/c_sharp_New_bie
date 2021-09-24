namespace Lab3_Ex2
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public long sin { get; set; }
        public double salary { get; set; }

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{firstName,10} {"|",10} {lastName,15} {"|",10} {address,30} {"|",10} {sin,10} {"|",10} {salary,10} ";
        }

        public double bound(int a)
        {
            return (salary*a)/100;
        }
    }
}