
namespace Configuracao.Templates
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttCIP = new System.Windows.Forms.Button();
            this.buttDADP = new System.Windows.Forms.Button();
            this.buttLauncher = new System.Windows.Forms.Button();
            this.buttP88 = new System.Windows.Forms.Button();
            this.buttSEDIGO = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttSEDIGO);
            this.groupBox1.Controls.Add(this.buttP88);
            this.groupBox1.Controls.Add(this.buttLauncher);
            this.groupBox1.Controls.Add(this.buttDADP);
            this.groupBox1.Controls.Add(this.buttCIP);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttCIP
            // 
            this.buttCIP.Location = new System.Drawing.Point(6, 19);
            this.buttCIP.Name = "buttCIP";
            this.buttCIP.Size = new System.Drawing.Size(123, 51);
            this.buttCIP.TabIndex = 0;
            this.buttCIP.Text = "CIP";
            this.buttCIP.UseVisualStyleBackColor = true;
            this.buttCIP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttCIP_MouseClick);
            // 
            // buttDADP
            // 
            this.buttDADP.Location = new System.Drawing.Point(135, 19);
            this.buttDADP.Name = "buttDADP";
            this.buttDADP.Size = new System.Drawing.Size(123, 51);
            this.buttDADP.TabIndex = 1;
            this.buttDADP.Text = "DADP";
            this.buttDADP.UseVisualStyleBackColor = true;
            // 
            // buttLauncher
            // 
            this.buttLauncher.Location = new System.Drawing.Point(264, 19);
            this.buttLauncher.Name = "buttLauncher";
            this.buttLauncher.Size = new System.Drawing.Size(123, 51);
            this.buttLauncher.TabIndex = 2;
            this.buttLauncher.Text = "Launcher";
            this.buttLauncher.UseVisualStyleBackColor = true;
            // 
            // buttP88
            // 
            this.buttP88.Location = new System.Drawing.Point(6, 76);
            this.buttP88.Name = "buttP88";
            this.buttP88.Size = new System.Drawing.Size(123, 51);
            this.buttP88.TabIndex = 3;
            this.buttP88.Text = "P88";
            this.buttP88.UseVisualStyleBackColor = true;
            // 
            // buttSEDIGO
            // 
            this.buttSEDIGO.Location = new System.Drawing.Point(135, 76);
            this.buttSEDIGO.Name = "buttSEDIGO";
            this.buttSEDIGO.Size = new System.Drawing.Size(123, 51);
            this.buttSEDIGO.TabIndex = 4;
            this.buttSEDIGO.Text = "SEDI-GO";
            this.buttSEDIGO.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 160);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(433, 199);
            this.MinimumSize = new System.Drawing.Size(433, 199);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de sistemas";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttSEDIGO;
        private System.Windows.Forms.Button buttP88;
        private System.Windows.Forms.Button buttLauncher;
        private System.Windows.Forms.Button buttDADP;
        private System.Windows.Forms.Button buttCIP;
    }
}