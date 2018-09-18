using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class Start : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=77.237.11.222;database=mati;uid=user1;password=user1");

        MySqlCommand cmd = dbConn.CreateCommand();
        cmd.CommandText = "SELECT mail from mati WHERE login ='mat'";
        string flag1 = "1";
        try
        {
            dbConn.Open();
        }
        catch (Exception erro)
        {
            flag1 = erro.Message;
        }

        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            flag1 = reader["mail"].ToString();
        }
        LabelMail.Text = flag1.ToString();
    }
}