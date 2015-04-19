﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stock
{
    /// <summary>
    /// StockStateBox.xaml 的交互逻辑
    /// </summary>
    public partial class StockStateBox : UserControl
    {
        public StockStateBox()
        {
            InitializeComponent();
        }
        public event EventHandler UEvent;
        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (UEvent != null)
            {
                UEvent(this, e);
            }
        }
    }
}
