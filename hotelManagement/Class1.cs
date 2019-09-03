using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

public class cnnt
{
    private string server = "localhost";
    private string database = "hotel";
    private string uid = "root";
    private string password = "";
    public MySqlConnection con = new MySqlConnection();
    public string insqry;
    string connt;
    MySqlCommand cmmd = new MySqlCommand();
    public DataView stv = new DataView();

    DataTable table = new DataTable();
    public string dt;
    public string bt= null;
    public int av;
    public string name;

    public void cnntotbl()
    {
        try
        {

            connt = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connt);

            con.Open();
            
            cmmd = new MySqlCommand(insqry,con);
            MySqlDataReader reader;
            reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
            }
            con.Close();
        }
        catch(Exception ex)
        {
           
        }
    }


    public void schfn()
    {
        try
        {
            connt = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connt);
            con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(insqry, con);
            DataTable dtb = new DataTable();
            adp.Fill(dtb);
            stv = new DataView(dtb);

            con.Close();
        }
        catch (Exception ex)
        {
            
        }

    }
    public void rdr()
    {
        try
        {
            connt = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connt);
            cmmd = new MySqlCommand(insqry, con);
            con.Open();
            MySqlDataReader reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
                dt = (reader[0].ToString());

            }
            reader.Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show("" + ex);
        }
    }

    public void rdr1()
    {
        try
        {
            connt = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connt);
            cmmd = new MySqlCommand(insqry, con);
            con.Open();
            MySqlDataReader reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
                bt = reader[0].ToString();
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("" + ex);
        }

    }

    public void rdrfl()
    {
        try
        {
            av = 0;
            connt = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connt);
            cmmd = new MySqlCommand(insqry, con);
            con.Open();
            MySqlDataReader reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
                av = 1;
                bt = reader[0].ToString();
                name = reader[1].ToString();
                dt = reader[2].ToString();
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("" + ex);
        }

    }

    public void rdrpl()
    {
        try
        {
            dt = null;
            double rm;
            connt = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(connt);
            cmmd = new MySqlCommand(insqry, con);
            con.Open();
            MySqlDataReader reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
                rm = Convert.ToDouble(reader[0]);
                dt = (rm + dt);
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("" + ex);
        }

    }
}
