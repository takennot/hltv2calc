
namespace HLTV2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KAST = new System.Windows.Forms.TextBox();
            this.KPR = new System.Windows.Forms.TextBox();
            this.DPR = new System.Windows.Forms.TextBox();
            this.Impact = new System.Windows.Forms.TextBox();
            this.ADR = new System.Windows.Forms.TextBox();
            this.HLTV_group = new System.Windows.Forms.GroupBox();
            this.adrlabel = new System.Windows.Forms.Label();
            this.impactlabel = new System.Windows.Forms.Label();
            this.dprlabel = new System.Windows.Forms.Label();
            this.kprlabel = new System.Windows.Forms.Label();
            this.kastlabel = new System.Windows.Forms.Label();
            this.rating_calculate = new System.Windows.Forms.Button();
            this.rating = new System.Windows.Forms.TextBox();
            this.KAST_Link = new System.Windows.Forms.LinkLabel();
            this.score1 = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.TextBox();
            this.score_group = new System.Windows.Forms.GroupBox();
            this.var_calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ass_tbx = new System.Windows.Forms.TextBox();
            this.death_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kills_tbx = new System.Windows.Forms.TextBox();
            this.srclink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundslabel = new System.Windows.Forms.Label();
            this.HLTV_group.SuspendLayout();
            this.score_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // KAST
            // 
            this.KAST.Location = new System.Drawing.Point(7, 49);
            this.KAST.Name = "KAST";
            this.KAST.Size = new System.Drawing.Size(204, 29);
            this.KAST.TabIndex = 0;
            // 
            // KPR
            // 
            this.KPR.Location = new System.Drawing.Point(6, 105);
            this.KPR.Name = "KPR";
            this.KPR.Size = new System.Drawing.Size(204, 29);
            this.KPR.TabIndex = 1;
            // 
            // DPR
            // 
            this.DPR.Location = new System.Drawing.Point(7, 161);
            this.DPR.Name = "DPR";
            this.DPR.Size = new System.Drawing.Size(204, 29);
            this.DPR.TabIndex = 2;
            // 
            // Impact
            // 
            this.Impact.Location = new System.Drawing.Point(6, 217);
            this.Impact.Name = "Impact";
            this.Impact.Size = new System.Drawing.Size(204, 29);
            this.Impact.TabIndex = 3;
            // 
            // ADR
            // 
            this.ADR.Location = new System.Drawing.Point(7, 273);
            this.ADR.Name = "ADR";
            this.ADR.Size = new System.Drawing.Size(204, 29);
            this.ADR.TabIndex = 4;
            // 
            // HLTV_group
            // 
            this.HLTV_group.BackColor = System.Drawing.Color.Transparent;
            this.HLTV_group.Controls.Add(this.adrlabel);
            this.HLTV_group.Controls.Add(this.impactlabel);
            this.HLTV_group.Controls.Add(this.dprlabel);
            this.HLTV_group.Controls.Add(this.kprlabel);
            this.HLTV_group.Controls.Add(this.kastlabel);
            this.HLTV_group.Controls.Add(this.rating_calculate);
            this.HLTV_group.Controls.Add(this.rating);
            this.HLTV_group.Controls.Add(this.KAST);
            this.HLTV_group.Controls.Add(this.ADR);
            this.HLTV_group.Controls.Add(this.KPR);
            this.HLTV_group.Controls.Add(this.Impact);
            this.HLTV_group.Controls.Add(this.DPR);
            this.HLTV_group.Location = new System.Drawing.Point(269, 13);
            this.HLTV_group.Name = "HLTV_group";
            this.HLTV_group.Size = new System.Drawing.Size(220, 659);
            this.HLTV_group.TabIndex = 5;
            this.HLTV_group.TabStop = false;
            this.HLTV_group.Text = "HLTV 2.0";
            // 
            // adrlabel
            // 
            this.adrlabel.AutoSize = true;
            this.adrlabel.Location = new System.Drawing.Point(6, 249);
            this.adrlabel.Name = "adrlabel";
            this.adrlabel.Size = new System.Drawing.Size(310, 21);
            this.adrlabel.TabIndex = 11;
            this.adrlabel.Text = "ADR (Average Damage per Round)";
            // 
            // impactlabel
            // 
            this.impactlabel.AutoSize = true;
            this.impactlabel.Location = new System.Drawing.Point(6, 193);
            this.impactlabel.Name = "impactlabel";
            this.impactlabel.Size = new System.Drawing.Size(70, 21);
            this.impactlabel.TabIndex = 10;
            this.impactlabel.Text = "Impact";
            // 
            // dprlabel
            // 
            this.dprlabel.AutoSize = true;
            this.dprlabel.Location = new System.Drawing.Point(6, 137);
            this.dprlabel.Name = "dprlabel";
            this.dprlabel.Size = new System.Drawing.Size(230, 21);
            this.dprlabel.TabIndex = 9;
            this.dprlabel.Text = "DPR (Deaths Per Round)";
            // 
            // kprlabel
            // 
            this.kprlabel.AutoSize = true;
            this.kprlabel.Location = new System.Drawing.Point(6, 81);
            this.kprlabel.Name = "kprlabel";
            this.kprlabel.Size = new System.Drawing.Size(220, 21);
            this.kprlabel.TabIndex = 8;
            this.kprlabel.Text = "KPR (Kills Per Round)";
            // 
            // kastlabel
            // 
            this.kastlabel.AutoSize = true;
            this.kastlabel.Location = new System.Drawing.Point(6, 25);
            this.kastlabel.Name = "kastlabel";
            this.kastlabel.Size = new System.Drawing.Size(50, 21);
            this.kastlabel.TabIndex = 7;
            this.kastlabel.Text = "KAST";
            // 
            // rating_calculate
            // 
            this.rating_calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rating_calculate.BackgroundImage")));
            this.rating_calculate.Location = new System.Drawing.Point(7, 534);
            this.rating_calculate.Name = "rating_calculate";
            this.rating_calculate.Size = new System.Drawing.Size(204, 75);
            this.rating_calculate.TabIndex = 5;
            this.rating_calculate.Text = "Calculate HLTV 2.0 Rating";
            this.rating_calculate.UseVisualStyleBackColor = true;
            this.rating_calculate.Click += new System.EventHandler(this.rating_calculate_Click);
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(7, 624);
            this.rating.Name = "rating";
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(204, 29);
            this.rating.TabIndex = 6;
            // 
            // KAST_Link
            // 
            this.KAST_Link.AutoSize = true;
            this.KAST_Link.BackColor = System.Drawing.Color.Transparent;
            this.KAST_Link.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KAST_Link.Location = new System.Drawing.Point(12, 681);
            this.KAST_Link.Name = "KAST_Link";
            this.KAST_Link.Size = new System.Drawing.Size(290, 21);
            this.KAST_Link.TabIndex = 6;
            this.KAST_Link.TabStop = true;
            this.KAST_Link.Text = "Use csgostats.gg to get KAST";
            this.KAST_Link.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // score1
            // 
            this.score1.Location = new System.Drawing.Point(8, 73);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(52, 29);
            this.score1.TabIndex = 7;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(101, 76);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(20, 21);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "-";
            // 
            // score2
            // 
            this.score2.Location = new System.Drawing.Point(159, 73);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(52, 29);
            this.score2.TabIndex = 9;
            // 
            // score_group
            // 
            this.score_group.BackColor = System.Drawing.Color.Transparent;
            this.score_group.Controls.Add(this.roundslabel);
            this.score_group.Controls.Add(this.label5);
            this.score_group.Controls.Add(this.label4);
            this.score_group.Controls.Add(this.var_calc);
            this.score_group.Controls.Add(this.label3);
            this.score_group.Controls.Add(this.label2);
            this.score_group.Controls.Add(this.ass_tbx);
            this.score_group.Controls.Add(this.death_tbx);
            this.score_group.Controls.Add(this.label1);
            this.score_group.Controls.Add(this.kills_tbx);
            this.score_group.Controls.Add(this.score1);
            this.score_group.Controls.Add(this.scoreLabel);
            this.score_group.Controls.Add(this.score2);
            this.score_group.Location = new System.Drawing.Point(19, 13);
            this.score_group.Name = "score_group";
            this.score_group.Size = new System.Drawing.Size(222, 659);
            this.score_group.TabIndex = 10;
            this.score_group.TabStop = false;
            this.score_group.Text = "Score";
            // 
            // var_calc
            // 
            this.var_calc.BackColor = System.Drawing.Color.Transparent;
            this.var_calc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("var_calc.BackgroundImage")));
            this.var_calc.FlatAppearance.BorderSize = 0;
            this.var_calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.var_calc.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_calc.Location = new System.Drawing.Point(7, 579);
            this.var_calc.Name = "var_calc";
            this.var_calc.Size = new System.Drawing.Size(204, 75);
            this.var_calc.TabIndex = 17;
            this.var_calc.Text = "Calculate variables";
            this.var_calc.UseVisualStyleBackColor = false;
            this.var_calc.Click += new System.EventHandler(this.var_calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Assists";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deaths";
            // 
            // ass_tbx
            // 
            this.ass_tbx.Location = new System.Drawing.Point(159, 138);
            this.ass_tbx.Name = "ass_tbx";
            this.ass_tbx.Size = new System.Drawing.Size(52, 29);
            this.ass_tbx.TabIndex = 13;
            // 
            // death_tbx
            // 
            this.death_tbx.Location = new System.Drawing.Point(82, 138);
            this.death_tbx.Name = "death_tbx";
            this.death_tbx.Size = new System.Drawing.Size(52, 29);
            this.death_tbx.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kills";
            // 
            // kills_tbx
            // 
            this.kills_tbx.Location = new System.Drawing.Point(8, 138);
            this.kills_tbx.Name = "kills_tbx";
            this.kills_tbx.Size = new System.Drawing.Size(52, 29);
            this.kills_tbx.TabIndex = 10;
            // 
            // srclink
            // 
            this.srclink.AutoSize = true;
            this.srclink.BackColor = System.Drawing.Color.Transparent;
            this.srclink.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srclink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.srclink.Location = new System.Drawing.Point(315, 681);
            this.srclink.Name = "srclink";
            this.srclink.Size = new System.Drawing.Size(190, 21);
            this.srclink.TabIndex = 11;
            this.srclink.TabStop = true;
            this.srclink.Text = "Source: flashed.gg";
            this.srclink.Click += new System.EventHandler(this.srclink_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "CT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "T";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // roundslabel
            // 
            this.roundslabel.AutoSize = true;
            this.roundslabel.Location = new System.Drawing.Point(78, 39);
            this.roundslabel.Name = "roundslabel";
            this.roundslabel.Size = new System.Drawing.Size(80, 21);
            this.roundslabel.TabIndex = 20;
            this.roundslabel.Text = " Rounds";
            this.roundslabel.Click += new System.EventHandler(this.roundslabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 711);
            this.Controls.Add(this.srclink);
            this.Controls.Add(this.KAST_Link);
            this.Controls.Add(this.HLTV_group);
            this.Controls.Add(this.score_group);
            this.Font = new System.Drawing.Font("Roboto Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HLTV 2.0 Rating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HLTV_group.ResumeLayout(false);
            this.HLTV_group.PerformLayout();
            this.score_group.ResumeLayout(false);
            this.score_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KAST;
        private System.Windows.Forms.TextBox KPR;
        private System.Windows.Forms.TextBox DPR;
        private System.Windows.Forms.TextBox Impact;
        private System.Windows.Forms.TextBox ADR;
        private System.Windows.Forms.GroupBox HLTV_group;
        private System.Windows.Forms.Button rating_calculate;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.LinkLabel KAST_Link;
        private System.Windows.Forms.TextBox score1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox score2;
        private System.Windows.Forms.GroupBox score_group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ass_tbx;
        private System.Windows.Forms.TextBox death_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kills_tbx;
        private System.Windows.Forms.Button var_calc;
        private System.Windows.Forms.Label kastlabel;
        private System.Windows.Forms.Label kprlabel;
        private System.Windows.Forms.Label dprlabel;
        private System.Windows.Forms.Label impactlabel;
        private System.Windows.Forms.Label adrlabel;
        private System.Windows.Forms.LinkLabel srclink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label roundslabel;
    }
}

