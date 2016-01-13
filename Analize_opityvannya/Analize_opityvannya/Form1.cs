using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Analize_opityvannya
{
    public partial class Form1 : Form
    {
        DBConnect DBC = new DBConnect();  // Create an object
        public Form1()
        {
            InitializeComponent();
            DBC.Initialize();
        }
        int[] arr;
        int iter = 0;
        int counter = 0;
        string in_file = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (iter == 0)
            {
                counter = DBC.Select();
                MessageBox.Show("В базі даних знайдено результати опитування " + counter.ToString() + " респондентів(а)");
                arr = new int[counter];
                in_file += "В базі даних знайдено результати опитування " + counter.ToString() + " респондентів(а).\r\n";
            }
            iter++;
            tabControl1.SelectedIndex = iter;
            if (iter == 1)//питання 1
            {
                arr = DBC.Select(2, counter);//select first question, in data table it's 2 column, if count from 0

                //start analize answers for question #1
                float[] tmp = new float[2];
                for (int i = 0; i < counter; i++)
                {
                    if (arr[i] == 1) tmp[0]++;//Woman
                    else if (arr[i] == 2) tmp[1]++;//Man
                }
                string str1 = "\"" + label4.Text + "\"";
                string str2 = "\"" + label5.Text + "\"";
                str1 += " -- " + tmp[0].ToString() + " респондентів(а)";
                str2 += " -- " + tmp[1].ToString() + " респондентів(а)";
                tmp[0] = (tmp[0]/counter)*100;
                tmp[1] = (tmp[1]/counter)*100;
                str1 += " -- " + tmp[0].ToString() + "% усіх опитаних";
                str2 += " -- " + tmp[1].ToString() + "% усіх опитаних";
                label4.Text = str1;
                label5.Text = str2;
                in_file += label3.Text + "\r\n\t" + str1 + "\r\n\t" + str2 + "\r\n\n\n";
            }
            else if (iter == 2)//питання 2
            {
                arr = DBC.Select(3, counter);//select second question, in data table it's 3 column, if count start from 0

                float[] tmp = new float[3];
                for (int i = 0; i < counter; i++)
                {
                    if (arr[i] == 1) tmp[0]++;//17-19
                    else if (arr[i] == 2) tmp[1]++;//20-22
                    else if (arr[i] == 3) tmp[2]++;
                }
                string str1 = "\"" + label6.Text + "\"";
                string str2 = "\"" + label8.Text + "\"";
                string str3 = "\"" + label9.Text + "\"";
                str1 += " -- " + tmp[0].ToString() + " респондентів(а)";
                str2 += " -- " + tmp[1].ToString() + " респондентів(а)";
                str3 += " -- " + tmp[2].ToString() + " респондентів(а)";
                tmp[0] = (tmp[0] / counter) * 100;
                tmp[1] = (tmp[1] / counter) * 100;
                tmp[2] = (tmp[2] / counter) * 100;
                str1 += " -- " + tmp[0].ToString() + "% усіх опитаних";
                str2 += " -- " + tmp[1].ToString() + "% усіх опитаних";
                str3 += " -- " + tmp[2].ToString() + "% усіх опитаних";
                label6.Text = str1;
                label8.Text = str2;
                label9.Text = str3;
                in_file += label7.Text + "\r\n\t" + str1 + "\r\n\t" + str2 + "\r\n\t" + str3 + "\r\n\n\n";
            }
            else if (iter == 3)//питання 3
            {
                arr = DBC.Select(4, counter);//select 3 question, in data table it's 3 column, if count start from 0

                float[] tmp = new float[3];
                for (int i = 0; i < counter; i++)
                {
                    if (arr[i] == 1) tmp[0]++;//17-19
                    else if (arr[i] == 2) tmp[1]++;//20-22
                    else if (arr[i] == 3) tmp[2]++;
                }
                string str1 = "\"" + label12.Text + "\"";
                string str2 = "\"" + label13.Text + "\"";
                string str3 = "\"" + label14.Text + "\"";
                str1 += " -- " + tmp[0].ToString() + " респондентів(а)";
                str2 += " -- " + tmp[1].ToString() + " респондентів(а)";
                str3 += " -- " + tmp[2].ToString() + " респондентів(а)";
                tmp[0] = (tmp[0] / counter) * 100;
                tmp[1] = (tmp[1] / counter) * 100;
                tmp[2] = (tmp[2] / counter) * 100;
                str1 += " -- " + tmp[0].ToString() + "% усіх опитаних";
                str2 += " -- " + tmp[1].ToString() + "% усіх опитаних";
                str3 += " -- " + tmp[2].ToString() + "% усіх опитаних";
                label12.Text = str1;
                label13.Text = str2;
                label14.Text = str3;
                in_file += label11.Text + "\r\n\t" + str1 + "\r\n\t" + str2 + "\r\n\t" + str3 + "\r\n\n\n";
            }
            else if (iter == 4)
            {
                arr = DBC.Select(5, counter);

                float[] tmp = new float[5];
                for (int i = 0; i < counter; i++)
                {
                    if (arr[i] == 1) tmp[0]++;
                    else if (arr[i] == 2) tmp[1]++;
                    else if (arr[i] == 3) tmp[2]++;
                    else if (arr[i] == 4) tmp[3]++;
                    else if (arr[i] == 5) tmp[4]++;
                }
                string str1 = "\"" + label15.Text + "\"";
                string str2 = "\"" + label16.Text + "\"";
                string str3 = "\"" + label17.Text + "\"";
                string str4 = "\"" + label19.Text + "\"";
                string str5 = "\"" + label20.Text + "\"";
                str1 += " -- " + tmp[0].ToString() + " респондентів(а)";
                str2 += " -- " + tmp[1].ToString() + " респондентів(а)";
                str3 += " -- " + tmp[2].ToString() + " респондентів(а)";
                str4 += " -- " + tmp[3].ToString() + " респондентів(а)";
                str5 += " -- " + tmp[4].ToString() + " респондентів(а)";
                tmp[0] = (tmp[0] / counter) * 100;
                tmp[1] = (tmp[1] / counter) * 100;
                tmp[2] = (tmp[2] / counter) * 100;
                tmp[3] = (tmp[3] / counter) * 100;
                tmp[4] = (tmp[4] / counter) * 100;
                str1 += " -- " + tmp[0].ToString() + "% усіх опитаних";
                str2 += " -- " + tmp[1].ToString() + "% усіх опитаних";
                str3 += " -- " + tmp[2].ToString() + "% усіх опитаних";
                str4 += " -- " + tmp[3].ToString() + "% усіх опитаних";
                str5 += " -- " + tmp[4].ToString() + "% усіх опитаних";
                label15.Text = str1;
                label16.Text = str2;
                label17.Text = str3;
                label19.Text = str4;
                label20.Text = str5;
                in_file += label18.Text + "\r\n\t" + str1 + "\r\n\t" + str2 + "\r\n\t" + str3 + "\r\n\t" + str4 + "\r\n\t" + str5 + "\r\n\n\n";
            }
            else if (iter == 5)
            {
                arr = DBC.Select(6, counter);
                float[] tmp = new float[3];
                for (int i = 0; i < counter; i++)
                {
                    if (arr[i] == 1) tmp[0]++;//17-19
                    else if (arr[i] == 2) tmp[1]++;//20-22
                    else if (arr[i] == 3) tmp[2]++;
                }
                string str1 = "\"" + label22.Text + "\"";
                string str2 = "\"" + label23.Text + "\"";
                string str3 = "\"" + label24.Text + "\"";
                str1 += " -- " + tmp[0].ToString() + " респондентів(а)";
                str2 += " -- " + tmp[1].ToString() + " респондентів(а)";
                str3 += " -- " + tmp[2].ToString() + " респондентів(а)";
                tmp[0] = (tmp[0] / counter) * 100;
                tmp[1] = (tmp[1] / counter) * 100;
                tmp[2] = (tmp[2] / counter) * 100;
                str1 += " -- " + tmp[0].ToString() + "% усіх опитаних";
                str2 += " -- " + tmp[1].ToString() + "% усіх опитаних";
                str3 += " -- " + tmp[2].ToString() + "% усіх опитаних";
                label22.Text = str1;
                label23.Text = str2;
                label24.Text = str3;
                in_file += label21.Text + "\r\n\t" + str1 + "\r\n\t" + str2 + "\r\n\t" + str3 + "\r";
            }
            else if (iter == 6)
            {
                button1.Visible = false;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (File.Exists("file.txt"))
                    File.Delete("file.txt");

                File.WriteAllText("file.txt", in_file);
                File.OpenRead("file.txt");
                System.Diagnostics.Process.Start("file.txt");
            }
            this.Close();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            checkBox1.Checked = true;
        }
    }
}

class DBConnect
{

    public MySqlConnection connection;
    public string server;
    public string database;
    public string uid;
    public string password;

    //Constructor
    public DBConnect()
    {
        Initialize();
    }

    //Initialize values
    public void Initialize()
    {
        server = "localhost";
        database = "results_of_a_poll";
        uid = "root";
        password = "121212";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    public bool OpenConnection() //
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    Console.Write("Cannot connect to server.  Contact administrator;\n");
                    break;

                case 1045:
                    Console.Write("Invalid username/password, please try again;\n");
                    break;
            }
            return false;
        }
    }
    public bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            Console.Write("Cannot close connection;\n", ex.Message);
            return false;
        }
    }

    //Select statement
    public int[] Select(int i, int count)
    {
        string query = "SELECT * FROM pool1";
        int[] arr = new int[count];

        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            count = 0;
            while (dataReader.Read())
            {
                arr[count] = Convert.ToInt32(dataReader.GetString(i));
                count++;
            }

            dataReader.Close();
            this.CloseConnection();
            return arr;
        }
        else
            return arr;
    }
    public int Select()//count a counter members of pool
    {
        string query = "SELECT * FROM source";
        int i = 0;//counter
        if (this.OpenConnection() == true)
        {

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                i++;
            }
            this.CloseConnection();
            return i;
        }
        else
            return i;
        
    }
}