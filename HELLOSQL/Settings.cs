using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLOSQL
{
    public partial class Settings : Form
    {
        Form1 mainFrm;
        private bool chk_userid_save;

        private string saved_address;
        private string saved_port;
        private string saved_service;
        private string saved_id;
        private string saved_pw;

        public Settings(Form1 _mainFrm)
        {
            InitializeComponent();
            this.mainFrm = _mainFrm;
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            if ((address_text.Text == "") | (port_text.Text == "") | (service_text.Text == "") | (id_text.Text == ""))
            {
                MessageBox.Show("다 적어주셈", "확인", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Form1.BusyIndicator(true);

            // 사용자 ID 저장 여부에 변경이 있을 경우
            bool change_check = false;
            if (save_box.Checked != chk_userid_save)
            {
                change_check = true;
            }

            else if ((save_box.Checked == true) & (address_text.Text != saved_address) & (port_text.Text != saved_port) & (service_text.Text != saved_service) & (id_text.Text != saved_id) & (pw_text.Text != saved_pw))
            {
                change_check = true;
            }

            // 변환이 있을경우 업데이트를 해준다.
            if (change_check == true)
            {
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    settings["address"].Value = address_text.Text;
                    settings["port"].Value = port_text.Text;
                    settings["service"].Value = service_text.Text;
                    settings["id"].Value = id_text.Text;
                    settings["pw"].Value = pw_text.Text;
                    settings["userid_save"].Value = save_box.Checked == true ? "1" : "0";
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            SQLConnect.oracle_address = address_text.Text;
            SQLConnect.oracle_port = port_text.Text;
            SQLConnect.oracle_service = service_text.Text;
            SQLConnect.oracle_id = id_text.Text;
            SQLConnect.oracle_pw = pw_text.Text;
            Form1.oracle_id = id_text.Text;
            this.Close();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            string userid_save = ConfigurationManager.AppSettings["userid_save"];
            if (userid_save.Equals("1"))
            {
                save_box.Checked = true;
                address_text.Text = ConfigurationManager.AppSettings["address"];
                port_text.Text = ConfigurationManager.AppSettings["port"];
                service_text.Text = ConfigurationManager.AppSettings["service"];
                id_text.Text = ConfigurationManager.AppSettings["id"];
                pw_text.Text = ConfigurationManager.AppSettings["pw"];

                saved_address = address_text.Text;
                saved_port = port_text.Text;
                saved_service = service_text.Text;
                saved_id = id_text.Text;
                saved_pw = pw_text.Text;

                chk_userid_save = true;
            }
            else
            {
                save_box.Checked = false;
                chk_userid_save = false;
            }
        }

        private void save_box_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
