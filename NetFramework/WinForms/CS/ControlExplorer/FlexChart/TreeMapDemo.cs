using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;

namespace ControlExplorer.FlexChart
{
    public partial class TreeMapDemo : C1DemoForm
    {
        public TreeMapDemo()
        {
            InitializeComponent();
            treeMap = new TreeMap()
            {
                Dock = DockStyle.Fill,
                Visible = true,
                BackColor = Color.White,
            };
            Controls.Add(treeMap);

            treeMap.BeginUpdate();

            treeMap.DataSource = GetData();
            treeMap.Binding = "sales";
            treeMap.BindingName = "type";
            treeMap.ChildItemsPath = "items";
            treeMap.DataLabel.Style.StrokeColor = Color.White;
            treeMap.DataLabel.Content = "{type}";
            treeMap.Palette = C1.Chart.Palette.Dark;
            treeMap.MaxDepth = 2;

            treeMap.EndUpdate();
        }

        private void TreeMapDemo_Load(object sender, EventArgs e)
        {
            // Add demo properties
            AddProperty("MaxDepth", treeMap);
            AddProperty("Palette", treeMap);
            AddProperty("ChartType", treeMap);
        }

        #region ** fill data
        Random rnd = new Random();

        int rand()
        {
            return rnd.Next(10, 100);
        }

        object GetData()
        {
            var data = new object[] { new {
            type = "Music",
            items = new [] { new {
                type = "Country",
                items= new [] { new {
                    type= "Classic Country",
                    sales = rand()
                }, new {
                    type= "Cowboy Country",
                    sales= rand()
                 }, new {
                    type= "Outlaw Country",
                    sales= rand()
                 }, new {
                    type= "Western Swing",
                    sales= rand()
                 }, new {
                    type= "Roadhouse Country",
                    sales= rand()
                 } }
            }, new {
                type= "Rock",
                items= new [] { new {
                    type= "Hard Rock",
                    sales= rand()
                }, new {
                    type= "Blues Rock",
                    sales= rand()
                 }, new {
                    type= "Funk Rock",
                    sales= rand()
                 }, new {
                    type= "Rap Rock",
                    sales= rand()
                 }, new {
                    type= "Guitar Rock",
                    sales= rand()
                 }, new {
                    type= "Progressive Rock",
                    sales= rand()
                 } }
            }, new {
                type= "Classical",
                items= new [] { new {
                    type= "Symphonies",
                    sales= rand()
                    }, new {
                    type= "Chamber Music",
          sales= rand()
                 } }
      }, new {
                type= "Soundtracks",
        items = new [] { new {
                    type= "Movie Soundtracks",
          sales= rand()
        }, new {
                    type= "Musical Soundtracks",
          sales= rand()
                 } }
      }, new {
                type= "Jazz",
        items= new [] { new {
                    type= "Smooth Jazz",
          sales= rand()
        }, new {
                    type= "Vocal Jazz",
          sales= rand()
                 }, new {
                    type= "Jazz Fusion",
          sales= rand()
                 }, new {
                    type= "Swing Jazz",
          sales= rand()
                 }, new {
                    type= "Cool Jazz",
          sales= rand()
                 }, new {
                    type= "Traditional Jazz",
          sales= rand()
                 } }
      }, new {
                type= "Electronic",
        items = new [] { new {
                    type= "Electronica",
          sales= rand()
        }, new {
                    type= "Disco",
          sales= rand()
                 }, new {
                    type= "House",
          sales= rand()
                 } }
      } }
    }, new {
            type= "Video",
      items = new [] { new {
                type= "Movie",
        items= new [] { new {
                    type= "Kid & Family",
          sales= rand()
        }, new {
                    type= "Action & Adventure",
          sales= rand()
                 }, new {
                    type= "Animation",
          sales= rand()
                 }, new {
                    type= "Comedy",
          sales= rand()
                 }, new {
                    type= "Drama",
          sales= rand()
                 }, new {
                    type= "Romance",
          sales= rand()
                 } }
      }, new {
                type= "TV",
        items= new [] { new {
                    type= "Science Fiction",
          sales= rand()
        }, new {
                    type= "Documentary",
          sales= rand()
                 }, new {
                    type= "Fantasy",
          sales= rand()
                 }, new {
                    type= "Military & War",
          sales= rand()
                 }, new {
                    type= "Horror",
          sales= rand()
                 } }
      } }
    }, new {
            type= "Books",
      items= new [] { new {
                type= "Arts & Photography",
        items= new [] { new {
                    type= "Architecture",
          sales= rand()
        }, new {
                    type= "Graphic Design",
          sales= rand()
                 }, new {
                    type= "Drawing",
          sales= rand()
                 }, new {
                    type= "Photography",
          sales= rand()
                 }, new {
                    type= "Performing Arts",
          sales= rand()
                 } }
      }, new {
                type= "Children's Books",
        items= new [] { new {
                    type= "Beginning Readers",
          sales= rand()
        }, new {
                    type= "Board Books",
          sales= rand()
                 }, new {
                    type= "Chapter Books",
          sales= rand()
                 }, new {
                    type= "Coloring Books",
          sales= rand()
                 }, new {
                    type= "Picture Books",
          sales= rand()
                 }, new {
                    type= "Sound Books",
          sales= rand()
                 } }
      }, new {
                type= "History",
        items= new [] { new {
                    type= "Ancient",
          sales= rand()
        }, new {
                    type= "Medieval",
          sales= rand()
                 }, new {
                    type= "Renaissance",
          sales= rand()
                 } }
      }, new {
                type= "Mystery",
        items= new [] { new {
                    type= "Mystery",
          sales= rand()
        }, new {
                    type= "Thriller & Suspense",
          sales= rand()
                 } }
      }, new {
                type= "Romance",
        items= new [] {  new {
                    type= "Action & Adventure",
          sales= rand()
        }, new {
                    type= "Holidays",
          sales= rand()
                 }, new {
                    type= "Romantic Comedy",
          sales= rand()
                 }, new {
                    type= "Romantic Suspense",
          sales= rand()
                 }, new {
                    type= "Western",
          sales= rand()
                 }, new {
                    type= "Historical",
          sales= rand()
                 } }
      }, new {
                type= "Sci-Fi & Fantasy",
        items= new [] { new {
                    type= "Fantasy",
          sales= rand()
        }, new {
                    type= "Gaming",
          sales= rand()
                 }, new {
                    type= "Science Fiction",
          sales= rand()
                 } }
      } }
    }, new {
            type= "Electronics",
      items= new object [] { new {
                type= "Camera",
        items= new [] { new {
                    type= "Digital Cameras",
          sales= rand()
        }, new {
                    type= "Film Photography",
          sales= rand()
                 }, new {
                    type= "Lenses",
          sales= rand()
                 }, new {
                    type= "Video",
          sales= rand()
                 }, new {
                    type= "Accessories",
          sales= rand()
                 } }
      }, new {
                type= "Headphones",
        items= new [] { new {
                    type= "Earbud headphones",
          sales= rand()
        }, new {
                    type= "Over-ear headphones",
          sales= rand()
                 }, new {
                    type= "On-ear headphones",
          sales= rand()
                 }, new {
                    type= "Bluetooth headphones",
          sales= rand()
                 }, new {
                    type= "Noise-cancelling headphones",
          sales= rand()
                 }, new {
                    type= "Audiophile headphones",
          sales= rand()
                 } }
      }, new {
                type= "Cell Phones",
        items= new object [] { new {
                    type= "Cell Phones",
          sales= rand()
        }, new {
                    type= "Accessories",
          items= new [] { new {
                        type= "Batteries",
            sales= rand()
          }, new {
                        type= "Bluetooth Headsets",
            sales= rand()
                     }, new {
                        type= "Bluetooth Speakers",
            sales= rand()
                     }, new {
                        type= "Chargers",
            sales= rand()
                     }, new {
                        type= "Screen Protectors",
            sales= rand()
                     } }
        } }
      }, new {
                type= "Wearable Technology",
        items= new [] { new {
                    type= "Activity Trackers",
          sales= rand()
        }, new {
                    type= "Smart Watches",
          sales= rand()
                 },  new {
                    type= "Sports & GPS Watches",
          sales= rand()
                 }, new {
                    type= "Virtual Reality Headsets",
          sales= rand()
                 }, new {
                    type= "Wearable Cameras",
          sales= rand()
                 }, new {
                    type= "Smart Glasses",
          sales= rand()
                 } }
      } }
    }, new {
            type= "Computers & Tablets",
      items= new [] { new {
                type= "Desktops",
        items= new [] { new {
                    type= "All-in-ones",
          sales= rand()
        }, new {
                    type= "Minis",
          sales= rand()
                 }, new {
                    type= "Towers",
          sales= rand()
                 } }
      }, new {
                type= "Laptops",
        items = new [] { new  {
                    type= "2 in 1 laptops",
          sales= rand()
        }, new {
                    type= "Traditional laptops",
          sales= rand()
                 } }
      }, new {
                type= "Tablets",
        items= new [] { new {
                    type= "iOS",
          sales= rand()
        }, new {
                    type= "Andriod",
          sales= rand()
                 }, new {
                    type= "Fire os",
          sales= rand()
                 }, new {
                    type= "Windows",
          sales= rand()
                 } }
      } }
    } };
            return data;
        }
        #endregion
    }
}
