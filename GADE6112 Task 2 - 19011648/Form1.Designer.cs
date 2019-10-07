namespace GADE6112_Task_2___19011648
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
            this.components = new System.ComponentModel.Container();
            this.gpbxMap = new System.Windows.Forms.GroupBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.tmrRound = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpbxMap
            // 
            this.gpbxMap.Location = new System.Drawing.Point(12, 12);
            this.gpbxMap.Name = "gpbxMap";
            this.gpbxMap.Size = new System.Drawing.Size(627, 515);
            this.gpbxMap.TabIndex = 0;
            this.gpbxMap.TabStop = false;
            this.gpbxMap.Text = "Map";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(656, 44);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(58, 17);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round: ";
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(659, 74);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(307, 32);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "Start Sim";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(659, 146);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(307, 381);
            this.txtOut.TabIndex = 3;
            // 
            // tmrRound
            // 
            this.tmrRound.Interval = 1000;
            this.tmrRound.Tick += new System.EventHandler(this.TmrRound_Tick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(821, 112);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 539);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.gpbxMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxMap;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Timer tmrRound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

