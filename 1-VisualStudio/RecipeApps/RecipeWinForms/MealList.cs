using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForm
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            LoadList();
            gMealList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gMealList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gMealList.AllowUserToAddRows = false;
            gMealList.ReadOnly = true;
        }

        private void LoadList()
        {
            gMealList.DataSource = DataMaintenance.GetDataList("MealList");
        }
    }
}
