namespace WinFormSubcategories
{
    public partial class Form1 : Form
    {
        List<Category> categories;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateExamples();
            foreach (var cat in categories)
            {
                cmbCategories.Items.Add(cat.Name);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSubcategories.Items.Clear();
            cmbSubcategories.Text = "";

            int _selectedIndex = cmbCategories.SelectedIndex;
            if (_selectedIndex != -1) 
            {
                var _subcategories = categories[_selectedIndex].Subcategories;
                foreach (var subcategory in _subcategories)
                {
                    cmbSubcategories.Items.Add(subcategory.Name);
                }
            }
        }

        private void cmbSubcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectionViewer.Text = cmbSubcategories.SelectedItem.ToString();
        }

        private void CreateExamples()
        {
            categories = new List<Category>()
            {
                new Category()
                {
                    Name= "Programming",
                    Subcategories = new List<Subcategory>()
                    {
                        new Subcategory()
                        {
                            Name = "C#"
                        },
                        new Subcategory()
                        {
                            Name = "Java"
                        }
                    }
                },

                new Category()
                {
                    Name = "Database",
                    Subcategories = new List<Subcategory>()
                    {
                        new Subcategory()
                        {
                            Name = "SQL"
                        },
                        new Subcategory()
                        {
                            Name = "MongoDB"
                        }
                    }
                }
            };
        }
    }
}