﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UserForm : Form
    {
        List<User> users;
        int index;
        public UserForm(List<User> users2,int index2)
        {
            InitializeComponent();
            users = users2;
            index = index2;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            AddProduct addProduct = new AddProduct(users,index);
            addProduct.Show();
            this.Hide();
            
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet(users,index);
            wallet.Show();
            this.Hide();
            
        }
    }
}
