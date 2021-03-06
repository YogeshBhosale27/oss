using System;


namespace HelloWorldApp
{
    internal class Person
    {
        //Shared Variable
        public static int count;

        // data members
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string contactNumber;
        private string email;
        public string Location { get; set; }
        public string Description{get; set;}
        // member function
        //Constructor overloading
        public Person() {
            count++;
        }
        public Person(string fName, string lName, DateTime bDate, string contact, string email)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthDate = bDate;
            this.contactNumber = contact;   
            this.email = email;
            count++;
        }


        public static int GetCount()
        {
            return count;
        }
        ~Person()
        {
            // clean up code for instance

        }

        public override string ToString()
        {
            return base.ToString() + " : "+ this.firstName + " "+ 
                this.lastName + " "+ this.birthDate + " "+
                this.contactNumber + " " + this.email;
        }
    }
}
