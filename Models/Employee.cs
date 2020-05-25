// Model that uses XML serializer.

using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic; // Used for List type

using System.Reflection; // Used for PropertyInfo

namespace employeePage.Models {
  public class Employee
    {
        /* Remember: Values can only get accessed if its public */
        public String name { get; set; }
        public String personalQuote { get; set; }
        public String description { get; set; }
        public String imgSrc { get; set; }

        public Employee()
        {
            name = "";
            personalQuote = "";
            description = "";
            imgSrc = "";
        }

        public void setJanuaryEmployee()
        {
            name = "Kevin Penamante";
            personalQuote = "Kevin has been able to prove time and time again that support others in their times of need. Kevin has stepped up as a student supervisor to not only support the Student Building Managers but help revamp and conduct new hire training multiple times.";
            description = "Kevin has been a reliable asset to the Reservations & Events Services Department by assisting all the different student positions that are in the department with the knowledge they has gained.";
            imgSrc = "https://www.csun.edu/sites/default/files/KevinPenamante.jpg";
        }

        public void setFebruaryEmployee()
        {
            name = "Amelia Sherman";
            personalQuote = "I nominate Amelia Sherman to be Student Employee of the Month because she puts her mind and effort to everything that she does and commits too.";
            description = "Amelia constantly shows passion and excitement in all she does and seeks more opportunities to advance the Oasis Wellness Center for the better of the CSUN community.";
            imgSrc = "https://www.csun.edu/sites/default/files/AmeliaSherman.jpg";
        }

        public void setMarchEmployee()
        {
            name = "Katie Gumberg";
            personalQuote = "Katie just transitioned from being the Student Events Assistant to the Student Operations Assistant within the Fitness Programs department.";
            description = "As the events assistant, she took on large programs within the SRC like I Work Out and recruited staff volunteers.";
            imgSrc = "https://www.csun.edu/sites/default/files/Katie_Gumberg.jpg";
        }
    } // End of Employee Class

    [Serializable()]
    public class EmployeeList {
        public List<Employee> employeeList { get; set; }

        public EmployeeList() {
            employeeList = new List<Employee>();
        }

        public void populateList() {
            Employee janEmployee = new Employee();
            janEmployee.setJanuaryEmployee();

            Employee febEmployee = new Employee();
            febEmployee.setFebruaryEmployee();

            Employee marchEmployee = new Employee();
            marchEmployee.setMarchEmployee();

            employeeList.Add(janEmployee);
            employeeList.Add(febEmployee);
            employeeList.Add(marchEmployee);
        }

        public void populateToXML() {
            // Simple example:
            // https://www.jonasjohn.de/snippets/csharp/xmlserializer-example.htm

            // Populate employeeList with objects
            populateList();

            // Create a new XmlSerializer instance with the type of the test class
            XmlSerializer SerializerObj = new XmlSerializer(typeof( List<Employee> )); // TestClass

            // Create a new file stream to write the serialized object to a file
            TextWriter WriteFileStream = new StreamWriter(@".\test.xml");
            SerializerObj.Serialize(WriteFileStream, employeeList ); // TestObj

            // Cleanup
            WriteFileStream.Close();

            Console.WriteLine("End of writing to XML");
        }

        public void populateFromXML() {
            // https://support.microsoft.com/en-us/help/815813/how-to-serialize-an-object-to-xml-by-using-visual-c

             // Create a new file stream for reading the XML file
            FileStream ReadFileStream = new FileStream(@".\test.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer SerializerObj = new XmlSerializer(typeof( List<Employee>  )); // TestClass
           
            // Load the employeeList object saved above by using the Deserialize function
            employeeList = (List<Employee>)SerializerObj.Deserialize(ReadFileStream);
            
            // Cleanup
            ReadFileStream.Close();
        }
    }
}