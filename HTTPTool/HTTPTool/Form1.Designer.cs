namespace HTTPTool
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceiveDisplay = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnInsertHTTP = new System.Windows.Forms.Button();
            this.btnInsertPost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCountSelected = new System.Windows.Forms.Button();
            this.ClearSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGetResource = new System.Windows.Forms.TextBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(639, 149);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 34);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceiveDisplay
            // 
            this.txtReceiveDisplay.Location = new System.Drawing.Point(12, 227);
            this.txtReceiveDisplay.Multiline = true;
            this.txtReceiveDisplay.Name = "txtReceiveDisplay";
            this.txtReceiveDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceiveDisplay.Size = new System.Drawing.Size(564, 261);
            this.txtReceiveDisplay.TabIndex = 1;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(12, 36);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequest.Size = new System.Drawing.Size(564, 185);
            this.txtRequest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(110, 10);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(119, 20);
            this.txtIPAddress.TabIndex = 4;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(282, 10);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(59, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "80";
            // 
            // btnInsertHTTP
            // 
            this.btnInsertHTTP.Location = new System.Drawing.Point(582, 57);
            this.btnInsertHTTP.Name = "btnInsertHTTP";
            this.btnInsertHTTP.Size = new System.Drawing.Size(118, 35);
            this.btnInsertHTTP.TabIndex = 7;
            this.btnInsertHTTP.Text = "Sample GET   [ASP]";
            this.btnInsertHTTP.UseVisualStyleBackColor = true;
            this.btnInsertHTTP.Click += new System.EventHandler(this.btnInsertHTTP_Click);
            // 
            // btnInsertPost
            // 
            this.btnInsertPost.Location = new System.Drawing.Point(709, 57);
            this.btnInsertPost.Name = "btnInsertPost";
            this.btnInsertPost.Size = new System.Drawing.Size(118, 35);
            this.btnInsertPost.TabIndex = 8;
            this.btnInsertPost.Text = "Sample POST  [PHP]";
            this.btnInsertPost.UseVisualStyleBackColor = true;
            this.btnInsertPost.Click += new System.EventHandler(this.btnInsertPost_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(639, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 33);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Receive";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCountSelected
            // 
            this.btnCountSelected.Location = new System.Drawing.Point(639, 269);
            this.btnCountSelected.Name = "btnCountSelected";
            this.btnCountSelected.Size = new System.Drawing.Size(117, 35);
            this.btnCountSelected.TabIndex = 10;
            this.btnCountSelected.Text = "Count Selected";
            this.btnCountSelected.UseVisualStyleBackColor = true;
            this.btnCountSelected.Click += new System.EventHandler(this.btnCountSelected_Click);
            // 
            // ClearSend
            // 
            this.ClearSend.Location = new System.Drawing.Point(639, 376);
            this.ClearSend.Name = "ClearSend";
            this.ClearSend.Size = new System.Drawing.Size(117, 35);
            this.ClearSend.TabIndex = 11;
            this.ClearSend.Text = "Clear Send";
            this.ClearSend.UseVisualStyleBackColor = true;
            this.ClearSend.Click += new System.EventHandler(this.ClearSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(619, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Build Your REQUEST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(607, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Examine the RESPONSE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(636, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Clear FIELDS";
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(582, 98);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(118, 35);
            this.btnGetImage.TabIndex = 15;
            this.btnGetImage.Text = "Sample GET   [JPG]";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Resource to GET";
            // 
            // txtGetResource
            // 
            this.txtGetResource.Location = new System.Drawing.Point(455, 10);
            this.txtGetResource.Name = "txtGetResource";
            this.txtGetResource.Size = new System.Drawing.Size(351, 20);
            this.txtGetResource.TabIndex = 17;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(709, 98);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(118, 35);
            this.btnCustom.TabIndex = 18;
            this.btnCustom.Text = "Custom GET";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 500);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.txtGetResource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearSend);
            this.Controls.Add(this.btnCountSelected);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsertPost);
            this.Controls.Add(this.btnInsertHTTP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.txtReceiveDisplay);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "HTTP Message Sender/Receiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtReceiveDisplay;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnInsertHTTP;
        private System.Windows.Forms.Button btnInsertPost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCountSelected;
        private System.Windows.Forms.Button ClearSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGetResource;
        private System.Windows.Forms.Button btnCustom;
    }
}

