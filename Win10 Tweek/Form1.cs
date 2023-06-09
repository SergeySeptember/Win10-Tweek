using Microsoft.Win32;
using System.Diagnostics;

namespace Win10_Tweek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RestartExplorer()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("explorer"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteArrow()
        {
            Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons").SetValue("29", "");
            RestartExplorer();
        }

        private void AddArrow()
        {
            RegistryKey rk = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons");
            rk.DeleteValue("29");
            RestartExplorer();
        }


        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (checkBoxArrow.Checked)
            {
                DeleteArrow();
            }
            else
            {
                AddArrow();
            }
        }
    }
}