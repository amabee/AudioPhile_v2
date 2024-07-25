namespace AudioPhile_v2.Custom_Components.Custom_MessageBox
{
    partial class CMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MessageBoxForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMessageBoxCustom = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelCaption = new System.Windows.Forms.Label();
            this.panelButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.button3 = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CMessageBoxPCB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CMessageBoxPCB)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageBoxForm
            // 
            this.MessageBoxForm.BorderRadius = 20;
            this.MessageBoxForm.ContainerControl = this;
            this.MessageBoxForm.DockIndicatorTransparencyValue = 0.6D;
            this.MessageBoxForm.TransparentWhileDrag = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panelTitleBar.Controls.Add(this.lblMessageBoxCustom);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(404, 47);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblMessageBoxCustom
            // 
            this.lblMessageBoxCustom.Font = new System.Drawing.Font("0xProto Nerd Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBoxCustom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMessageBoxCustom.Location = new System.Drawing.Point(3, 0);
            this.lblMessageBoxCustom.Name = "lblMessageBoxCustom";
            this.lblMessageBoxCustom.Size = new System.Drawing.Size(398, 47);
            this.lblMessageBoxCustom.TabIndex = 0;
            this.lblMessageBoxCustom.Text = "Alert!";
            this.lblMessageBoxCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(60)))));
            this.guna2Panel2.Controls.Add(this.labelMessage);
            this.guna2Panel2.Controls.Add(this.CMessageBoxPCB);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 47);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(404, 264);
            this.guna2Panel2.TabIndex = 1;
            // 
            // labelCaption
            // 
            this.labelCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.Location = new System.Drawing.Point(0, 314);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(401, 82);
            this.labelCaption.TabIndex = 2;
            this.labelCaption.Text = "Sample Message Here";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 399);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(404, 89);
            this.panelButtons.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Animated = true;
            this.button3.BorderRadius = 10;
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(266, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Animated = true;
            this.button2.BorderRadius = 10;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(150, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Animated = true;
            this.button1.BorderRadius = 10;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMessage.Font = new System.Drawing.Font("0xProto Nerd Font", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMessage.Location = new System.Drawing.Point(3, 165);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(398, 99);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "WARNING";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.lblMessageBoxCustom;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // CMessageBoxPCB
            // 
            this.CMessageBoxPCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMessageBoxPCB.Image = global::AudioPhile_v2.Properties.Resources.cross;
            this.CMessageBoxPCB.ImageRotate = 0F;
            this.CMessageBoxPCB.Location = new System.Drawing.Point(108, 12);
            this.CMessageBoxPCB.Name = "CMessageBoxPCB";
            this.CMessageBoxPCB.Size = new System.Drawing.Size(191, 150);
            this.CMessageBoxPCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CMessageBoxPCB.TabIndex = 0;
            this.CMessageBoxPCB.TabStop = false;
            // 
            // CMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 488);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMessageBox";
            this.panelTitleBar.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CMessageBoxPCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm MessageBoxForm;
        private Guna.UI2.WinForms.Guna2Panel panelTitleBar;
        private System.Windows.Forms.Label lblMessageBoxCustom;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox CMessageBoxPCB;
        private System.Windows.Forms.Label labelCaption;
        private Guna.UI2.WinForms.Guna2Panel panelButtons;
        private Guna.UI2.WinForms.Guna2Button button3;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.Label labelMessage;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}