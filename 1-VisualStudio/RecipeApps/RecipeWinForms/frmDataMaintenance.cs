using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForm
{
    public partial class frmDataMaintenance : Form
    {
        DataTable dtmaint = new DataTable();
        string tablename = "";
        string deletecolname = "deletecolname";
        public frmDataMaintenance()
        {
            InitializeComponent();
            rdoUsers.Checked = true;
            LoadGrid("Users");
            rdoUsers.CheckedChanged += RdoUsers_CheckedChanged;
            rdoIngredients.CheckedChanged += RdoIngredients_CheckedChanged;
            rdoCuisines.CheckedChanged += RdoCuisines_CheckedChanged;
            rdoMeasurements.CheckedChanged += RdoMeasurements_CheckedChanged;
            rdoCourses.CheckedChanged += RdoCourses_CheckedChanged;
            gDataMaintenance.CellContentClick += GDataMaintenance_CellContentClick;
            btnSaveDataMaintenance.Click += BtnSaveDataMaintenance_Click;
        }
        private string GetDeleteMessage()
        {
            string msg = "Are you sure you want to delete this row?";

            if (tablename == "Users")
            {
                msg = "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
            }
            else if (tablename == "Cuisine")
            {
                msg = "Are you sure you want to delete this cuisine and all related recipes?";
            }
            else if (tablename == "Ingredient")
            {
                msg = "Are you sure you want to delete this ingredient from all recipes?";
            }
            else if (tablename == "MeasurementType")
            {
                msg = "Are you sure you want to delete this measurement type from all ingredients?";
            }
            else if (tablename == "Courses")
            {
                msg = "Are you sure you want to delete this course and all related meal course records?";
            }

            return msg;
        }
        private void DeleteRow(int rowIndex)
        {
            var response = MessageBox.Show(GetDeleteMessage(), Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            DataMaintenance.DeleteRowForDataMaintenance(dtmaint, tablename, rowIndex);

            LoadGrid(tablename);
        }
        private void Save()
        {
            try
            {
                gDataMaintenance.EndEdit();

                DataMaintenance.SaveDataList(dtmaint, tablename);

                MessageBox.Show("Saved.", Application.ProductName);

                LoadGrid(tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void LoadGrid(string table)
        {
            tablename = table;
            gDataMaintenance.Columns.Clear();

            dtmaint = DataMaintenance.GetDataList(table);
            gDataMaintenance.DataSource = dtmaint;

            WindowsFormsUtility.AddDeleteButtonToGrid(gDataMaintenance, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gDataMaintenance, table);

            gDataMaintenance.ReadOnly = false;
            gDataMaintenance.AllowUserToAddRows = true;
        }
        private void BtnSaveDataMaintenance_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GDataMaintenance_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (gDataMaintenance.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRow(e.RowIndex);
            }
        }



        private void RdoCourses_CheckedChanged(object? sender, EventArgs e)
        {
            if (rdoCourses.Checked)
            {
                LoadGrid("Courses");
            }
        }

        private void RdoMeasurements_CheckedChanged(object? sender, EventArgs e)
        {
            if (rdoMeasurements.Checked)
            {
                LoadGrid("MeasurementType");
            }
        }

        private void RdoUsers_CheckedChanged(object? sender, EventArgs e)
        {
            if (rdoUsers.Checked)
            {
                LoadGrid("Users");
            }
        }

        private void RdoIngredients_CheckedChanged(object? sender, EventArgs e)
        {
            if (rdoIngredients.Checked)
            {
                LoadGrid("Ingredient");
            }
        }

        private void RdoCuisines_CheckedChanged(object? sender, EventArgs e)
        {
            if (rdoCuisines.Checked)
            {
                LoadGrid("Cuisine");
            }
        }


    }
}
