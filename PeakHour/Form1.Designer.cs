namespace PeakHour
{
    partial class Main
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
            this.btnOkay = new MaterialSkin.Controls.MaterialButton();
            this.btnNeutral = new MaterialSkin.Controls.MaterialButton();
            this.btnEnergetic = new MaterialSkin.Controls.MaterialButton();
            this.btnStressed = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnMetrics = new MaterialSkin.Controls.MaterialButton();
            this.lblIntroText = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSession = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.AutoSize = false;
            this.btnOkay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOkay.Depth = 0;
            this.btnOkay.DrawShadows = true;
            this.btnOkay.HighEmphasis = true;
            this.btnOkay.Icon = null;
            this.btnOkay.Location = new System.Drawing.Point(192, 25);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOkay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(166, 110);
            this.btnOkay.TabIndex = 1;
            this.btnOkay.Text = "Okay";
            this.btnOkay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOkay.UseAccentColor = false;
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnNeutral
            // 
            this.btnNeutral.AutoSize = false;
            this.btnNeutral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNeutral.Depth = 0;
            this.btnNeutral.DrawShadows = true;
            this.btnNeutral.HighEmphasis = true;
            this.btnNeutral.Icon = null;
            this.btnNeutral.Location = new System.Drawing.Point(366, 25);
            this.btnNeutral.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNeutral.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(166, 110);
            this.btnNeutral.TabIndex = 1;
            this.btnNeutral.Text = "Neutral";
            this.btnNeutral.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNeutral.UseAccentColor = false;
            this.btnNeutral.UseVisualStyleBackColor = true;
            this.btnNeutral.Click += new System.EventHandler(this.btnNeutral_Click);
            // 
            // btnEnergetic
            // 
            this.btnEnergetic.AutoSize = false;
            this.btnEnergetic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnergetic.Depth = 0;
            this.btnEnergetic.DrawShadows = true;
            this.btnEnergetic.HighEmphasis = true;
            this.btnEnergetic.Icon = null;
            this.btnEnergetic.Location = new System.Drawing.Point(540, 25);
            this.btnEnergetic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnergetic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnergetic.Name = "btnEnergetic";
            this.btnEnergetic.Size = new System.Drawing.Size(166, 110);
            this.btnEnergetic.TabIndex = 1;
            this.btnEnergetic.Text = "Energetic";
            this.btnEnergetic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEnergetic.UseAccentColor = false;
            this.btnEnergetic.UseVisualStyleBackColor = true;
            this.btnEnergetic.Click += new System.EventHandler(this.btnEnergetic_Click);
            // 
            // btnStressed
            // 
            this.btnStressed.AutoSize = false;
            this.btnStressed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStressed.Depth = 0;
            this.btnStressed.DrawShadows = true;
            this.btnStressed.HighEmphasis = true;
            this.btnStressed.Icon = null;
            this.btnStressed.Image = global::PeakHour.Properties.Resources.stressed1;
            this.btnStressed.Location = new System.Drawing.Point(18, 25);
            this.btnStressed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStressed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStressed.Name = "btnStressed";
            this.btnStressed.Size = new System.Drawing.Size(166, 110);
            this.btnStressed.TabIndex = 1;
            this.btnStressed.Text = "Stressed";
            this.btnStressed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStressed.UseAccentColor = false;
            this.btnStressed.UseVisualStyleBackColor = true;
            this.btnStressed.Click += new System.EventHandler(this.btnStressed_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnEnergetic);
            this.materialCard1.Controls.Add(this.btnOkay);
            this.materialCard1.Controls.Add(this.btnNeutral);
            this.materialCard1.Controls.Add(this.btnStressed);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(41, 218);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(721, 155);
            this.materialCard1.TabIndex = 4;
            // 
            // btnMetrics
            // 
            this.btnMetrics.AutoSize = false;
            this.btnMetrics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMetrics.Depth = 0;
            this.btnMetrics.DrawShadows = true;
            this.btnMetrics.HighEmphasis = true;
            this.btnMetrics.Icon = null;
            this.btnMetrics.Location = new System.Drawing.Point(604, 87);
            this.btnMetrics.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMetrics.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMetrics.Name = "btnMetrics";
            this.btnMetrics.Size = new System.Drawing.Size(158, 58);
            this.btnMetrics.TabIndex = 5;
            this.btnMetrics.Text = "Metrics";
            this.btnMetrics.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMetrics.UseAccentColor = false;
            this.btnMetrics.UseVisualStyleBackColor = true;
            this.btnMetrics.Click += new System.EventHandler(this.btnMetrics_Click);
            // 
            // lblIntroText
            // 
            this.lblIntroText.AutoSize = true;
            this.lblIntroText.Depth = 0;
            this.lblIntroText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIntroText.Location = new System.Drawing.Point(178, 99);
            this.lblIntroText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIntroText.Name = "lblIntroText";
            this.lblIntroText.Size = new System.Drawing.Size(57, 19);
            this.lblIntroText.TabIndex = 0;
            this.lblIntroText.Text = "Session";
            // 
            // cmbSession
            // 
            this.cmbSession.AutoResize = false;
            this.cmbSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSession.Depth = 0;
            this.cmbSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSession.DropDownHeight = 174;
            this.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSession.DropDownWidth = 121;
            this.cmbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.IntegralHeight = false;
            this.cmbSession.ItemHeight = 43;
            this.cmbSession.Items.AddRange(new object[] {
            "7AM  -  9AM",
            "9AM  -  11AM",
            "11AM  -  1PM",
            "1PM  -  3PM",
            "3PM  -  5PM"});
            this.cmbSession.Location = new System.Drawing.Point(257, 87);
            this.cmbSession.MaxDropDownItems = 4;
            this.cmbSession.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(211, 49);
            this.cmbSession.TabIndex = 6;
            this.cmbSession.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbSession_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "You are done for today.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSession);
            this.Controls.Add(this.btnMetrics);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblIntroText);
            this.Name = "Main";
            this.Text = "PeakHour";
            this.Load += new System.EventHandler(this.Main_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnStressed;
        private MaterialSkin.Controls.MaterialButton btnOkay;
        private MaterialSkin.Controls.MaterialButton btnNeutral;
        private MaterialSkin.Controls.MaterialButton btnEnergetic;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnMetrics;
        private MaterialSkin.Controls.MaterialLabel lblIntroText;
        private MaterialSkin.Controls.MaterialComboBox cmbSession;
        private System.Windows.Forms.Label label1;
    }
}

