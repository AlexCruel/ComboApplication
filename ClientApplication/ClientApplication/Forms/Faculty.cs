using ClientApplication.Model;
using ClientApplication.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Faculty : Form
    {
        List<FacultySend> facultySends = null;

        private void LoadDataServ()
        {
            facultySends = new GetFacultySend().GetTD();

            if (facultySends == null)
            {
                MessageBox.Show("Ошибка. Связь с сервером отсутствует!");
            }
        }

        public Faculty()
        {
            InitializeComponent();

            try
            {
                LoadDataServ();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка. Связь с сервером отсутствует! ({ex})");
            }
        }

        // заполн таблицы
        private void DrawData()
        {
            foreach (FacultySend t in facultySends)
            {
                // id нов строки
                int rowNumber = dataGridView1.Rows.Add();
                // запись в столбцы
                //dataGridView1.Rows[rowNumber].Cells[0].Value = t.КодФакульт;
                dataGridView1.Rows[rowNumber].Cells[0].Value = t.Факультет;
                dataGridView1.Rows[rowNumber].Cells[1].Value = t.Руководитель;
                dataGridView1.Rows[rowNumber].Cells[2].Value = t.Адрес;
            }
        }

        // возв выдел направл
        private FacultySend FlagFaculty()
        {
            FacultySend td = null;
            try
            {
                // индекс строки а не id направл
                int index = dataGridView1.CurrentRow.Index;

                foreach (FacultySend t in facultySends)
                {
                    if ((int)dataGridView1[0, index].Value == t.КодФакульт)
                    {
                        td = t;
                    }
                }
            }
            catch (Exception)
            {
                return td;
            }

            return td;
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            DrawData();
        }
    }
}
