using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BCA_SetA_FoodDishManagement
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string command;
        DataTable dt;
        Dish dish;

        public Form1()
        {
            InitializeComponent();
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\prath\\OneDrive\\Desktop\\Pratham Data\\SEM 5\\ADNF\\Internal Practical Solutions\\BCA_SetA_FoodDishManagement\\BCA_SetA_FoodDishManagement\\dbDishData.mdf\";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(conString);
            fillCmbType();
        }        

        // filling combobox
        private void fillCmbType()
        {
            dt = new DataTable();
            DataColumn col1 = new DataColumn("Display",typeof(String));
            DataColumn col2 = new DataColumn("Value", typeof(String));
            
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);

            string[] arrDisplay = { "All","Fat Dish","Not Fat Dish"};
            string[] arrValue = { "All", "Yes", "No" };

            for(int i = 0; i < arrDisplay.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = arrDisplay[i];
                dr[1] = arrValue[i];
                dt.Rows.Add(dr);
            }

            cmbType.DisplayMember = "Display";
            cmbType.ValueMember = "Value";
            cmbType.DataSource = dt;
        }

        // reset the fields
        void reset()
        {
            txtId.Text = "0";
            txtName.Text = "";
            txtCal.Text = "0";
            txtPrice.Text = "0";
            rbYes.Checked = true;
            txtName.ReadOnly = false;
        }

        // databse functions
        // Display datagridview
        void dbDisplay(string res)
        {            
            try
            {
                if((res == "Yes") || (res == "No"))
                    command = $"select dishId,dishName,calories,price,isLowFat from tblDish where isLowFat = '{res}' order by price asc;";
                else
                    command = $"select dishId,dishName,calories,price,isLowFat from tblDish order by price asc";

                cmd = new SqlCommand(this.command, conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgDisplay.DataSource = dt;
            }
            catch {
                MessageBox.Show("error");
            }
            dgDisplay.Columns[0].Width = 70;
            dgDisplay.Columns[1].Width = 95;
            dgDisplay.Columns[2].Width = 70;
            dgDisplay.Columns[3].Width = 70;
            dgDisplay.Columns[4].Width = 70;

        } 

        // insert database function
        void dbInsert(Dish d)
        {
            try
            {
                command = $"insert into tblDish(dishId,dishName,calories,price,isLowFat) values({d.dishId},'{d.dishName}',{d.calories},{d.price},'{d.isLowFat}');";

                cmd = new SqlCommand(command,conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"{d.dishName} is Added!", "New Dish Added", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                conn.Close();
                d.dishName = txtName.Text = dbGetDishName(d);
                txtName.ReadOnly = true;
                DialogResult res = MessageBox.Show("This Dish Is Alrady Exists!! Do You Want to Update it?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);                
                
                if(res == DialogResult.Yes)
                    dbUpdate(d);
            }
        }

        // get Dish Name of dish
        String dbGetDishName(Dish d)
        {
            String dishName = "";
            try
            {
                command = $"select dishName from tblDish where dishId = {d.dishId};";
                cmd = new SqlCommand(command, conn);
                conn.Open();
                dr = cmd.ExecuteReader();

                dr.Read();
                dishName = dr[0].ToString();
                dr.Close();
                conn.Close();                
            }
            catch (Exception)
            {
                dr.Close();
                conn.Close();
            }
            return dishName;
        }
        // get price of dish
        int dbGetPrice(Dish d)
        {
            int price = 0;
            try
            {
                command = $"select price from tblDish where dishId = {d.dishId};";
                cmd = new SqlCommand(command,conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                price = Convert.ToInt16(dr[0]);
                dr.Close();
                conn.Close() ;

                return price;
            }
            catch(Exception) {
                dr.Close();
                conn.Close();
            }
            return price;
        }

        // update database
        void dbUpdate(Dish d)
        {
            int oldPrice = dbGetPrice(d);
            int diff = d.price - oldPrice;
            string message = "";
            try
            {
                command = $"update tblDish set calories = {d.calories}, price = {d.price}, isLowFat = '{d.isLowFat}' where dishId = {d.dishId}";
                cmd = new SqlCommand(command,conn);
                conn.Open(); 
                cmd.ExecuteNonQuery();
                conn.Close();                
                
                if (diff>0)                                    
                    message = $"{d.dishName} is Updated! The Price is Incraced by Rs.{Math.Abs(diff)}";
                else
                    message = $"{d.dishName} is Updated! The Price is Decraced by Rs.{Math.Abs(diff)}";

                MessageBox.Show(message, "Dish Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                conn.Close();
                MessageBox.Show("Something Went Wrong!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // events        
        // insert button clicked
        private void btnInsert_Clicked(object sender, EventArgs e)
        {
            dish = new Dish();

            dish.dishId = Convert.ToInt32(txtId.Text);
            dish.dishName = txtName.Text;
            dish.calories = Convert.ToInt32(txtCal.Text);
            dish.price = Convert.ToInt32(txtPrice.Text);
            dish.isLowFat = (rbYes.Checked)?rbYes.Text:rbNo.Text;

            dbInsert(dish);
            reset();
            dbDisplay(cmbType.SelectedValue.ToString());
        }

        // reset button clicked
        private void btnReset_Clicked(object sender, EventArgs e)
        {
            reset();
        }

        // combobox Index changed
        private void cmbType_IndexChanged(object sender, EventArgs e)
        {            
            dbDisplay(cmbType.SelectedValue.ToString());
        }

        // non numeric value entered in orice and calorie textboxes
        private void txt_nonNumericValueEntered(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            try
            {
                int x = Convert.ToInt16(t.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Enter Non Numeric Value Here!");
                t.Text = "0";
                t.Focus();
            }
        }
    }
}