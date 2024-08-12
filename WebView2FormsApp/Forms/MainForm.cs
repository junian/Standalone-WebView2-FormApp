
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2FormsApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += async (_, __) =>
            {
                var runtimePath = Path.Combine(
                    /*
                                AppContext.BaseDirectory,
                    */
                    AppDomain.CurrentDomain.BaseDirectory,
                                "WebView2");
                try
                {
                    
                    var webView = new Microsoft.Web.WebView2.WinForms.WebView2()
                    {
                        Dock = DockStyle.Fill
                    };
                    await webView.EnsureCoreWebView2Async(
                        await CoreWebView2Environment
                            .CreateAsync(runtimePath)
                        );

                    Controls.Add(webView);
                    webView.CoreWebView2.Navigate("https://junian.dev");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{runtimePath}{Environment.NewLine}{ex.ToString()}");
                }
            };
        }
    }
}
