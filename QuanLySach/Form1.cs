using QuanLySach.BLL;
using QuanLySach.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDL();
        }

        void LoadDL()
        {
            List<CBB> list = new List<CBB>();
            foreach (var item in TheLoai_BLL.Instance.getListTL())
            {
                list.Add(new CBB()
                {
                    Value = item.MaTL,
                    Text = item.TenTL
                });
            }

            cbCategory.Items.AddRange(list.ToArray());
            cbCategory.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text != null)
            {
                string name = txtName.Text;
                TheLoai tl = TheLoai_BLL.Instance.getTLByID((int)((CBB)cbCategory.SelectedItem).Value);
                Sach sach = new Sach
                {
                    TenSach = name,
                    TheLoai = tl,
                };
                Sach_BLL.Instance.Add(sach);
            }
            
        }
    }
}
