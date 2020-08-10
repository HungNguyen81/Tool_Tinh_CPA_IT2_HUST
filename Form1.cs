using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {

        public static bool isCPA = true;
        static string Ten_HP = "";
        static string Diem_Chu = "";
        static string Trong_So = "";
        static double Diem_So = 0;
        DataTable cb_data;

        // ________________________ if connect to Service based Database ____________________________
        //static String connect_String = @"Data Source=.\SQLEXPRESS;AttachDbFilename="
        //            + Application.StartupPath
        //            + @"\CTDT_sv_IT2_HUST.mdf;Integrated Security=True;User Instance=True";
        static String connect_String = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" 
                        + Application.StartupPath 
                        + @"\CTDT_sv_IT2_HUST.mdf;Integrated Security=True;Connect Timeout=30";
        static String connect_String2 = @"Data Source=DESKTOP-I3P8PTT;" // server name
                        + "Initial Catalog=chuong_trinh_dt_it2_nnh;Integrated Security=True";

        SqlConnection cnn = (isCPA)? new SqlConnection(connect_String)
                                   : new SqlConnection(connect_String2);

        // ________________________ if connect to local Database ____________________________________
        //SqlConnection cnn =
        //    new SqlConnection(connect_String2);

        String sql1 = "select s.MAHP, s.TENHP, s.SOTC, hp.TRONGSO_GK from SP s, TRONG_SO_HP hp"
                    + " where s.MAHP = hp.MAHP";  // Lấy ra danh sách học phần

        String sql2 = "select s.*, h.DIEMCHU, hp.TRONGSO_GK as TRONGSO"
                    + " from SP s, TRONG_SO_HP hp, HP_daHoc h" 
                    + " where hp.MAHP = s.MAHP and h.TENHP = s.TENHP"
                    + " and h.DIEMCHU is not null"; // Lấy ra các học phần đã học

        String sql3 = "select TENHP, MAHP from SP"; // Lấy ra danh sách HP để đổ vào Combobox


        public Form1()
        {
            InitializeComponent();
            setConn();
            ConectDatabase(sql1, true);
            ConectDatabase(sql2, false);
            
            UpdateCombobox_HP(sql3);
        }

        public void setConn()
        {
            
            cnn = (isCPA) ? new SqlConnection(connect_String)
                                   : new SqlConnection(connect_String2);
            label4.Text = (isCPA)? "GPA của bạn:" : "CPA của bạn:";
        }

        private void UpdateCombobox_HP(String sql)
        {
            cnn.Open();
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            cb_data = new DataTable(); 
            if (cb_data != null) da.Fill(cb_data);  

            cb_hocphan.DataSource = cb_data;
            cb_hocphan.DisplayMember = "TENHP";
            
            cnn.Close();
        }

        
        private void ConectDatabase(string sqlQuery, bool isView1)
        {
            cnn.Open();
            //string sql = "select * from test4 where MALOPTHI = \'" + malop + "\'"; 
            SqlCommand com = new SqlCommand(sqlQuery, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            
            if(dt != null) da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            if (isView1)
            {
                dgv_danhmuc.DataSource = dt; //đổ dữ liệu vào datagridview
            } 
            else
            {
                dgv_monhoc.DataSource = dt;
            }
            
        }

        private void getTrongSo()
        {
            //Ten_HP = cb_hocphan.GetItemText(this.cb_hocphan.SelectedItem);
            cnn.Open();
            String sql = "select distinct hp.TRONGSO_GK from SP s, TRONG_SO_HP hp "
                        + "where s.MAHP = hp.MAHP and TENHP = \'" + Ten_HP + "\'";

            SqlCommand com1 = new SqlCommand(sql, cnn);
            com1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com1);

            DataTable set = new DataTable();

            da.Fill(set);
            foreach (DataRow row in set.Rows)
            {
                Trong_So = row["TRONGSO_GK"].ToString();
            }

            cnn.Close();
        }

        private void cb_hocphan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_maHP.Text = "";
            Ten_HP = cb_hocphan.GetItemText(this.cb_hocphan.SelectedItem);
            
            //foreach(DataRow r in cb_data.Rows)
            //{
            //    if (r["TENHP"].ToString() == Ten_HP)
            //        txt_maHP.Text = r["MAHP"].ToString();
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!txt_maHP.Text.Equals(""))
            {
                foreach (DataRow r in cb_data.Rows)
                {
                    if (r["MAHP"].ToString() == txt_maHP.Text)
                        Ten_HP = r["TENHP"].ToString();
                }
            }
            else
            {
                Ten_HP = cb_hocphan.GetItemText(this.cb_hocphan.SelectedItem);
            }
            
            if (!txt_diemChu.Text.Equals(""))
            {
                Diem_Chu = txt_diemChu.Text;
            }
            else
            {
                if (txt_diemQt.Text.Equals("") || txt_diemCK.Text.Equals(""))
                {
                    MessageBox.Show("Chưa Nhập đúng !", "Lỗi Nhập Liệu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double QT = Double.Parse(txt_diemQt.Text);
                    double CK = Double.Parse(txt_diemCK.Text);
                    //MessageBox.Show(QT + "-" + CK);

                    getTrongSo();

                    switch (Trong_So)
                    {
                        case "7":
                            Diem_So = 0.7 * CK + 0.3 * QT;
                            break;
                        case "6":
                            Diem_So = 0.6 * CK + 0.4 * QT;
                            break;
                        case "5":
                            Diem_So = 0.5 * (CK + QT);
                            break;
                        case "8":
                            Diem_So = 0.8 * CK + 0.2 * QT;
                            break;
                        default:
                            Diem_So = 0;
                            break;
                    }
                    Diem_So = Math.Round(Diem_So, 1);
                    if(Diem_So >= 9.5 && Diem_So <= 10)
                    {
                        Diem_Chu = "A+";
                    }
                    else if (Diem_So >= 8.5 && Diem_So <= 9.4)
                    {
                        Diem_Chu = "A";
                    } 
                    else if (Diem_So >= 8.0 && Diem_So <= 8.4)
                    {
                        Diem_Chu = "B+";
                    }
                    else if (Diem_So >= 7.0 && Diem_So <= 7.9)
                    {
                        Diem_Chu = "B";
                    }
                    else if (Diem_So >= 6.5 && Diem_So <= 6.9)
                    {
                        Diem_Chu = "C+";
                    }
                    else if (Diem_So >= 5.5 && Diem_So <= 6.4)
                    {
                        Diem_Chu = "C";
                    }
                    else if (Diem_So >= 5.0 && Diem_So <= 5.4)
                    {
                        Diem_Chu = "D+";
                    }
                    else if (Diem_So >= 4.0 && Diem_So <= 4.9)
                    {
                        Diem_Chu = "D";
                    }
                    else if (Diem_So >= 0 && Diem_So <= 3.9)
                    {
                        Diem_Chu = "F";
                    }
                }
                
            }
            try
            {
                cnn.Open();
                //String sql4_insert = "insert into HP_daHoc values";
                String sql4 = "Insert into HP_daHoc (DIEMCHU, TENHP) "
                         + " values (@diemchu, @tenhp) ";
                SqlCommand com = cnn.CreateCommand();
                //new SqlCommand(sql4_insert + "(\'" + Diem_Chu + "\',\'" + Ten_HP + "\')", cnn);
                com.CommandText = sql4;

                SqlParameter diemChuParam = new SqlParameter("@diemchu", SqlDbType.VarChar);
                diemChuParam.Value = Diem_Chu;
                com.Parameters.Add(diemChuParam);

                SqlParameter tenHpParam = new SqlParameter("@tenhp", SqlDbType.VarChar);
                tenHpParam.Value = Ten_HP;
                com.Parameters.Add(tenHpParam);

                int rowCount = com.ExecuteNonQuery();

                cnn.Close();
                txt_maHP.Text = "";
                txt_diemQt.Text = "";
                txt_diemCK.Text = "";
                txt_diemChu.Text = "";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
            ConectDatabase(sql2, false);
            
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        public void DeleteData()
        {
            if (!txt_maHP.Text.Equals(""))
            {
                foreach (DataRow r in cb_data.Rows)
                {
                    if (r["MAHP"].ToString() == txt_maHP.Text)
                        Ten_HP = r["TENHP"].ToString();
                }
            }
            else
            {
                Ten_HP = cb_hocphan.GetItemText(this.cb_hocphan.SelectedItem);
            }
            cnn.Open();
            String sql = "delete from HP_daHoc where TENHP = @tenhp";
            SqlParameter sqlParam = new SqlParameter("@tenhp", SqlDbType.VarChar);
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            sqlParam.Value = Ten_HP;

            cmd.Parameters.Add(sqlParam);
            cmd.ExecuteNonQuery();

            cnn.Close();
            txt_maHP.Text = "";
            txt_diemQt.Text = "";
            txt_diemCK.Text = "";
            txt_diemChu.Text = "";
            ConectDatabase(sql2, false);
        }

        public void DeleteData(String TenHP)
        {
            cnn.Open();
            String sql = "delete from HP_daHoc where TENHP = @tenhp";
            SqlParameter sqlParam = new SqlParameter("@tenhp", SqlDbType.VarChar);
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            sqlParam.Value = TenHP;

            cmd.Parameters.Add(sqlParam);
            cmd.ExecuteNonQuery();

            cnn.Close();
            txt_maHP.Text = "";
            txt_diemQt.Text = "";
            txt_diemCK.Text = "";
            txt_diemChu.Text = "";
            ConectDatabase(sql2, false);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double Sum = 0;
            cnn.Open();
            //String sql = "select sum(SOTC) as Sum from SP s, HP_daHoc h where s.TENHP = h.TENHP";
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.CommandType = CommandType.Text;
            //SqlDataAdapter da = new SqlDataAdapter(cmd); 
            //DataTable dt = new DataTable();
            //if (dt != null) da.Fill(dt);

            String sql2 = "select s.SOTC, h.DIEMCHU from SP s, HP_daHoc h where s.TENHP = h.TENHP";
            SqlCommand cmd = new SqlCommand(sql2, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            if (dt2 != null) da2.Fill(dt2);
            cnn.Close();

            //foreach(DataRow r in dt.Rows)
            //{
            //    Sum = Double.Parse(r["Sum"].ToString());
            //}
            double tongDiem = 0;
            foreach (DataRow row in dt2.Rows)
            {
                int soTc = Int32.Parse(row["SOTC"].ToString());
                Sum = Sum + soTc;
                switch (row["DIEMCHU"].ToString())
                {
                    case "A+":
                        tongDiem += 4.0 * soTc;
                        break;
                    case "A":
                        tongDiem += 4.0 * soTc;
                        break;
                    case "B+":
                        tongDiem += 3.5 * soTc;
                        break;
                    case "B":
                        tongDiem += 3.0 * soTc;
                        break;
                    case "C+":
                        tongDiem += 2.5 * soTc;
                        break;
                    case "C":
                        tongDiem += 2.0 * soTc;
                        break;
                    case "D+":
                        tongDiem += 1.5 * soTc;
                        break;
                    case "D":
                        tongDiem += 1.0 * soTc;
                        break;
                    case "F":
                        tongDiem += 0;
                        break;
                    default:
                        tongDiem += 0;
                        break;
                }
            }
            MessageBox.Show(tongDiem.ToString() + "/" + Sum.ToString());
            double CPA = Math.Round(tongDiem/Sum, 2);
            lb_result.Text = CPA.ToString();

        }

        private void dgv_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            if(colIndex == 1)
            {
                try
                {
                    DataGridViewRow row = dgv_monhoc.Rows[rowIndex];
                    String tenhp = row.Cells[1].Value.ToString();
                    DialogResult choice = MessageBox.Show("Bạn có muốn xóa :" + tenhp + " không?", "THÔNG BÁO",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (choice == DialogResult.Yes)
                    {
                        DeleteData(tenhp);
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            Application.ExitThread();
            
        }
        public static void sendForm(Form2 f)
        {

        }
    }
}
