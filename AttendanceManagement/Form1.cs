
using AttendanceManagement.Classes;
using System.Data;
using System.Data.SqlClient;

namespace AttendanceManagement
{


    public partial class Form1 : Form
    {

        #region Db Connection
        SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLlocalDB;Initial Catalog=AttedanceDB;Integrated Security=True");

        #endregion


        #region Properties
        List<Student> studentList = new List<Student>();
        List<Attendance> attendanceList = new List<Attendance>();
        List<Course> courseList = new List<Course>();

        #endregion

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
            dgvAttendanceMark.DataSource = dt;
        }

        //Mark attendance
        private void btnAttendanceUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttendanceRecords.Rows)
            {
                // Check if the row is not the new row and is selected
                if (!row.IsNewRow && row.Selected)
                {
                    // Get the AttendanceRecord object from the DataBoundItem
                    Attendance attendance = row.DataBoundItem as Attendance;

                    // Update the "is_present" column in the database based on the checkbox value
                    UpdateAttendanceInDatabase(attendance.attendanceId, attendance.isPresent);
                }
            }

            // Refresh the DataGridView to reflect the updated data
            dgvAttendanceRecords.Refresh();

        }

        private void UpdateAttendanceInDatabase(int attendanceId, bool isPresent)
        {
            // Assuming you have a connection object named "con" established earlier

            string updateQuery = "UPDATE Attendance SET is_present = @IsPresent WHERE attendance_id = @AttendanceId";

            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@IsPresent", isPresent);
                cmd.Parameters.AddWithValue("@AttendanceId", attendanceId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }






    }
}