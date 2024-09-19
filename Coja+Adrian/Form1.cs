namespace Coja_Adrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditStudent frm = new frmAddEditStudent() { StudentInfo = new Student() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    studentBindingSource.Add(frm.StudentInfo);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student obj = studentBindingSource.Current as Student;
            if(obj != null)
            {
                using(frmAddEditStudent frm = new frmAddEditStudent() { StudentInfo =  obj})
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        studentBindingSource.EndEdit();
                        btnEdit.Focus();
                    }
                }
            }
        }
    }
}
