using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Millet_house_shopping
{
    public partial class Form1 : Form
    {
        private Thread trd;
        static AutoResetEvent myResetEvent = new AutoResetEvent(false);

        public Form1()
        {
            InitializeComponent();
        }
        private void ThreadTask()
        {
            input_message.Text += 2 + "\r\n";
            input_message.Text += 500 + "\r\n";
            input_message.Text += 1 + "\r\n";
            input_message.Text += 1000 + "\r\n";
            input_message.Select(input_message.TextLength - 1, 0);
            while (true)
            {               
                myResetEvent.WaitOne();//点击按钮后，程序开始由此执行  
                result_textBox1.Clear();
                int _prices_size = 0;
                _prices_size = Convert.ToInt32(input_message.Lines[0]);
                string[] arr = new string[_prices_size+2];

                for (int i = 0; i < arr.Length; i++)//读取各种商品的单价为字符
                {
                    arr[i] = input_message.Lines[i];
                    //result_textBox1.Text += arr[i] + "\r\n";
                }

                int _budget = Convert.ToInt32(arr[_prices_size + 1]);//获取商品预算
                int[] dp = new int[_budget + 1];
                for (int i = 0; i < dp.Length; i++)
                {
                    dp[i] = int.MaxValue - 1;
                }

                int[] _prices = new int[_prices_size];
                for (int _prices_i = 0; _prices_i < _prices_size; _prices_i++)//将商品单价字符转化为整形
                {                   
                    _prices[_prices_i] = Convert.ToInt32(arr[_prices_i+1]);
                    if (_prices[_prices_i]<=_budget)//由于dp[i]数组大小有限制，因此必须限制i小于预算值
                    {
                        dp[_prices[_prices_i]] = 1;//然后让商品价格等于预算值时，可以买到商品数量的值设置为1
                    }
                }

                for (int i = 1; i <= _budget; i++)
                {
                    if (dp[i] == int.MaxValue - 1)
                    {
                        for (int j = 0; j < _prices.Length; j++)
                        {
                            if (_prices[j] < i)
                            {
                                dp[i] = Math.Min(dp[i], dp[i - _prices[j]] + 1);
                            }
                        }
                    }
                }
                dp[_budget]=dp[_budget] == int.MaxValue - 1 ? -1 : dp[_budget];
                result_textBox1.Text += "能买产品数为" + dp[_budget] + "\r\n";
            }
        }

        private void init_Load(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            Control.CheckForIllegalCrossThreadCalls = false;

            trd.Priority = ThreadPriority.Highest;
            trd.Start();
        }

        private void START_BUTTON_Click(object sender, EventArgs e)
        {
            myResetEvent.Set();//点击按钮后释放线程的等待   
        }
    }
}


