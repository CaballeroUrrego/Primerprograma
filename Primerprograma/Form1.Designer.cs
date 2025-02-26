namespace Primerprograma
{
    partial class Form1
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
            btnVerMensaje = new Button();
            SuspendLayout();
            // 
            // btnVerMensaje
            // 
            btnVerMensaje.Location = new Point(116, 171);
            btnVerMensaje.Name = "btnVerMensaje";
            btnVerMensaje.Size = new Size(129, 29);
            btnVerMensaje.TabIndex = 0;
            btnVerMensaje.Text = "Ver mensaje";
            btnVerMensaje.UseVisualStyleBackColor = true;
            btnVerMensaje.Click += new System.EventHandler(this.btnVerMensaje_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 450);
            Controls.Add(btnVerMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerMensaje;
    }
}
