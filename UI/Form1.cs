using BL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.TeacherBL teacherBL = new BL.TeacherBL();
            var listOfSchools=teacherBL.GetSchools();
            dataGridView1.DataSource = listOfSchools;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = comboBox1.SelectedValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    BL.TeacherBL teacherBL = new BL.TeacherBL();
        //    int i = comboBox1.SelectedItem as sch
        //    var listOfGroups = teacherBL.GetGroups(comboBox1.);
        //}


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    BL.TeacherBL teacherBL = new BL.TeacherBL();
        //    var listOfSchools = teacherBL.GetSchools();
        //    comboBox1.DataSource = listOfSchools;
        //}
    }
}