using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        int[] arr, arrBubble, arrShell, arrShaker;
        float bT, cT, shkT;
        int bP, cP, shkP;
        int bS, cS, shkS;

        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == String.Empty || border1.Text == String.Empty || border2.Text == String.Empty)
            {
                return;
            }
            try
            {
                int size = Int32.Parse(inputBox.Text);
                int b1 = Int32.Parse(border1.Text);
                int b2 = Int32.Parse(border2.Text);
                bT = cT = shkT = 0f;
                bP = cP = shkP = 0;
                bS = cS = shkS = 0;

                arr = new int [size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(b1, b2);
                }
                arrBubble = arrShaker = arrShell = arr;
                notSortBox.DataSource = arr;
            } catch
            {
                inputBox.Text = String.Empty;
                return;
            }
            startP.Visible = false;
            sortP.Visible = true;

            // sort
            Thread bubble = new Thread(new ParameterizedThreadStart(Bubble));
            Thread ctrl = new Thread(new ParameterizedThreadStart(CtrlV));
            Thread shaker = new Thread(new ParameterizedThreadStart(Select));

            bubble.Start(arrBubble);
            ctrl.Start(arrShell);
            shaker.Start(arrShaker);
        }

        private void Bubble(Object array)
        {
            int[] arr = (int[])array;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;

                        bP++;
                        bS++;
                    } else
                    {
                        bS++;
                    }
                }
            }

            stopwatch.Stop();
            bT = stopwatch.ElapsedMilliseconds / 1000;

            bubbleB.BeginInvoke((MethodInvoker)(() => bubbleB.DataSource = arr));
            bubbleT.BeginInvoke((MethodInvoker)(() => bubbleT.Text += $" {bT}"));
            bubbleP.BeginInvoke((MethodInvoker)(() => bubbleP.Text += $" {bP}"));
            bubbleS.BeginInvoke((MethodInvoker)(() => bubbleS.Text += $" {bS}"));

            MessageBox.Show("Bubble sort was end");
        }
        private void CtrlV(Object array)
        {
            int[] arr = (int[])array;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < arr.Length; i++)
            {
                var tmp = arr[i];
                var hole = i;
                while (hole > 0 && arr[hole] > tmp)
                {
                    arr[hole + 1] = arr[hole];
                    hole--;
                    cS++;
                    cP++;
                }
                arr[hole] = tmp;
                cP++;
            }

            stopwatch.Stop();
            cT = stopwatch.ElapsedMilliseconds / 1000;

            ctrl.BeginInvoke((MethodInvoker)(() => ctrl.DataSource = arr));
            ctrlT.BeginInvoke((MethodInvoker)(() => ctrlT.Text += $" {cT}"));
            ctrlP.BeginInvoke((MethodInvoker)(() => ctrlP.Text += $" {cP}"));
            ctrlS.BeginInvoke((MethodInvoker)(() => ctrlS.Text += $" {cS}"));

            MessageBox.Show("Ctrl_V sort was end");
        }
        private void Select(Object array)
        {
            int[] arr = (int[])array;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < arr.Length-1; i++)
            {
                var minEl = arr[i];
                var minI = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < minEl)
                    {
                        minEl = arr[j];
                        minI = j;
                        int tmp = arr[i];
                        arr[i] = arr[minI];
                        arr[minI] = tmp;

                        shkS++;
                        shkP =+ 2;
                    } else
                    {
                        shkS++;
                    }
                }
            }

            stopwatch.Stop();
            shkT = stopwatch.ElapsedMilliseconds / 1000;

            shaker.BeginInvoke((MethodInvoker)(() => shaker.DataSource = arr));
            shakerT.BeginInvoke((MethodInvoker)(() => shakerT.Text += $" {shkT}"));
            shakerP.BeginInvoke((MethodInvoker)(() => shakerP.Text += $" {shkP}"));
            shakerS.BeginInvoke((MethodInvoker)(() => shakerS.Text += $" {shkS}"));

            MessageBox.Show("Shaker sort was end");
        }
    }
}
