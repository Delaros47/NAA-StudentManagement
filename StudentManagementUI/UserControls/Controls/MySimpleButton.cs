﻿using DevExpress.XtraEditors;
using StudentManagementUI.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButton : SimpleButton, IStatusBarDescription
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarDescription { get; set; }
    }
}
