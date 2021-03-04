using System;

namespace MyCSharpIntermediate
{
    public class Person
    {
        //properties on the top
        //use prop + tab twice to create a auto-implemented property as short cut
        public string Name { get;  set; }
        public string Username { get; set; }
        //the simplest is to auto-implemented properties:
        //the line  does all the work of previous codes below commented out
        public DateTime Birthdate { get; private set; }//after putting private in front of set, 

        //use ctro + tab to create the Person constructor
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //age cannot be auto-implemented, because there is logic for this property
        //age is based on the date of the birthdate, so there is no set method for Age
        public int Age
        {
            get
            {
                //age can only get, not set because age is changed through years
                //so age cannot be an auto-implemented property
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
/*
        //simply the code below:
        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }*/

        /*        private DateTime _birthdate;
                public void SetBirthdate(DateTime birthdate)
                {
                    _birthdate = birthdate;

                }

                public DateTime GetBirthdate()
                {
                    return _birthdate;
                }*/
    }
}
