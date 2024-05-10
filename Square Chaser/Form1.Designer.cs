namespace Square_Chaser
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.player1WinLabel = new System.Windows.Forms.Label();
            this.player2WinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Cyan;
            this.winLabel.Location = new System.Drawing.Point(1, 244);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(628, 85);
            this.winLabel.TabIndex = 0;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1WinLabel
            // 
            this.player1WinLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1WinLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1WinLabel.ForeColor = System.Drawing.Color.White;
            this.player1WinLabel.Location = new System.Drawing.Point(119, 9);
            this.player1WinLabel.Name = "player1WinLabel";
            this.player1WinLabel.Size = new System.Drawing.Size(116, 50);
            this.player1WinLabel.TabIndex = 1;
            this.player1WinLabel.Text = "0";
            this.player1WinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2WinLabel
            // 
            this.player2WinLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2WinLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2WinLabel.ForeColor = System.Drawing.Color.White;
            this.player2WinLabel.Location = new System.Drawing.Point(372, 9);
            this.player2WinLabel.Name = "player2WinLabel";
            this.player2WinLabel.Size = new System.Drawing.Size(116, 50);
            this.player2WinLabel.TabIndex = 2;
            this.player2WinLabel.Text = "0";
            this.player2WinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(627, 593);
            this.Controls.Add(this.player2WinLabel);
            this.Controls.Add(this.player1WinLabel);
            this.Controls.Add(this.winLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label player1WinLabel;
        private System.Windows.Forms.Label player2WinLabel;
    }
}

