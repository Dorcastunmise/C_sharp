namespace Access;
class DNA
    {
        private string bloodgroup;
        private string genotype;

        /*
            Instead of these:
            public string BloodGroup
            {
                get { return bloodgroup; }
                //value is a default keyword that represents the value being assigned to the property, in this case, it represents the value being assigned to the BloodGroup property.
                set => bloodgroup = !string.IsNullOrEmpty(value) ? value :  "Invalid Blood Group supplied!";
                    
            }

            public string Genotype{ get => genotype; set => genotype = value;}

            you can use this:
            public string BloodGroup { get; set; }
            public string Genotype { get; set; }

            and this private fields won't be needed, as the compiler 
            creates a private anonymous backing field that can only be
            accessed through the property's get and set accessors.
            But you won't be able to add any validation to the 
            properties, and you won't be able to control how the 
            properties are accessed and modified, which can lead to
            potential issues with data integrity and security.
            private string bloodgroup;
            private string genotype;
        */
        public string BloodGroup
        {
            get { return bloodgroup; }
            //value is a default keyword that represents the value being assigned to the property, in this case, it represents the value being assigned to the BloodGroup property.
            set => bloodgroup = !string.IsNullOrEmpty(value) ? value :  "Invalid Blood Group supplied!";
                  
        }

        public string Genotype{ get => genotype; set => genotype = value;}

        public DNA(string bloodgroup, string genotype)
        {
            /*
            this.bloodgroup = bloodgroup;
            this.genotype = genotype;
            */
            BloodGroup = bloodgroup;
            Genotype = genotype;
        }

        public void SetBloodGroup(string bloodgroup)
        {
            this.bloodgroup = (!string.IsNullOrEmpty(bloodgroup)) ? bloodgroup :  "Invalid Blood Group supplied!";
        }

        //kewyword return is not used in this arrow function, 
        // because the function is a single expression, 
        // and it will appear as a data type close to the variable
        // e.g public string GetBloodGroup() => return $bloodgroup; 
        // and the value of the expression is automatically returned.
        public string GetBloodGroup() => bloodgroup;

        public void SetGenotype(string genotype)
        {
            if(!string.IsNullOrEmpty(genotype)) this.genotype = genotype;
            //else this.genotype = string.Empty;
            else this.genotype = "Invalid Genotype supplied!";
        }

        
        public string GetGenotype()
        {
            return genotype;
        }
        
        public string ReturnMedicalDetails()
        {
           
            return $"Blood Group: {BloodGroup}, \t Genotype: {Genotype}";
        }

        public override string ToString()
        {
            return $"Blood Group: {BloodGroup}, \t Genotype: {Genotype}";
        }

        public override bool Equals(object obj)
        {
            /*
                is keyword is used to check if the object is of a specific type, 
                 in this case, it checks if the object is of type DNA, 
                 and it returns true if the object is of type DNA, 
                 and false if it is not.
            */
            if(obj is DNA){
                /*
                    as keyword is used to perform a safe type conversion, 
                     it returns null if the conversion fails instead of 
                     throwing an exception, so we can check if the conversion was 
                     successful before accessing the properties of the object.
                */
                DNA dna_template = obj as DNA;
                return Genotype.Equals(dna_template.Genotype) && BloodGroup.Equals(dna_template.BloodGroup);
            }
            return false;
        }
    }

public class Class1
{
    //for struct, we can use constructor to initialize the 
    //fields, or we can use object initializer to initialize 
    // the fields, but we cannot use method parameters to 
    //initialize the fields, because struct is a value 
    // type and it is passed by value, so the changes made to
    // the parameters inside the method will not affect the 
    // original struct.
    // struct is usually used for small data structures that have value semantics, 
    // while class is used for larger and more complex data structures that have reference semantics.
    struct Person
    {
        public string name;
        public int age;
        public int birthMonth;
        public int birthDay;
        public int birthYear;

        
        public Person(string name, int age)
        {
            this.name = name;   
            this.age = age;
        }
    }

    class PersonProgram
    {
        public string studentNames;
        public int studentAge;

        //classes have a default constructor that initializes the fields to their default values,
        // but we can also define our own constructor to initialize the fields to specific values.

        public PersonProgram(string studentNames, int studentAge)
        {
            this.studentNames = studentNames;
            this.studentAge = studentAge;
        }

        //Aside from the default constructor, 
        // we can break it down into multiple constructors with 
        // different parameters, this is called constructor overloading.
        public PersonProgram(string studentNames)
        {
            this.studentNames = studentNames;
            this.studentAge = 0; // default value for age
        }  
        public PersonProgram(int studentAge)
        {
            this.studentNames = ""; // default value for name
            this.studentAge = studentAge;
        }
        public PersonProgram()
        {
            this.studentNames = ""; // default value for name
            this.studentAge = 0; // default value for age
        }

        public string ReturnDetails()
        {
            return $"Name: {studentNames}, Age: {studentAge}";
        }
    }
    
    static void Main(string[] args)
    {
        /*
        //Person person = CreatePerson("", 0, 0, 0, 0);
        //Person person = CreatePerson();
        Person person = new Person("Alice", 30);
        PersonProgram personProgram = new PersonProgram("James", 30);
        Console.WriteLine(ReturnDetails(person));
        Console.WriteLine();
        Console.WriteLine(personProgram.ReturnDetails());
        
        PersonProgram personProgram1 = new PersonProgram("John", 25);
        Console.WriteLine($"Name: {personProgram1.studentNames}, Age: {personProgram1.studentAge}");
        Console.WriteLine();
        PersonProgram personProgram2 = new PersonProgram("Jane");
        Console.WriteLine($"Name: {personProgram2.studentNames}, Age: {personProgram2.studentAge}");
        Console.WriteLine();
        PersonProgram personProgram3 = new PersonProgram(30);
        Console.WriteLine($"Name: {personProgram3.studentNames}, Age: {personProgram3.studentAge}");

        //DNA
        DNA dna_structure = new DNA("AB","O");
        string bloodBefore = dna_structure.BloodGroup = "A";
        string GenotypeBefore = dna_structure.Genotype = "AS";
        dna_structure.SetBloodGroup("ABO");
        Console.WriteLine(dna_structure.ReturnMedicalDetails());
        dna_structure.SetGenotype("AA");
        Console.WriteLine($"Your genotype before was {GenotypeBefore} now it is {dna_structure.GetGenotype()} and your blood group before was {bloodBefore} now it is {dna_structure.GetBloodGroup()}");
        Console.WriteLine("setter------");
        dna_structure.BloodGroup = "A";
        dna_structure.Genotype = "AS";
        Console.WriteLine($"Your blood group is {dna_structure.BloodGroup} and your genotype is {dna_structure.Genotype}");
       */
        DNA dna_structure = new DNA("AB","O");
        DNA dna_structure2 = new DNA("AB","O");
        Console.WriteLine(dna_structure);
        Console.WriteLine(dna_structure.ToString());

        if (dna_structure.Equals(dna_structure2)) Console.WriteLine("The object is a DNA instance.");
        else Console.WriteLine("The object is not a DNA instance.");
    }

    static string ReturnDetails(Person person)
    {
        return $"Name: {person.name}, Age: {person.age}, Birth Month: {person.birthMonth}, Birth Day: {person.birthDay}, Birth Year: {person.birthYear}";
    }
    
    static Person CreatePerson()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        return new Person(name, age);
    }

    /*
    static Person CreatePerson(string name, int age, int birthMonth, int birthDay, int birthYear)
    {
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Enter your birth month: ");
        birthMonth = int.Parse(Console.ReadLine());
        Console.Write("Enter your birth day: ");
        birthDay = int.Parse(Console.ReadLine());
        Console.Write("Enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());

        Person person;
        person.name = name;
        person.age = age;
        person.birthMonth = birthMonth;
        person.birthDay = birthDay;
        person.birthYear = birthYear;

        return person;
    }
    */
}
