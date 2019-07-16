using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSyn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            Stopwatch sTime = new Stopwatch();
            sTime.Start();
            HttpClient http = new HttpClient();

            foreach (var url in GetUrl())
            {
                string response = http.GetStringAsync(url).Result;
                listBox.Items.Add(response.Length);
            }
            sTime.Stop();
            listBox.Items.Add("Millisaniye: - " + sTime.ElapsedMilliseconds);
        }

        private async void BtnAsny_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            Stopwatch sTime = new Stopwatch();
            sTime.Start();
            HttpClient http = new HttpClient();

            foreach (var url in GetUrl())
            {
                string response =await http.GetStringAsync(url);
                listBox.Items.Add(response.Length);
            }
            sTime.Stop();
            listBox.Items.Add("Millisaniye: - " + sTime.ElapsedMilliseconds);
        }

        private async void BtnParalel_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            Stopwatch sTime = new Stopwatch();
            sTime.Start();
            var tasks = new List<Task<string>>();

            foreach (var url in GetUrl())
            {
                HttpClient http = new HttpClient();
                tasks.Add(http.GetStringAsync(url));
            }

            await Task.WhenAll(tasks);

            foreach (var task in tasks)
            {
                listBox.Items.Add(task.Result.Length);
            }
            sTime.Stop();
            listBox.Items.Add("Millisaniye: - "+sTime.ElapsedMilliseconds);
        }

        private string[] GetUrl()
        {
            string[] result =
            {
                "https://www.google.az/",
                "https://www.youtube.com/",
                "https://best.aliexpress.com/"
            };

            return result;
        }

        




        //private async void BtnSny_Click(object sender, EventArgs e)
        //{

        //    long sum = await GetSum();
        //    BtnAsny.Text = sum.ToString();
        //}

        //private async Task<long> GetSum()
        //{
        //    long sum = 0;

        //    Task task = Task.Run(() => {
        //        for (int i = 0; i < 1000000000; i++)
        //        {
        //            sum += i;
        //        }
        //    });

        //    await task;

        //    return sum;
        //}


    }
}
