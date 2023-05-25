
using System.Data;
using System.Data.SqlClient;

namespace AttendanceManagement
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLlocalDB;Initial Catalog=AttedanceDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayRecords();


        }

        //retrieve data from database
        public void DisplayRecords()
        {
            SqlCommand cmd = new SqlCommand("select * from Attendance", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvAttendanceRecords.DataSource = dt;
        }
        

    }
}