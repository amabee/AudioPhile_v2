using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPhile_v2.Custom_Components.Custom_MessageBox
{
    public partial class CMessageBox : Form
    {
      
        public CMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();

            this.labelMessage.Text = text;
            this.labelCaption.Text = "";

            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);

            button1.Click += (sender, e) => {
                this.DialogResult = button1.DialogResult;
                this.Close();
            };
        }
        public CMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons

            button1.Click += (sender, e) => {
                this.DialogResult = button1.DialogResult;
                this.Close();
            };
        }
        public CMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();

            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
           
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]

            button1.Click += (sender, e) => {
                this.DialogResult = button1.DialogResult;
                this.Close();
            };

            button2.Click += (sender, e) => {
                this.DialogResult = button2.DialogResult;
                this.Close();
            };

            button3.Click += (sender, e) => {
                this.DialogResult = button3.DialogResult;
                this.Close();
            };
        }
        public CMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();

            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
           
            SetButtons(buttons, MessageBoxDefaultButton.Button1);
            SetIcon(icon);

            button1.Click += (sender, e) => {
                this.DialogResult = button1.DialogResult;
                this.Close();
            };

            button2.Click += (sender, e) => {
                this.DialogResult = button2.DialogResult;
                this.Close();
            };

            button3.Click += (sender, e) => {
                this.DialogResult = button3.DialogResult;
                this.Close();
            };
        }
        public CMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();

            this.labelMessage.Text = text;
            this.labelCaption.Text = caption;
            
            SetButtons(buttons, defaultButton);
            SetIcon(icon);

            button1.Click += (sender, e) => {
                this.DialogResult = button1.DialogResult;
                this.Close();
            };

            button2.Click += (sender, e) => {
                this.DialogResult = button2.DialogResult;
                this.Close();
            };

            button3.Click += (sender, e) => {
                this.DialogResult = button3.DialogResult;
                this.Close();
            };
        }

        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.labelMessage.MaximumSize = new Size(398, 99);
            this.labelMessage.ForeColor = SystemColors.ControlLight;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }


        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.panelButtons.Width - button1.Width) / 2;
            int yCenter = (this.panelButtons.Height - button1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.FillColor = Color.FromArgb(64, 173, 106);
                    button1.Text = "Ok";
                    button1.DialogResult = DialogResult.OK;

                    //Set Default Buttonbutt
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Ok";
                    button1.DialogResult = DialogResult.OK;
                    button1.FillColor = Color.FromArgb(64, 173, 106);

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancel";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.FillColor = Color.FromArgb(254, 63, 79);

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Retry";
                    button1.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "Cancel";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                    button1.Text = "Yes";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Yes";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    //Cancel Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Cancel";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Color.DimGray;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                    button1.Text = "Abort";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Color.Goldenrod;

                    //Retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Retry";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                    button3.Text = "Ignore";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }

        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    button1.Select();
                    button1.ForeColor = Color.White;
                    button1.Font = new Font(button1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    button2.Select();
                    button2.ForeColor = Color.White;
                    button2.Font = new Font(button2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    button3.Select();
                    button3.ForeColor = Color.White;
                    button3.Font = new Font(button3.Font, FontStyle.Underline);
                    break;
            }
        }
   
        
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error:
                    this.CMessageBoxPCB.Image = Properties.Resources.cross;
                    guna2Panel2.BackColor = Color.FromArgb(254, 63, 60);
                    break;

                case MessageBoxIcon.Information:
                    this.CMessageBoxPCB.Image = Properties.Resources.check_mark_button_50px;
                    guna2Panel2.BackColor = Color.FromArgb(64, 173, 106);
                    this.labelMessage.Font = new Font(this.labelMessage.Font.FontFamily, 36, this.labelMessage.Font.Style);
                    break;

                case MessageBoxIcon.Exclamation:
                    this.CMessageBoxPCB.Image = Properties.Resources.warning_50px;
                    guna2Panel2.BackColor = Color.FromArgb(255, 227, 94);
                    break;
            }
        }
    
    
    
    
    }
}
