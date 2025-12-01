# How to Filter the Dropdown Items in WinForms SfComboBox
This repository demonstrates how to filter items in the Syncfusion WinForms **SfComboBox** control using its built-in filtering feature. The SfComboBox is a modern replacement for the standard ComboBox, offering advanced features such as **data binding**, **auto-complete**, and **customizable filtering** logic. Filtering allows you to display only relevant items based on user-defined conditions, improving usability and performance in applications with large datasets.

## Key Features Demonstrated in This Sample
- Apply custom filtering logic using the Filter property of DropDownListView.
- Refresh the filter dynamically at runtime.
- Use predicates to determine which items should be visible in the dropdown.
    
## How Filtering Works
The _Filter_ property accepts a **predicate** that is evaluated for each item in the data source.
- If the predicate returns _true_, the item remains visible.
- If it returns _false_, the item is hidden.

This approach provides flexibility to implement complex filtering scenarios such as:
- Prefix matching
- Substring search
- Conditional visibility based on multiple fields

## Example Code (C#)
```C#
public Form1()
{
    InitializeComponent();

    List<USState> list = GetData();
    this.sfComboBox1.DataSource = list;
    this.sfComboBox1.DisplayMember = "LongName";
    this.sfComboBox1.ThemeName = "Office2016Colorful";
    this.sfComboBox1.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);

    // Apply filter
    sfComboBox1.DropDownListView.View.Filter = FilterItem;
    sfComboBox1.DropDownListView.View.RefreshFilter();
}

// Filter predicate
private bool FilterItem(object data)
{
    return (data as USState).LongName.StartsWith("C");
}
```
This sample filters the dropdown items so that only states starting with the letter "C" are displayed. You can modify the predicate to implement custom logic such as filtering by length, region, or any other property.

## Reference
For more details, refer to the official UG documentation: [Filtering in Windows Forms SfComboBox](https://help.syncfusion.com/windowsforms/combobox/filtering) 
