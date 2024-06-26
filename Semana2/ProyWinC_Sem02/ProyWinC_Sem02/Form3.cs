﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de los caracteres sean digitos
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
