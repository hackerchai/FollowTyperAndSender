﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlGrades;

//用于删除成绩数据库里的相应段落
namespace Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string para = tbxPara.Text;
            string strCommand = string.Format("delete from grade where para='{0}'", para);
            new GradesHis().Delete(strCommand);
            
        }
    }
}
