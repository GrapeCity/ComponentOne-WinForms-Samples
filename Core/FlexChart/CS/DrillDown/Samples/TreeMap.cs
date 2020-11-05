using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace DrillDown.Samples
{
    public partial class TreeMap : UserControl
    {
        System.Collections.Stack history = new System.Collections.Stack();
        System.Collections.Stack historyType = new System.Collections.Stack();
        public TreeMap()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        void SetupChart()
        {
            treeMap = new C1.Win.Chart.TreeMap();
            treeMap.BeginUpdate();
            treeMap.Dock = DockStyle.Fill;
            treeMap.BackColor = Color.White;
            treeMap.DataSource = GetData();
            treeMap.Binding = "Sales";
            treeMap.BindingName = "Type";
            treeMap.ChildItemsPath = "Items";
            treeMap.DataLabel.Style.StrokeColor = Color.White;
            treeMap.DataLabel.Content = "{Type}";
            treeMap.MaxDepth = 1;
            historyType.Push(treeMap.Header.Content);
            treeMap.EndUpdate();

            baseSample1.pChart.Controls.Clear();
            baseSample1.pChart.Controls.Add(treeMap);
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("treemap", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("treemap", "description").MakeRtf();
        }

        void GoBack()
        {
            if (history.Count > 0)
            {
                treeMap.DataSource = history.Pop();
                historyType.Pop();
                treeMap.Header.Content = historyType.Peek().ToString();
            }
        }

        Random rnd = new Random();
        int Rand()
        {
            return rnd.Next(10, 100);
        }

        Leaf[] GetData()
        {
            var data = new Leaf[] {
                new Leaf {  Type = "Music",
                    Items = new [] {
                        new Leaf {  Type = "Country",
                            Items = new [] {
                                new Leaf {  Type= "Classic Country",    Sales= Rand()   },
                                new Leaf {  Type= "Cowboy Country",     Sales= Rand()   },
                                new Leaf {  Type= "Outlaw Country",     Sales= Rand()   },
                                new Leaf {  Type= "Western Swing",      Sales= Rand()   },
                                new Leaf {  Type= "Roadhouse Country",  Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Rock",
                            Items= new [] {
                                new Leaf {  Type= "Hard Rock",          Sales= Rand()   },
                                new Leaf {  Type= "Blues Rock",         Sales= Rand()   },
                                new Leaf {  Type= "Funk Rock",          Sales= Rand()   },
                                new Leaf {  Type= "Rap Rock",           Sales= Rand()   },
                                new Leaf {  Type= "Guitar Rock",        Sales= Rand()   },
                                new Leaf {  Type= "Progressive Rock",   Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Classical",
                            Items= new [] {
                                new Leaf {  Type= "Symphonies",         Sales= Rand()   },
                                new Leaf {  Type= "Chamber Music",      Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Soundtracks",
                            Items = new [] {
                                new Leaf {  Type= "Movie Soundtracks",  Sales= Rand()   },
                                new Leaf {  Type= "Musical Soundtracks",Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Jazz",
                            Items= new [] {
                                new Leaf {  Type= "Smooth Jazz",        Sales= Rand()   },
                                new Leaf {  Type= "Vocal Jazz",         Sales= Rand()   },
                                new Leaf {  Type= "Jazz Fusion",        Sales= Rand()   },
                                new Leaf {  Type= "Swing Jazz",         Sales= Rand()   },
                                new Leaf {  Type= "Cool Jazz",          Sales= Rand()   },
                                new Leaf {  Type= "Traditional Jazz",   Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Electronic",
                            Items = new [] {
                                new Leaf {  Type= "Electronica",        Sales= Rand()   },
                                new Leaf {  Type= "Disco",              Sales= Rand()   },
                                new Leaf {  Type= "House",              Sales= Rand()   }
                            }
                        }
                    }
                },
                new Leaf {  Type= "Video",
                    Items = new [] {
                        new Leaf {  Type= "Movie",
                            Items= new [] {
                                new Leaf {  Type= "Kid & Family",       Sales= Rand()   },
                                new Leaf {  Type= "Action & Adventure", Sales= Rand()   },
                                new Leaf {  Type= "Animation",          Sales= Rand()   },
                                new Leaf {  Type= "Comedy",             Sales= Rand()   },
                                new Leaf {  Type= "Drama",              Sales= Rand()   },
                                new Leaf {  Type= "Romance",            Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "TV",
                            Items= new [] {
                                new Leaf {  Type= "Science Fiction",    Sales= Rand()   },
                                new Leaf {  Type= "Documentary",        Sales= Rand()   },
                                new Leaf {  Type= "Fantasy",            Sales= Rand()   },
                                new Leaf {  Type= "Military & War",     Sales= Rand()   },
                                new Leaf {  Type= "Horror",             Sales= Rand()   }
                            }
                        }
                    }
                },
                new Leaf {  Type= "Books",
                    Items= new [] {
                        new Leaf {  Type= "Arts & Photography",
                            Items= new [] {
                                new Leaf {  Type= "Architecture",       Sales= Rand()   },
                                new Leaf {  Type= "Graphic Design",     Sales= Rand()   },
                                new Leaf {  Type= "Drawing",            Sales= Rand()   },
                                new Leaf {  Type= "Photography",        Sales= Rand()   },
                                new Leaf {  Type= "Performing Arts",    Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Children's Books",
                            Items= new [] {
                                new Leaf {  Type= "Beginning Readers",  Sales= Rand()   },
                                new Leaf {  Type= "Board Books",        Sales= Rand()   },
                                new Leaf {  Type= "Chapter Books",      Sales= Rand()   },
                                new Leaf {  Type= "Coloring Books",     Sales= Rand()   },
                                new Leaf {  Type= "Picture Books",      Sales= Rand()   },
                                new Leaf {  Type= "Sound Books",        Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "History",
                            Items= new [] {
                                new Leaf {  Type= "Ancient",            Sales= Rand()   },
                                new Leaf {  Type= "Medieval",           Sales= Rand()   },
                                new Leaf {  Type= "Renaissance",        Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Mystery",
                            Items= new [] {
                                new Leaf {  Type= "Mystery",            Sales= Rand()   },
                                new Leaf {  Type= "Thriller & Suspense",Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Romance",
                            Items= new [] {
                                new Leaf {  Type= "Action & Adventure", Sales= Rand()   },
                                new Leaf {  Type= "Holidays",           Sales= Rand()   },
                                new Leaf {  Type= "Romantic Comedy",    Sales= Rand()   },
                                new Leaf {  Type= "Romantic Suspense",  Sales= Rand()   },
                                new Leaf {  Type= "Western",            Sales= Rand()   },
                                new Leaf {  Type= "Historical",         Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Sci-Fi & Fantasy",
                            Items= new [] {
                                new Leaf {  Type= "Fantasy",            Sales= Rand()   },
                                new Leaf {  Type= "Gaming",             Sales= Rand()   },
                                new Leaf {  Type= "Science Fiction",    Sales= Rand()   }
                            }
                        }
                    }
                },
                new Leaf {  Type= "Electronics",
                    Items= new Leaf [] {
                        new Leaf {  Type= "Camera",
                            Items= new Leaf[] {
                                new Leaf {  Type= "Digital Cameras",    Sales= Rand()   },
                                new Leaf {  Type= "Film Photography",   Sales= Rand()   },
                                new Leaf {  Type= "Lenses",             Sales= Rand()   },
                                new Leaf {  Type= "Video",              Sales= Rand()   },
                                new Leaf {  Type= "Accessories",        Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Headphones",
                            Items= new Leaf[] {
                                new Leaf {  Type= "Earbud headphones",  Sales= Rand()   },
                                new Leaf {  Type= "Over-ear headphones",Sales= Rand()   },
                                new Leaf {  Type= "On-ear headphones",  Sales= Rand()   },
                                new Leaf {  Type= "Bluetooth headphones",Sales= Rand()  },
                                new Leaf {  Type= "Noise-cancelling headphones",Sales= Rand()   },
                                new Leaf {  Type= "Audiophile headphones",      Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Cell Phones",
                            Items= new Leaf [] {
                                new Leaf {  Type= "Cell Phones",        Sales= Rand()   },
                                new Leaf {  Type= "Accessories",
                                    Items = new Leaf[] {
                                        new Leaf {  Type= "Batteries",          Sales= Rand()   },
                                        new Leaf {  Type= "Bluetooth Headsets", Sales= Rand()   },
                                        new Leaf {  Type= "Bluetooth Speakers", Sales= Rand()   },
                                        new Leaf {  Type= "Chargers",           Sales= Rand()   },
                                        new Leaf {  Type= "Screen Protectors",  Sales= Rand()   }
                                    }
                                }
                            }
                        },
                        new Leaf {  Type= "Wearable Technology",
                            Items= new Leaf[] {
                                new Leaf {  Type= "Activity Trackers",          Sales= Rand()   },
                                new Leaf {  Type= "Smart Watches",              Sales= Rand()   },
                                new Leaf {  Type= "Sports & GPS Watches",       Sales= Rand()   },
                                new Leaf {  Type= "Virtual Reality Headsets",   Sales= Rand()   },
                                new Leaf {  Type= "Wearable Cameras",           Sales= Rand()   },
                                new Leaf {  Type= "Smart Glasses",              Sales= Rand()   }
                            }
                        }
                    }
                },
                new Leaf {  Type= "Computers & Tablets",
                    Items= new [] {
                        new Leaf {  Type= "Desktops",
                            Items= new Leaf[] {
                                new Leaf {  Type= "All-in-ones",    Sales= Rand()   },
                                new Leaf {  Type= "Minis",          Sales= Rand()   },
                                new Leaf {  Type= "Towers",         Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Laptops",
                            Items = new Leaf[] {
                                new Leaf {  Type= "2 in 1 laptops",         Sales= Rand()   },
                                new Leaf {  Type= "Traditional laptops",    Sales= Rand()   }
                            }
                        },
                        new Leaf {  Type= "Tablets",
                            Items= new [] {
                                new Leaf {  Type= "iOS",    Sales= Rand()   },
                                new Leaf {  Type= "Andriod",Sales= Rand()   },
                                new Leaf {  Type= "Fire os",Sales= Rand()   },
                                new Leaf {  Type= "Windows",Sales= Rand()   }
                            }
                        }
                    }
                }
            };
            return data;
        }
        public class Leaf
        {
            public string Type { get; set; }
            public Leaf[] Items { get; set; }
            public int Sales { get; set; }
        }
    }
}
