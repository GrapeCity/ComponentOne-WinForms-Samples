using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Data
{
    // Simple hierarchical organization node
    public class OrgNode
    {
        Image image = null;
        bool imageLoaded = false;

        public string Name { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }

        public string JobTitle { get; set; }
        public List<OrgNode> Childs { get; set; } = new List<OrgNode>();

        public Image Image
        {
            get
            {
                if (!imageLoaded)
                {
                    var stream = GetResourceStream(Name.Replace(' ', '_') + ".png");
                    //if(stream == null) 
                    //    stream = GetResourceStream("David_Chen.png");//  Name.Replace(' ', '_') + ".png");
                    if(stream != null)
                        image = Image.FromStream(stream);
                    imageLoaded = true;
                }

                return image;
            }
        }

        static Stream? GetResourceStream(string name)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream($"{asm.GetName().Name}.Resources.{name}");
        }
    }

    public class DataService
    {
        public List<OrgNode> GetOrgChartData()
        {
            var company = new OrgNode
            {
                Name = "Acme Corporation",
                Department = "CEO",
                Childs = new List<OrgNode>
                {
                    new OrgNode
                    {
                        FirstName = "Sarah",
                        LastName = "Mitchell",
                        Department = "CEO",
                        Name = "Sarah Mitchell",
                        JobTitle = "CEO",
                        Childs = new List<OrgNode>
                        {
                            new OrgNode
                            {
                                FirstName = "David",
                                LastName = "Chen",
                                Name = "David Chen",
                                Department = "Engineering",
                                JobTitle = "VP Engineering",
                                Childs = new List<OrgNode>
                                {
                                    new OrgNode
                                    {
                                        FirstName = "Amanda",
                                        LastName = "Rodriguez",
                                        Department = "Engineering",
                                        Name = "Amanda Rodriguez",
                                        JobTitle = "Engineering Manager",
                                        Childs = new List<OrgNode>
                                        {
                                            new OrgNode 
                                            {
                                                FirstName = "John",
                                                LastName = "Smith",
                                                Department = "Engineering",
                                                Name = "John Smith", 
                                                JobTitle = "Senior Software Engineer" 
                                            },
                                            new OrgNode 
                                            {
                                                FirstName = "Lisa",
                                                LastName = "Wang",
                                                Department = "Engineering",
                                                Name = "Lisa Wang", 
                                                JobTitle = "Software Engineer" 
                                            },
                                            new OrgNode 
                                            {
                                                FirstName = "Michael",
                                                LastName = "Brown",
                                                Department = "Engineering",
                                                Name = "Michael Brown", 
                                                JobTitle = "Software Engineer" 
                                            }
                                        }
                                    },
                                    new OrgNode
                                    {
                                        FirstName = "Robert",
                                        LastName = "Taylor",
                                        Department = "Engineering",
                                        Name = "Robert Taylor",
                                        JobTitle = "QA Manager",
                                        Childs = new List<OrgNode>
                                        {
                                            new OrgNode 
                                            { 
                                                FirstName = "Emma",
                                                LastName = "Wilson",
                                                Department = "Engineering",
                                                Name = "Emma Wilson", 
                                                JobTitle = "QA Engineer" 
                                            },
                                            new OrgNode 
                                            {
                                                FirstName = "Chris",
                                                LastName = "Anderson",
                                                Department = "Engineering",
                                                Name = "Chris Anderson", 
                                                JobTitle = "QA Engineer" 
                                            }
                                        }
                                    }
                                }
                            },
                            new OrgNode
                            {
                                FirstName = "Jennifer",
                                LastName = "Williams",
                                Name = "Jennifer Williams",
                                JobTitle = "VP Product",
                                Department = "Product",
                                Childs = new List<OrgNode>
                                {
                                    new OrgNode
                                    {
                                        FirstName = "Andrew",
                                        LastName = "Miller",
                                        Department = "Product",
                                        Name = "Andrew Miller",
                                        JobTitle = "Senior Product Manager",
                                        Childs = new List<OrgNode>
                                        {
                                            new OrgNode 
                                            {
                                                FirstName = "Nicole",
                                                LastName = "Harris",
                                                Department = "Product",
                                                Name = "Nicole Harris",
                                                JobTitle = "Product Manager" 
                                            },
                                            new OrgNode 
                                            {
                                                FirstName = "Brian",
                                                LastName = "Clark",
                                                Department = "Product",
                                                Name = "Brian Clark", 
                                                JobTitle = "Product Manager" 
                                            }
                                        }
                                    },
                                    new OrgNode
                                    {
                                        FirstName = "Sophia",
                                        LastName = "Lewis",
                                        Department = "Product",
                                        Name = "Sophia Lewis",
                                        JobTitle = "Design Lead",
                                        Childs = new List<OrgNode>
                                        {
                                            new OrgNode 
                                            {
                                                FirstName = "Mark",
                                                LastName = "Robinson",
                                                Department = "Product",
                                                Name = "Mark Robinson", 
                                                JobTitle = "UX Designer" 
                                            },
                                            new OrgNode 
                                            { 
                                                FirstName = "Laura",
                                                LastName = "Walker",
                                                Department = "Product",
                                                Name = "Laura Walker", 
                                                JobTitle = "UI Designer" 
                                            }
                                        }
                                    }
                                }
                            },
                            new OrgNode
                            {
                                FirstName = "Thomas",
                                LastName = "Anderson",
                                Name = "Thomas Anderson",
                                JobTitle = "VP Sales & Marketing",
                                Department = "Sales",
                                Childs = new List<OrgNode>
                                {
                                    new OrgNode
                                    {
                                        FirstName = "Karen",
                                        LastName = "White",
                                        Name = "Karen White",
                                        Department = "Sales",
                                        JobTitle = "Sales Director",
                                        Childs = new List<OrgNode>
                                        {
                                            new OrgNode 
                                            {
                                                FirstName = "Paul",
                                                LastName = "Martinez",
                                                Department = "Sales",
                                                Name = "Paul Martinez", 
                                                JobTitle = "Account Executive" 
                                            },
                                            new OrgNode 
                                            { 
                                                FirstName = "Rebecca",
                                                LastName = "Young",
                                                Department = "Sales",
                                                Name = "Rebecca Young", 
                                                JobTitle = "Account Executive" 
                                            },
                                            new OrgNode 
                                            { 
                                                FirstName = "Frank",
                                                LastName = "Adams",
                                                Department = "Sales",
                                                Name = "Frank Adams", 
                                                JobTitle = "Sales Engineer" 
                                            }
                                        }
                                    },
                                    new OrgNode
                                    {
                                        FirstName = "Linda",
                                        LastName = "Campbell",
                                        Department = "Sales",
                                        Name = "Linda Campbell",
                                        JobTitle = "Marketing Director",
                                        Childs = new List<OrgNode>
                                        {
                                            new OrgNode 
                                            {
                                                FirstName = "Eric",
                                                LastName = "Baker",
                                                Department = "Sales",
                                                Name = "Eric Baker", 
                                                JobTitle = "Content Manager" 
                                            },
                                            new OrgNode 
                                            {
                                                FirstName = "Hannah",
                                                LastName = "Collins",
                                                Department = "Sales",
                                                Name = "Hannah Collins", 
                                                JobTitle = "Marketing Specialist"
                                            }
                                        }
                                    }
                                }
                            },
                            //new OrgNode
                            //{
                            //    Name = "Richard Foster",
                            //    JobTitle = "CFO",
                            //    Childs = new List<OrgNode>
                            //    {
                            //        new OrgNode { Name = "Margaret Hughes", JobTitle = "Controller" },
                            //        new OrgNode { Name = "Peter Gray", JobTitle = "Senior Accountant" }
                            //    }
                            //},
                            //new OrgNode
                            //{
                            //    Name = "Catherine Brooks",
                            //    JobTitle = "VP Human Resources",
                            //    Childs = new List<OrgNode>
                            //    {
                            //        new OrgNode { Name = "Donald Ward", JobTitle = "HR Manager" },
                            //        new OrgNode { Name = "Monica Rivera", JobTitle = "Recruiter" }
                            //    }
                            //}
                        }
                    }
                }
            };

            return new List<OrgNode> { company };
        }
    }

    public class Animal
    {
        Image image = null;
        bool imageLoaded = false;

        public string Name { get; set; }
        public string NameScientific { get; set; }

        public string Phylum { get; set; }

        public string Class { get; set; }

        public string Order { get; set; }

        public Image Image
        {
            get
            {
                if (!imageLoaded)
                {
                    var stream = GetResourceStream(Name.Replace(' ', '_') + ".png");
                    //if(stream == null) 
                    //    stream = GetResourceStream("David_Chen.png");//  Name.Replace(' ', '_') + ".png");
                    if (stream != null)
                        image = Image.FromStream(stream);
                    imageLoaded = true;
                }

                return image;
            }
        }

        static Stream GetResourceStream(string name)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream($"{asm.GetName().Name}.Resources.{name}");
        }

    }

    public class AnimalData
    {
        public static List<Animal> GetAnimals()
        {
            var list = new List<Animal>();

            var stream = GetResourceStream("animals10.csv");

            var text = "";
            if (stream != null)
            {
                using (var sr = new StreamReader(stream))
                    text = sr.ReadToEnd();
            }

            var ss = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < ss.Length; i++)
            {
                var values = ss[i].Split(',');
                list.Add(new Animal { Name = values[0], NameScientific = values[1], Phylum = values[2], Class = values[3], Order = values[4] });
            }

            return list;
        }

        static Stream GetResourceStream(string name)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream($"{asm.GetName().Name}.Resources.{name}");
        }
    }
}
