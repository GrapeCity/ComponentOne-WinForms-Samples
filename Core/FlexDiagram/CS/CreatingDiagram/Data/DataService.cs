using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingDiagram.Data
{
    public class SalesDataItem
    {
        public string? Type { get; set; }
        public double Sales { get; set; }

        public SalesDataItem[]? Items { get; set; }
    }

    static class DataService
    {
        static Random rnd = new Random();
        static int rand() => rnd.Next(10, 100);

        public static SalesDataItem[] CreateHierarchicalData()
        {
            var data = new SalesDataItem[] {
                    new SalesDataItem {
                        Type = "Electronics",
                        Items = new SalesDataItem[] {
                            new SalesDataItem{
                                Type = "Camera",
                                Items = new SalesDataItem[]
                                {
                                        new SalesDataItem{ Type = "Digital", Sales = rand() },
                                        new SalesDataItem{ Type = "Film", Sales = rand() },
                                }
                            },
                            new SalesDataItem{
                                Type = "Headphones",
                                Items = new SalesDataItem[]
                                {
                                        new SalesDataItem{ Type = "Earbud", Sales = rand()},
                                        new SalesDataItem{ Type = "Over-ear", Sales = rand() },
                                        new SalesDataItem{ Type = "On-ear", Sales = rand() },
                                }
                            }
                        }
                    },
                    new SalesDataItem{
                        Type = "Computers\n& Tablets",
                        Items = new SalesDataItem[]
                        {
                            new SalesDataItem
                            {
                                Type = "Desktops",
                                Items = new SalesDataItem[]
                                {
                                    new SalesDataItem{ Type = "All-in-ones", Sales = rand() },
                                    new SalesDataItem{ Type = "Minis", Sales = rand()},
                                }
                            },
                            new SalesDataItem
                            {
                                Type = "Laptops",
                                Items = new SalesDataItem[]
                                {
                                    new SalesDataItem{ Type = "2 in 1", Sales = rand() },
                                    new SalesDataItem{ Type = "Traditional", Sales = rand() }
                                }
                            },
                        }
                    }
                };
            return data;
        }

        public static DataTable CreateSkillsTable()
        {
            // Create the DataTable
            DataTable skillsTable = new DataTable("SkillsHierarchy");

            // Define the columns
            skillsTable.Columns.Add("Field", typeof(string));
            skillsTable.Columns.Add("Domain", typeof(string));
            skillsTable.Columns.Add("Specialty", typeof(string));
            skillsTable.Columns.Add("Skill", typeof(string));

            // Set primary key
            //skillsTable.PrimaryKey = new DataColumn[] { skillsTable.Columns["skill_id"] };

            // Add the data rows
            skillsTable.Rows.Add("Field", "Domain", "Specialty", "Skill");
            skillsTable.Rows.Add("Technology", "Frontend", "JavaScript Frameworks", "React Development");
            skillsTable.Rows.Add("Technology", "Data Science", "Artificial Intelligence", "Machine Learning");
            skillsTable.Rows.Add("Technology", "Database", "Query Performance", "SQL Optimization");
            //skillsTable.Rows.Add(4, "Brand Strategy", "Marketing", "Strategy", "Brand Management", "Advanced", 5);
            //skillsTable.Rows.Add(5, "Content Writing", "Marketing", "Content", "Copywriting", "Intermediate", 3);
            //skillsTable.Rows.Add(6, "Financial Modeling", "Finance", "Analysis", "Investment Analysis", "Advanced", 4);
            //skillsTable.Rows.Add(7, "Tax Planning", "Finance", "Accounting", "Corporate Tax", "Expert", 7);
            //skillsTable.Rows.Add(8, "Contract Law", "Legal", "Corporate Law", "Business Contracts", "Expert", 8);
            //skillsTable.Rows.Add(9, "Project Management", "Management", "Operations", "Agile Methodology", "Advanced", 4);
            //skillsTable.Rows.Add(10, "Team Leadership", "Management", "People", "Leadership Development", "Intermediate", 3);
            skillsTable.Rows.Add( "Technology", "Backend", "Programming Languages", "Python Programming");
            skillsTable.Rows.Add("Technology", "Infrastructure", "AWS Solutions", "Cloud Architecture");
            //skillsTable.Rows.Add(13, "Digital Marketing", "Marketing", "Digital", "SEO/SEM", "Intermediate", 2);
            //skillsTable.Rows.Add(14, "Budget Analysis", "Finance", "Planning", "Cost Management", "Advanced", 4);
            //skillsTable.Rows.Add(15, "Employment Law", "Legal", "Human Resources", "Labor Relations", "Advanced", 6);

            return skillsTable;
        }
    }

}
