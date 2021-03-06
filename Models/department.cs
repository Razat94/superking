using System;
using System.Collections.Generic; // Used for List type
using Newtonsoft.Json; // Newtonsoft JSON package.
using System.IO; // Used to input/output file contents


namespace departmentPage.Models
{
    public class Department
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }

        public string imgSrc { get; set; }

        public Department()
        {
            title = "";
            subtitle = "";
            p1 = "";
            p2 = "";
            imgSrc = "";
        }

        public void setProduce()
        {
            title = "Produce";
            subtitle = "Produce Palace!";
            p1 = "When our customers think Super King the first thing that comes to mind is Produce.";
            p2 = "We guarantee fresh produce and the lowest prices every day. Our produce variety includes strawberries, blueberries, avocados, the largest variety of eggplant anywhere and even pomegranates.";
            imgSrc = "/img/departments/1)Produce-image.jpg";
        }

        public void setMeat() 
        {
            title = "Meat and Seafood";
            subtitle = "Let us meat your needs.";
            p1 = "Our friendly butchers have years of experience and can always meet your needs. If you're on the move, our meats are also individually packaged and ready to go.</p>";
            p2 = "Our meat is delivered daily and always guaranteed fresh or your money back. If you are looking for a special cut or grade, feel free to ask us and we can order it for you. Fresh and premium quality seafood is what Super King takes pride in. Whether it is cooked or raw shrimp, fresh fillets, whole fish or crab meat, we carry it!";
            imgSrc = "/img/departments/2)meat-image.jpg";
        }

        public void setGrocery()
        {
            title = "Grocery";
            subtitle = "International Selection";
            p1 = "Our products include Middle Eastern, European, Latino and domestic brands, all with you and your family's needs in mind.";
            p2 = "Super King works with our suppliers to ensure you find the foods you want and always get a great value too!";
            imgSrc = "/img/departments/3)groceries-image.jpg";
        }

        public void setServiceDeli()
        {
            title = "Service Deli";
            subtitle = "Cuts from all around the world";
            p1 = "This amazing department features the widest variety of sliced to order international meat and cheese delights you will find anywhere.";
            p2 = "Items include imported salamis, hams, caviar, Mexican creams and cheeses. Our associates will slice your deli the way you want it and individually package the items.";
            imgSrc = "/img/departments/4)service-deli-image.jpg";
        }

        public void setServiceBakery()
        {
            title = "Service Bakery";
            subtitle = "Sweets you cannot resist!";
            p1 = "As you approach the store your senses instantly notice the delicious aromas of our Service Bakery.";
            p2 = "Mexican sweet breads, bolillos, crispy baguettes, French bread are being baked all day and served up fresh and hot to our customers. We have something to satisfy every customer. Do you have a special occasion coming up? Our cakes and pastries are unique in style and flavor. Talk with our decorators and design a special dessert just for your family.";
            imgSrc = "/img/departments/5)bakery-image.jpg";
        }

        public void setNuts()
        {
            title = "Mixed Nuts";
            subtitle = "Quality you can count on";
            p1 = "All of our nuts are imported directly and come fresh from the current harvest.";
            p2 = "Our unique mixed nut bar includes pistachios, colored almonds, peanuts, pine nuts, cashews, and even pumpkin seeds. You can also find chocolate almonds and gummy candies of all sorts.";
            imgSrc = "/img/departments/6)mixed-nuts-image.jpg";
        }

        public void setFrozenFoods()
        {
            title = "Deli & Frozen";
            subtitle = "Selection you can count on";
            p1 = "Our deli includes a wonderful selection of yogurt, fresh juices. Don't forget to grab your everyday staple items like milk, eggs and butter as well.";
            p2 = "Find delicious sandwich meats for cold cuts such as ham, turkey breast, and chicken. We have a wonderful variety of cheeses from provolone, Swiss, cheddar and pepper jack. You can also find international brands like King String Cheese and Cacique Queso Fresco.";
            imgSrc = "/img/departments/7)frozen-deli-image.jpg";
        }

    } // End of class department

    public class listOfDepartments {
        public List<Department> departmentList { get; set; }

        public listOfDepartments() {
            departmentList = new List<Department>();
        }

        // addToList is an unused function [You can delete this function if you wish]
        public void addToList ( Department dept) {
            departmentList.Add(dept);
        }

        public void populateList() {
            Department Produce = new Department();
            Produce.setProduce();

            Department Meat = new Department();
            Meat.setMeat();

            Department Grocery = new Department();
            Grocery.setGrocery();

            Department ServiceDeli = new Department();
            ServiceDeli.setServiceDeli();

            Department ServiceBakery = new Department(); 
            ServiceBakery.setServiceBakery();

            Department Nuts = new Department();
            Nuts.setNuts();

            Department Frozen = new Department();
            Frozen.setFrozenFoods();

            departmentList.Add(Produce);
            departmentList.Add(Meat);
            departmentList.Add(Grocery);
            departmentList.Add(ServiceDeli);
            departmentList.Add(ServiceBakery);
            departmentList.Add(Nuts);
            departmentList.Add(Frozen);
        }

        public void populateToJSON() {
            populateList();
            string jsonString = JsonConvert.SerializeObject(departmentList, Formatting.Indented);
            File.WriteAllText(@".\wwwroot\json\department-list.json", jsonString);
        }

        public void populateDepartmentListFromJSON() {
            departmentList = JsonConvert.DeserializeObject<List<Department>>(File.ReadAllText(@".\wwwroot\json\department-list.json"));
        }
    } // End of DepartmentList Class
}