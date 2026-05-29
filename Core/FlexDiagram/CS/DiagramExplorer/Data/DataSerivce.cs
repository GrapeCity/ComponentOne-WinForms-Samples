using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Data
{
    #region Sample Data Classes

    // Simple hierarchical organization node
    public class OrgNode
    {
        Image? image = null;
        bool imageLoaded = false;

        public required string Name { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public required string Department { get; set; }

        public string? JobTitle { get; set; }
        public List<OrgNode> Childs { get; set; } = [];

        public Image? Image
        {
            get
            {
                if (!imageLoaded)
                {
                    var stream = DataService.GetResourceStream(Name.Replace(' ', '_') + ".png");
                    if(stream != null)
                        image = Image.FromStream(stream);
                    imageLoaded = true;
                }

                return image;
            }
        }
    }

    public class Country
    {
        public required string World { get; set; }
        public required string Continent { get; set; }
        public required string Region { get; set; }

        public required string Name { get; set; }
        public required string Code { get; set; }

        Image? flag;

        public Image? Flag
        {
            get
            {
                if (flag == null)
                {
                    var stream = DataService.GetResourceStream($"flags.{Code}.png");
                    if (stream != null)
                        flag = Image.FromStream(stream);
                }

                return flag;
            }
        }
    }

    public class Animal
    {
        Image? image = null;

        public required string Name { get; set; }
        public required string NameScientific { get; set; }

        public required string Phylum { get; set; }

        public required string Class { get; set; }

        public required string Order { get; set; }

        public Image? Image
        {
            get
            {
                if (image == null)
                {
                    var stream = DataService.GetResourceStream(Name.Replace(' ', '_') + ".png");
                    if (stream != null)
                        image = Image.FromStream(stream);
                }

                return image;
            }
        }
    }
    #endregion

    public class DataService
    {
        public static Stream? GetResourceStream(string name)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream($"{asm.GetName().Name}.Resources.{name}");
        }

        readonly List<OrgNode> orgData = [];

        public List<OrgNode> GetOrgChartData()
        {
            if (orgData.Count == 0)
            {
                var company = new OrgNode
                {
                    Name = "Acme Corporation",
                    Department = "CEO",
                    Childs =
                    [
                        new()
                    {
                        FirstName = "Sarah",
                        LastName = "Mitchell",
                        Department = "CEO",
                        Name = "Sarah Mitchell",
                        JobTitle = "CEO",
                        Childs =
                        [
                            new()
                            {
                                FirstName = "David",
                                LastName = "Chen",
                                Name = "David Chen",
                                Department = "Engineering",
                                JobTitle = "VP Engineering",
                                Childs =
                                [
                                    new()
                                    {
                                        FirstName = "Amanda",
                                        LastName = "Rodriguez",
                                        Department = "Engineering",
                                        Name = "Amanda Rodriguez",
                                        JobTitle = "Engineering Manager",
                                        Childs =
                                        [
                                            new()
                                            {
                                                FirstName = "John",
                                                LastName = "Smith",
                                                Department = "Engineering",
                                                Name = "John Smith",
                                                JobTitle = "Senior Software Engineer"
                                            },
                                            new()
                                            {
                                                FirstName = "Lisa",
                                                LastName = "Wang",
                                                Department = "Engineering",
                                                Name = "Lisa Wang",
                                                JobTitle = "Software Engineer"
                                            },
                                            new()
                                            {
                                                FirstName = "Michael",
                                                LastName = "Brown",
                                                Department = "Engineering",
                                                Name = "Michael Brown",
                                                JobTitle = "Software Engineer"
                                            }
                                        ]
                                    },
                                    new()
                                    {
                                        FirstName = "Robert",
                                        LastName = "Taylor",
                                        Department = "Engineering",
                                        Name = "Robert Taylor",
                                        JobTitle = "QA Manager",
                                        Childs =
                                        [
                                            new()
                                            {
                                                FirstName = "Emma",
                                                LastName = "Wilson",
                                                Department = "Engineering",
                                                Name = "Emma Wilson",
                                                JobTitle = "QA Engineer"
                                            },
                                            new()
                                            {
                                                FirstName = "Chris",
                                                LastName = "Anderson",
                                                Department = "Engineering",
                                                Name = "Chris Anderson",
                                                JobTitle = "QA Engineer"
                                            }
                                        ]
                                    }
                                ]
                            },
                            new()
                            {
                                FirstName = "Jennifer",
                                LastName = "Williams",
                                Name = "Jennifer Williams",
                                JobTitle = "VP Product",
                                Department = "Product",
                                Childs =
                                [
                                    new()
                                    {
                                        FirstName = "Andrew",
                                        LastName = "Miller",
                                        Department = "Product",
                                        Name = "Andrew Miller",
                                        JobTitle = "Senior Product Manager",
                                        Childs =
                                        [
                                            new()
                                            {
                                                FirstName = "Nicole",
                                                LastName = "Harris",
                                                Department = "Product",
                                                Name = "Nicole Harris",
                                                JobTitle = "Product Manager"
                                            },
                                            new()
                                            {
                                                FirstName = "Brian",
                                                LastName = "Clark",
                                                Department = "Product",
                                                Name = "Brian Clark",
                                                JobTitle = "Product Manager"
                                            }
                                        ]
                                    },
                                    new()
                                    {
                                        FirstName = "Sophia",
                                        LastName = "Lewis",
                                        Department = "Product",
                                        Name = "Sophia Lewis",
                                        JobTitle = "Design Lead",
                                        Childs =
                                        [
                                            new()
                                            {
                                                FirstName = "Mark",
                                                LastName = "Robinson",
                                                Department = "Product",
                                                Name = "Mark Robinson",
                                                JobTitle = "UX Designer"
                                            },
                                            new()
                                            {
                                                FirstName = "Laura",
                                                LastName = "Walker",
                                                Department = "Product",
                                                Name = "Laura Walker",
                                                JobTitle = "UI Designer"
                                            }
                                        ]
                                    }
                                ]
                            },
                            new()
                            {
                                FirstName = "Thomas",
                                LastName = "Anderson",
                                Name = "Thomas Anderson",
                                JobTitle = "VP Sales & Marketing",
                                Department = "Sales",
                                Childs =
                                [
                                    new()
                                    {
                                        FirstName = "Karen",
                                        LastName = "White",
                                        Name = "Karen White",
                                        Department = "Sales",
                                        JobTitle = "Sales Director",
                                        Childs =
                                        [
                                            new()
                                            {
                                                FirstName = "Paul",
                                                LastName = "Martinez",
                                                Department = "Sales",
                                                Name = "Paul Martinez",
                                                JobTitle = "Account Executive"
                                            },
                                            new()
                                            {
                                                FirstName = "Rebecca",
                                                LastName = "Young",
                                                Department = "Sales",
                                                Name = "Rebecca Young",
                                                JobTitle = "Account Executive"
                                            },
                                            new()
                                            {
                                                FirstName = "Frank",
                                                LastName = "Adams",
                                                Department = "Sales",
                                                Name = "Frank Adams",
                                                JobTitle = "Sales Engineer"
                                            }
                                        ]
                                    },
                                    new()
                                    {
                                        FirstName = "Linda",
                                        LastName = "Campbell",
                                        Department = "Sales",
                                        Name = "Linda Campbell",
                                        JobTitle = "Marketing Director",
                                        Childs =
                                        [
                                            new()
                                            {
                                                FirstName = "Eric",
                                                LastName = "Baker",
                                                Department = "Sales",
                                                Name = "Eric Baker",
                                                JobTitle = "Content Manager"
                                            },
                                            new()
                                            {
                                                FirstName = "Hannah",
                                                LastName = "Collins",
                                                Department = "Sales",
                                                Name = "Hannah Collins",
                                                JobTitle = "Marketing Specialist"
                                            }
                                        ]
                                    }
                                ]
                            }
                        ]
                    }
                    ]
                };

                orgData.Add(company);
            }

            return orgData;
        }

        readonly List<Country> countryData = [];

        public List<Country> GetCountryData()
        {
            if (countryData.Count == 0)
            {
                var stream = GetResourceStream("countries.csv");

                var text = "";
                if (stream != null)
                {
                    using var sr = new StreamReader(stream);
                    text = sr.ReadToEnd();
                }

                var ss = text.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ss.Length; i++)
                {
                    var values = ss[i].Split(',');
                    countryData.Add(new Country { World = "World", Continent = values[0], Region = values[1], Name = values[2], Code = values[3] });
                }
            }

            return countryData;
        }

        readonly List<Animal> animalData = [];

        public List<Animal> GetAnimals()
        {
            if (animalData.Count == 0)
            {
                var stream = DataService.GetResourceStream("animals10.csv");

                var text = "";
                if (stream != null)
                {
                    using var sr = new StreamReader(stream);
                    text = sr.ReadToEnd();
                }

                var ss = text.Split([Environment.NewLine], StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < ss.Length; i++)
                {
                    var values = ss[i].Split(',');
                    animalData.Add(new Animal { Name = values[0], NameScientific = values[1], Phylum = values[2], Class = values[3], Order = values[4] });
                }
            }

            return animalData;
        }
    }

}
