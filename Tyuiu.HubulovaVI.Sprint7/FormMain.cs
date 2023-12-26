using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using Tyuiu.HubulovaVI.Sprint7.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.HubulovaVI.Sprint7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;


        DataService ds = new DataService();

        private void buttonOpenFile_HVI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogButton_HVI.ShowDialog();
                openFilePath = openFileDialogButton_HVI.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewMatrix_HVI.RowCount = rows + 1;
                dataGridViewMatrix_HVI.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_HVI.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewMatrix_HVI.AutoResizeColumns();
                dataGridViewMatrix_HVI.ScrollBars = ScrollBars.Both;
                for (int i = 0; i < dataGridViewMatrix_HVI.RowCount - 1; i++)
                {

                    if (dataGridViewMatrix_HVI.Rows[i].Cells[3].Value.ToString() == "")
                    {
                        dataGridViewMatrix_HVI.Rows.RemoveAt(i);
                        i--;
                    }
                }


            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_HVI_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_HVI.FileName = openFilePath;
            saveFileDialogMain_HVI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_HVI.ShowDialog();

            string path = saveFileDialogMain_HVI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMatrix_HVI.RowCount;
            int columns = dataGridViewMatrix_HVI.ColumnCount;

            string str = "";



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMatrix_HVI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMatrix_HVI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAddRow_HVI_Click(object sender, EventArgs e)
        {
            string Articule_HVI = textBoxArticuleAdd_HVI.Text;
            string otdel_HVI = textBoxOtdelAdd_HVI.Text;
            string name_HVI = textBoxNameAdd_HVI.Text;
            string CountSklad_HVI = textBoxCountSkadAdd_HVI.Text;
            string CountUpakovka_HVI = textBoxCountUpaAdd_HVI.Text;
            string CountUpakovok_HVI = textBoxCountUpakovokadd_HVI.Text;
            string postavshik_HVI = textBoxPostavshikAdd_HVI.Text;
            string price_HVI = textBoxPriceAdd_HVI.Text;


            // заполнение
            dataGridViewMatrix_HVI.Rows.Add(Articule_HVI, otdel_HVI, name_HVI, CountSklad_HVI, CountUpakovka_HVI, CountUpakovok_HVI, postavshik_HVI, price_HVI);
            textBoxArticuleAdd_HVI.Text = "";
            textBoxOtdelAdd_HVI.Text = "";
            textBoxNameAdd_HVI.Text = "";
            textBoxCountSkadAdd_HVI.Text = "";
            textBoxCountUpaAdd_HVI.Text = "";
            textBoxCountUpakovokadd_HVI.Text = "";
            textBoxPostavshikAdd_HVI.Text = "";
            textBoxPriceAdd_HVI.Text = "";
            dataGridViewMatrix_HVI.CurrentCell = dataGridViewMatrix_HVI.Rows[dataGridViewMatrix_HVI.Rows.Count - 1].Cells[0];
        }

        private void textBoxPoiskName_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPoiskName_HVI.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMatrix_HVI.Rows)
            {
                if (row.Cells["name_HVI"].Value != null)
                {
                    string column2Text = row.Cells["name_HVI"].Value.ToString().ToLower();
                    if (column2Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void comboBoxFilter_HVI_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = comboBoxFilter_HVI.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in dataGridViewMatrix_HVI.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["otdel_HVI"].Value != null && row.Cells["otdel_HVI"].Value.ToString() == valueFilt)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void buttonAdmin_HVI_Click(object sender, EventArgs e)
        {
            FormInfo formOProgramme = new FormInfo();
            formOProgramme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = dataGridViewMatrix_HVI.RowCount;
                int columns = dataGridViewMatrix_HVI.ColumnCount;
                string str;
                string[,] matrix = new string[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        str = "";
                        str += dataGridViewMatrix_HVI.Rows[i].Cells[j].Value;
                        matrix[i, j] = str;
                    }

                }

                int summ = 0;
                int sumb = 0;
                int summg = 0;
                for (int i = 0; i < rows - 1; i++)
                {
                    if (matrix[i, 1] == "Молоко")
                    {
                        summ += Convert.ToInt32(dataGridViewMatrix_HVI.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Бакалея")
                    {
                        sumb += Convert.ToInt32(dataGridViewMatrix_HVI.Rows[i].Cells[3].Value);
                    }
                    if (matrix[i, 1] == "Мясная гастрономия")
                    {
                        summg += Convert.ToInt32(dataGridViewMatrix_HVI.Rows[i].Cells[3].Value);
                    }
                }


                string[] seriesArray = { "Молоко", "Бакалея", "Мясная гастрономия" };
                int[] pointsArray = { summ, sumb, summg };

                // Add series.
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    // Add series.
                    Series series = this.chart_HVI.Series.Add(seriesArray[i]);

                    // Add point.
                    series.Points.Add(pointsArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Невозможно повторно построить график", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
