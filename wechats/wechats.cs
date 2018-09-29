using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace wechat
{
    public partial class wechats : Form
    {

        //配置文件路径
        string configPath = "C:\\ProgramData\\hux.properties";

        public wechats()
        {
            InitializeComponent();
        }

        private void btn_qd_Click(object sender, EventArgs e)
        {
            //用户填写的微信安装路径(去除双引号后的)
            String path = txt_path.Text.Replace("\"", "");

            if (path.Length == 0)
            {
                MessageBox.Show("请输入微信的安装路径", "提示", MessageBoxButtons.OK);
                return;
            }

            //打开微信的个数
            int num = int.Parse(cbox_num.SelectedItem.ToString());

            try
            {
                for (int i = 0; i < num; i++)
                {
                    System.Diagnostics.Process.Start(path);
                }
                //创建文件，并向里面写入微信安装路径
                FileStream fs = new FileStream(configPath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(path);
                sw.WriteLine(num);
                sw.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK);
                return;
            }
            //退出程序
            Application.Exit();
        }

        private void Wechat_Load(object sender, EventArgs e)
        {
            cbox_num.SelectedIndex = 0;
            //判断文件是否存在
            if (File.Exists(configPath))
            {
                //文件读取流
                StreamReader sr = new StreamReader(configPath, Encoding.Default);
                //第一行数据是微信的安装路径
                string wechatPath = sr.ReadLine();

                if (wechatPath != null)
                {
                    this.txt_path.Text = wechatPath;
                }
                //第二行数据是打开微信的个数
                string num = sr.ReadLine();
                if (num != null)
                {
                    //设置下拉框索引
                    cbox_num.SelectedIndex = int.Parse(num) - 1;
                }
                sr.Close();
            }
        }

        private void txt_path_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            string filepath = dialog.FileName;

            if (filepath != null && filepath.Length != 0)
            {
                this.txt_path.Text = dialog.FileName;
            }

        }
    }
}
