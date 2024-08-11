namespace WebView2FormsApp.Forms
{
    partial class MainForm
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
            webView2Main = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView2Main).BeginInit();
            SuspendLayout();
            // 
            // webView2Main
            // 
            webView2Main.AllowExternalDrop = true;
            webView2Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView2Main.CreationProperties = null;
            webView2Main.DefaultBackgroundColor = Color.White;
            webView2Main.Location = new Point(12, 12);
            webView2Main.Name = "webView2Main";
            webView2Main.Size = new Size(652, 426);
            webView2Main.Source = new Uri("https://www.junian.dev/", UriKind.Absolute);
            webView2Main.TabIndex = 0;
            webView2Main.ZoomFactor = 1D;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(webView2Main);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)webView2Main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Main;
    }
}