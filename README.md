# How-to-filter-the-dropdown-items-in-Winforms-SfComboBox
The Windows Forms ComboBox (SfComboBox) support you to filter the items by setting the Filter property of `DropDownListView` to a predicate that will be called for every data item to determine whether the item is visible or not.

# C#

         public Form1()
            {
                InitializeComponent();

                List<USState> list = GetData();
                this.sfComboBox1.DataSource = list;
                this.sfComboBox1.DisplayMember = "LongName";
                this.sfComboBox1.ThemeName = "Office2016Colorful";
                this.sfComboBox1.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);

                // Filter
                sfComboBox1.DropDownListView.View.Filter = FilterItem;
                sfComboBox1.DropDownListView.View.RefreshFilter();
            }

            // Filter predicate
            private bool FilterItem(object data)
            {
                if ((data as USState).LongName.StartsWith("C"))
                    return true;
                return false;
            }

UG link: https://help.syncfusion.com/windowsforms/combobox/filtering
