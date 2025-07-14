namespace PrjFutebolBotao
{
    partial class frmNovoJogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTime1 = new Label();
            lblTime2 = new Label();
            btnSelectTime1minus = new Panel();
            btnSelectTime1plus = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnNovoJogo = new Button();
            btnSair = new Button();
            panel5 = new Panel();
            imgTime1 = new Panel();
            imgTime2 = new Panel();
            SuspendLayout();
            // 
            // lblTime1
            // 
            lblTime1.Font = new Font("Roboto Flex", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime1.ForeColor = Color.WhiteSmoke;
            lblTime1.Location = new Point(25, 203);
            lblTime1.Name = "lblTime1";
            lblTime1.Size = new Size(208, 37);
            lblTime1.TabIndex = 2;
            lblTime1.Text = "{{TIME1}}";
            lblTime1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime2
            // 
            lblTime2.Font = new Font("Roboto Flex", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime2.ForeColor = Color.WhiteSmoke;
            lblTime2.Location = new Point(331, 203);
            lblTime2.Name = "lblTime2";
            lblTime2.Size = new Size(208, 37);
            lblTime2.TabIndex = 3;
            lblTime2.Text = "{{TIME1}}";
            lblTime2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectTime1minus
            // 
            btnSelectTime1minus.BackColor = Color.LawnGreen;
            btnSelectTime1minus.Location = new Point(17, 109);
            btnSelectTime1minus.Name = "btnSelectTime1minus";
            btnSelectTime1minus.Size = new Size(30, 30);
            btnSelectTime1minus.TabIndex = 4;
            btnSelectTime1minus.MouseClick += btnSelectTime1minus_MouseClick;
            // 
            // btnSelectTime1plus
            // 
            btnSelectTime1plus.BackColor = Color.LawnGreen;
            btnSelectTime1plus.Location = new Point(209, 109);
            btnSelectTime1plus.Name = "btnSelectTime1plus";
            btnSelectTime1plus.Size = new Size(30, 30);
            btnSelectTime1plus.TabIndex = 5;
            btnSelectTime1plus.MouseClick += btnSelectTime1plus_MouseClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LawnGreen;
            panel3.Location = new Point(323, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 30);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LawnGreen;
            panel4.Location = new Point(515, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(30, 30);
            panel4.TabIndex = 5;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.Location = new Point(111, 289);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(157, 39);
            btnNovoJogo.TabIndex = 6;
            btnNovoJogo.Text = "Começar o Jogo";
            btnNovoJogo.UseVisualStyleBackColor = true;
            btnNovoJogo.Click += btnNovoJogo_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(296, 289);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(157, 39);
            btnSair.TabIndex = 7;
            btnSair.Text = "Finalizar o Jogo";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(241, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(80, 80);
            panel5.TabIndex = 8;
            // 
            // imgTime1
            // 
            imgTime1.BackgroundImage = Properties.Resources.Santos;
            imgTime1.BackgroundImageLayout = ImageLayout.Stretch;
            imgTime1.Location = new Point(53, 50);
            imgTime1.Name = "imgTime1";
            imgTime1.Size = new Size(150, 150);
            imgTime1.TabIndex = 9;
            // 
            // imgTime2
            // 
            imgTime2.BackgroundImageLayout = ImageLayout.Stretch;
            imgTime2.Location = new Point(359, 50);
            imgTime2.Name = "imgTime2";
            imgTime2.Size = new Size(150, 150);
            imgTime2.TabIndex = 10;
            // 
            // frmNovoJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(561, 340);
            Controls.Add(imgTime2);
            Controls.Add(imgTime1);
            Controls.Add(panel5);
            Controls.Add(btnSair);
            Controls.Add(btnNovoJogo);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnSelectTime1plus);
            Controls.Add(btnSelectTime1minus);
            Controls.Add(lblTime2);
            Controls.Add(lblTime1);
            Name = "frmNovoJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Jogo";
            ResumeLayout(false);
        }

        #endregion
        private Label lblTime1;
        private Label lblTime2;
        private Panel btnSelectTime1minus;
        private Panel btnSelectTime1plus;
        private Panel panel3;
        private Panel panel4;
        private Button btnNovoJogo;
        private Button btnSair;
        private Panel panel5;
        private ImageList imageList1;
        private Panel imgTime1;
        private Panel imgTime2;
    }
}
