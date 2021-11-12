#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : SfForm
    {
        #region constructor
        public Form1()
        {
            InitializeComponent();
            this.SfComboBoxSeetings();

            try
            {
#if NETCORE
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
#else
                Bitmap bmp = new Bitmap(Image.FromFile(@"../../Icon/sficon.ico"));
                this.Icon = Icon.FromHandle(bmp.GetHicon());
#endif
            }
            catch (Exception ex)
            { }
            this.panel1.Paint += Panel1_Paint;
            if (DpiAware.GetCurrentDpi() > 96)
            {
                this.MaximizeBox = true;
                this.panel1.Width = (int)(1 + (((DpiAware.GetCurrentDpi() / 96) - 1) / 2)) * this.panel1.Width + 70;
                this.Width = (int)(1 + (((DpiAware.GetCurrentDpi() / 96) - 1) / 2)) * this.Width + 100;
                this.themeComboBox.Height = (int)(1 + (((DpiAware.GetCurrentDpi() / 96) - 1) / 2)) * this.themeComboBox.Height + 5;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
        #endregion

        //Filter predicate
        private bool FilterItem(object data)
        {
            if ((data as USState).LongName.StartsWith("C"))
                return true;
            return false;
        }

        #region SfComboBoxSettings
        void SfComboBoxSeetings()
        {
            List<USState> list = GetData();

            this.sfComboBox1.DataSource = list;
            this.sfComboBox1.DisplayMember = "LongName";
            this.sfComboBox1.ThemeName = "Office2016Colorful";
            this.sfComboBox1.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);

            //Filter
            sfComboBox1.DropDownListView.View.Filter = FilterItem;
            sfComboBox1.DropDownListView.View.RefreshFilter();

            #region themeCombo
            List<ThemeTypes> theme = new List<ThemeTypes>();
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Black", Value = 0 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016White", Value = 0 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016DarkGray", Value = 0 });
            theme.Add(new ThemeTypes() { ThemeName = "Office2016Colorful", Value = 0 });
            this.themeComboBox.DataSource = theme;
            this.themeComboBox.DisplayMember = "ThemeName";
            this.themeComboBox.ValueMember = "ThemeName";
            this.themeComboBox.SelectedValue = "Office2016Colorful";
            this.themeComboBox.ThemeName = "Office2016Colorful";
            this.themeComboBox.DropDownStyle = DropDownStyle.DropDownList;
            this.themeComboBox.DropDownListView.Style.ItemStyle.Font = new Font("Microsoft Sans Serif", 9.75f);
            #endregion
        }

        #region GenerateData
        List<USState> GetData()
        {
            // DisplayMember is used to display just the long name of each state.
            List<USState> USStates = new List<USState>();
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AK", 3));
            USStates.Add(new USState("California", "CA", 4));
            USStates.Add(new USState("Colorado", "CO", 5));
            USStates.Add(new USState("Connecticut", "CT", 6));
            USStates.Add(new USState("Delaware", "DE", 3));
            USStates.Add(new USState("Florida", "FL", 4));
            USStates.Add(new USState("Georgia", "GA", 1));
            USStates.Add(new USState("Hawaii", "HI", 0));
            USStates.Add(new USState("Idaho", "ID", 3));
            USStates.Add(new USState("Illinois", "IL", 2));
            USStates.Add(new USState("Indiana", "IN", 6));
            USStates.Add(new USState("Iowa", "IA", 5));
            USStates.Add(new USState("Kansas", "KA", 5));
            USStates.Add(new USState("Kentucky", "KY", 4));
            USStates.Add(new USState("Louisiana", "LA", 3));
            USStates.Add(new USState("Maine", "ME", 0));
            USStates.Add(new USState("Maryland", "MD", 0));
            USStates.Add(new USState("Massachusetts", "MA", 2));
            USStates.Add(new USState("Michigan", "MI", 1));
            USStates.Add(new USState("Minnesota", "MN", 6));
            USStates.Add(new USState("Mississippi", "MS", 5));
            USStates.Add(new USState("Missouri", "MO", 2));
            USStates.Add(new USState("Montana", "MT", 1));
            USStates.Add(new USState("Nebraska", "NE", 4));
            USStates.Add(new USState("Nevada", "NV", 0));
            USStates.Add(new USState("New Hampshire", "NH", 3));
            USStates.Add(new USState("New Jersey", "NJ", 3));
            USStates.Add(new USState("New Mexico", "NM", 2));
            USStates.Add(new USState("New York", "NY", 5));
            USStates.Add(new USState("North Carolina", "NC", 4));
            USStates.Add(new USState("North Dakota", "ND", 4));
            USStates.Add(new USState("Ohio", "OH", 1));
            USStates.Add(new USState("Oklahoma", "OK", 2));
            USStates.Add(new USState("Oregon", "OR", 5));
            USStates.Add(new USState("Pennsylvania", "PA", 0));
            USStates.Add(new USState("Rhode Island", "RI", 6));
            USStates.Add(new USState("South Carolina", "SC", 5));
            USStates.Add(new USState("South Dakota", "SD", 4));
            USStates.Add(new USState("Tennessee", "TN", 3));
            USStates.Add(new USState("Texas", "TX", 2));
            USStates.Add(new USState("Utah", "UT", 0));
            USStates.Add(new USState("Vermont", "VT", 1));
            USStates.Add(new USState("Virginia", "VA", 0));
            USStates.Add(new USState("Washington", "WA", 2));
            USStates.Add(new USState("West Virginia", "WV", 0));
            USStates.Add(new USState("Wisconsin", "WI", 3));
            USStates.Add(new USState("Wyoming", "WY", 5));

            return USStates;
        }
        #endregion
        #endregion

        #region Events

        private void themeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.BeginUpdate();
            this.themeComboBox.ThemeName = this.themeComboBox.SelectedValue.ToString();
            this.sfComboBox1.ThemeName = this.themeComboBox.SelectedValue.ToString();
            switch (this.themeComboBox.SelectedValue.ToString())
            {
                case "Office2016Black":
                    
                    this.Style.TitleBar.BackColor = Color.FromArgb(38, 38, 38);
                    this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.BackColor = ColorTranslator.FromHtml("#444444");
                    this.label1.BackColor = ColorTranslator.FromHtml("#444444");
                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    this.options.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
                    break;
                case "Office2016DarkGray":
                    this.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.CloseButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.CloseButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.MinimizeButtonForeColor = ColorTranslator.FromHtml("#f0f0f0");
                    this.Style.TitleBar.MinimizeButtonHoverBackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.BackColor = Color.FromArgb(102, 102, 102);
                    this.label1.BackColor = ColorTranslator.FromHtml("#d4d4d4");
                    this.Style.TitleBar.ForeColor = Color.FromArgb(240, 240, 240);
                    this.label1.ForeColor = ColorTranslator.FromHtml("#262626");
                    this.options.ForeColor = ColorTranslator.FromHtml("#262626");
                    break;
                    default:
                    this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.Style.TitleBar.BackColor = Color.FromArgb(242, 242, 242);
                    this.Style.TitleBar.CloseButtonForeColor = Color.FromArgb(51, 51, 51);
                    this.Style.TitleBar.MinimizeButtonForeColor = Color.FromArgb(51, 51, 51);
                    this.Style.TitleBar.CloseButtonHoverBackColor = this.Style.TitleBar.MinimizeButtonHoverBackColor;
                    this.Style.TitleBar.CloseButtonHoverForeColor = this.Style.TitleBar.MinimizeButtonHoverForeColor;
                    this.label1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.label1.ForeColor = ColorTranslator.FromHtml("#444444");
                    this.options.ForeColor = ColorTranslator.FromHtml("#444444");
                    break;
            }
            this.EndUpdate();
        }

        #endregion
    }

    #region "USState Class"
    /// <summary>
    /// Creating the class 
    /// </summary>
    public class USState
    {
        private string myShortName;
        private string myLongName;
        private int imgIndex;

        public USState(string strLongName, string strShortName, int imageIndex)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
            this.imgIndex = imageIndex;
        }

        public string ShortName
        {
            get
            {
                return myShortName;
            }
        }

        public string LongName
        {

            get
            {
                return myLongName;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imgIndex;
            }
            set
            {
                imgIndex = value;
            }
        }


        public override string ToString()
        {
            return this.LongName + " - " + this.ShortName;
        }
    }
    #endregion


    #region ThemeData
    public class ThemeTypes
    {
        public string ThemeName { get; set; }
        public int Value { get; set; }
    }
    #endregion
}
