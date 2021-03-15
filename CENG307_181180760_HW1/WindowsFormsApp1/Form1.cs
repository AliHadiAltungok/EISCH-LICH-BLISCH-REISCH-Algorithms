using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int[] randArrayKeys = new int[] { };  // 1000 % 90 = 900
        Random rnd = new Random();
        int[] lichArrayRecord = new int[] { };
        int[] lichArrayLink = new int[] { };
        int[] lichArrayProbes = new int[] { };

        int[] eischArrayRecord = new int[] { };
        int[] eischArrayLink = new int[] { };
        int[] eischArrayProbes = new int[] { };

        int[] reischArrayRecord = new int[] { };
        int[] reischArrayLink = new int[] { };
        int[] reischArrayProbes = new int[] { };

        int[] blischArrayRecord = new int[] { };
        int[] blischArrayLink = new int[] { };
        int[] blischArrayProbes = new int[] { };

        public void fillNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
        }
        public int makePrime(int x)
        {
            while (true)
            {
                int f = 0;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0) { f = 1; }
                }
                if (f == 0) { return x; } else { x++; }
            }            
        }
        public int search(int [] record,int[] link, int searchNum, int mod)
        {
            if (record[mod] == searchNum)
            {
                return mod;
            }
            else
            {
                return search(record,link, searchNum, link[mod]);
            }
        }
        public int modAl(int sayi)
        {
           int a= Convert.ToInt32(TotalAreaSize.Text);
            return sayi % a;
            
            
        }
        public int modAlLICH(int sayi)
        {
            int a = Convert.ToInt32(primaryAreaSize.Text);
            return sayi % a;
            
        }
        public void probHesabı(int[] randArrayKeys, int[] record, int[] link, int[] probes)
        {
            for (int i = 0; i < randArrayKeys.Length; i++)
            {
                int a = randArrayKeys[i];
                probesHesabı2(record, link, probes, a, modAl(a), 0);
            }
        }
        public void probHesabı(int[] randArrayKeys, int[] record, int[] link, int[] probes, string Lich)
        {
            for (int i = 0; i < randArrayKeys.Length; i++)
            {
                int a = randArrayKeys[i];
                probesHesabı2(record, link, probes, a, modAlLICH(a), 0);
            }
        }
        public void probesHesabı2(int[] record, int[] link, int[] probes, int searchNum, int mod, int x)
        {
            x++;
            if (record[mod] == searchNum)
            {
                probes[mod] = x;
            }
            else
            {
                probesHesabı2(record, link, probes, searchNum, link[mod], x);
            }
        }
        /////////////////////////      BLISCH              //////////////////////
        public void BLISCH(int[] randArrayKeys, int[] record, int[] link, int[] probes, int prbNum)
        {
            int firstFlag=0;
            for (int i = 0; i < randArrayKeys.Length; i++)
            {
                int mod = modAl(randArrayKeys[i]); // % 1000
                if (record[mod] == -1)
                {
                    record[mod] = randArrayKeys[i];
                    probes[mod]++;
                }
                else
                {
                    if (firstFlag == 0) { firstFlag = 1; }
                    else if (firstFlag == 1) { firstFlag = 0; }
                    BLISCH2(record, link, randArrayKeys[i], mod, probes, prbNum + 1, firstFlag);
                }
            }
        }
        public void BLISCH2(int[] record, int[] link, int num, int mod, int[] probes, int prbNum, int flag)
        {
            prbNum++;
            if (flag == 0)
            {
                for (int i = (record.Length - 1); i >=  0; i--)
                {
                    if (record[i] == -1)
                    {
                        record[i] = num;
                        probes[i] = prbNum;
                        
                        if (link[mod] == -1)
                        {
                            link[mod] = i;
                            flag = 1;
                        }
                        else
                        {
                            record[i] = -1;
                            probes[i] = 0;
                           
                            BLISCH2(record, link, num, link[mod], probes, prbNum, flag);
                        }
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < record.Length; i++)
                {
                    if (record[i] == -1)
                    {
                        record[i] = num;
                        probes[i] = prbNum;
                        
                        if (link[mod] == -1)
                        {
                            flag = 0;
                            link[mod] = i;
                        }
                        else
                        {
                            record[i] = -1;
                            probes[i] = 0;
                            
                            BLISCH2(record, link, num, link[mod], probes, prbNum, flag);
                        }
                        break;
                    }
                }
            }
        }
        //////////////////      REISCH               //////////////
        public void REISCH(int[] randArrayKeys, int[] record, int[] link, int[] probes, int prbNum)
        {
            Random rnd = new Random();
            for (int i = 0; i < randArrayKeys.Length; i++)
            {

                int mod = modAl(randArrayKeys[i]); // %1000 
                if (record[mod] == -1)
                {
                    record[mod] = randArrayKeys[i];
                    probes[mod] = 1; //++;
                }
                else
                {
                    int a;
                    prbNum++;
                    while (true)
                    {
                        a = rnd.Next(0, record.Length);
                        if (record[a] == -1) { break; }
                    }
                    record[a] = randArrayKeys[i];
                    probes[a] = 2;
                    if (link[mod] == -1)
                    {


                        link[mod] = a;
                    }
                    else
                    {
                        int f = mod;
                        while (true)
                        {
                            if (link[f] != -1)
                            {
                                f = link[f];
                                probes[f]++;//if (modAl(record[f]) == mod) { probes[f]++; }
                            }
                            else
                            {
                                break;
                            }
                        }
                        link[a] = link[mod];
                        link[mod] = a;
                    }

                }

            }
        }
        /////////////////////////      EISCH       //////////////////////////
        public void EISCH(int[] randArrayKeys, int[] record, int[] link, int[] probes, int prbNum)
        {
            for (int i = 0; i < randArrayKeys.Length; i++)
            {
                int mod = modAl(randArrayKeys[i]); // % 1000 
                if (record[mod] == -1)
                {
                    record[mod] = randArrayKeys[i];
                    probes[mod] = 1; //++;
                }
                else
                {
                    for (int j = (record.Length - 1); j >= 0; j--)
                    {
                        if (record[j] == -1)
                        {
                            probes[j] = 2;  
                            record[j] = randArrayKeys[i];
                            if (link[mod] == -1)       
                            {
                                link[mod] = j;
                            }
                            else
                            {
                                int k = mod;
                                while (true)
                                {

                                    if (link[k] != -1)
                                    {
                                        k = link[k];
                                        if (modAl(record[k]) == mod)
                                        {   
                                            probes[k]++;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                link[j] = link[mod];
                                link[mod] = j;
                            }
                            break;
                        }
                    }
                }
            }
        }
        /////////////////////////      LICH       /////////////////////////////
        public void LICH(int[] randArrayKeys, int[] record, int[] link, int[] probes, int prbNum) //2 fonk lich ve lich2
        {
            for (int i = 0; i < randArrayKeys.Length; i++)
            {
                int mod = modAlLICH(randArrayKeys[i]); // %860
                if (record[mod] == -1)
                {
                    record[mod] = randArrayKeys[i];
                    probes[mod]++;
                }
                else
                {
                    LICH2(record, link, randArrayKeys[i], mod, probes, prbNum + 1);
                }
            }
        }
        public void LICH2(int[] record, int[] link, int num, int linkNum, int[] probes, int prbNum)
        {
            prbNum++;
            for (int i = (record.Length - 1); i >= 0; i--)
            {
                if (record[i] == -1)
                {
                    record[i] = num;
                    probes[i] = prbNum;
                    if (link[linkNum] == -1)
                    {
                        link[linkNum] = i;

                    }
                    else
                    {
                        record[i] = -1;
                        probes[i] = 0;
                        LICH2(record, link, num, link[linkNum], probes, prbNum);
                    }
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewRandomArrayKeys.Rows.Clear();
            
            int diziBoyut;
            try
            {
                diziBoyut=Convert.ToInt32(textBoxRandomKeysDiziBoyutu.Text);
                if (diziBoyut <= 0)
                {
                    MessageBox.Show("Please enter a positive integer.");
                }else if(diziBoyut > 900)
                {
                    MessageBox.Show("Please enter a number that is not bigger than 900.");
                }
                else
                {
                    int o = (diziBoyut * 100) / 90;
                    o = makePrime(o);

                    randArrayKeys = new int[diziBoyut];                    
                    lichArrayRecord = new int[o];lichArrayLink = new int[o];lichArrayProbes = new int[o];
                    eischArrayRecord = new int[o];eischArrayLink = new int[o]; eischArrayProbes = new int[o];
                    reischArrayRecord = new int[o]; reischArrayLink = new int[o]; reischArrayProbes = new int[o];
                    blischArrayRecord = new int[o]; blischArrayLink = new int[o]; blischArrayProbes = new int[o];
                    
                    int a = (o * 86) / 100; 
                    primaryAreaSize.Text = a.ToString();
                    TotalAreaSize.Text = o.ToString();
                    PackingFactorSize.Text = String.Format("{0:0.####}", ((double)diziBoyut / o) * 100);
                    for (int i = 0; i < randArrayKeys.Length; i++)
                    {
                        int x= rnd.Next(1, 5000); 
                        int flg = 0;

                        for (int j = 0; j < randArrayKeys.Length; j++)
                        {
                            if (randArrayKeys[j] == x) { flg = 1; }
                        }
                        if (flg == 1) { i--; } else { randArrayKeys[i] = x; }
                    }
                      
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
                for (int i = 0; i < randArrayKeys.Length; i++)
                {
                dataGridViewRandomArrayKeys.Rows.Add(new object[] { i + 1, randArrayKeys[i] });
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch wLICH = new Stopwatch();
            Stopwatch wEISCH = new Stopwatch();
            Stopwatch wREISCH = new Stopwatch();
            Stopwatch wBLISCH = new Stopwatch();

            fillNegative(lichArrayRecord); fillNegative(lichArrayLink); fillNegative(lichArrayProbes);
            fillNegative(eischArrayRecord); fillNegative(eischArrayLink); fillNegative(eischArrayProbes);
            fillNegative(reischArrayRecord); fillNegative(reischArrayLink); fillNegative(reischArrayProbes);
            fillNegative(blischArrayRecord); fillNegative(blischArrayLink); fillNegative(blischArrayProbes);
            wLICH.Start();
            LICH(randArrayKeys, lichArrayRecord, lichArrayLink, lichArrayProbes, 0);
            wLICH.Stop();
            fillNegative(lichArrayProbes);
            probHesabı(randArrayKeys, lichArrayRecord, lichArrayLink, lichArrayProbes, "lich");

            wEISCH.Start();
            EISCH(randArrayKeys, eischArrayRecord, eischArrayLink, eischArrayProbes, 0);
            wEISCH.Stop();
            fillNegative(eischArrayProbes);
            probHesabı(randArrayKeys, eischArrayRecord, eischArrayLink, eischArrayProbes);

            wREISCH.Start();
            REISCH(randArrayKeys, reischArrayRecord, reischArrayLink, reischArrayProbes, 0);
            wREISCH.Stop();
            fillNegative(reischArrayProbes);
            probHesabı(randArrayKeys, reischArrayRecord, reischArrayLink, reischArrayProbes);

            wBLISCH.Start();
            BLISCH(randArrayKeys, blischArrayRecord, blischArrayLink, blischArrayProbes, 0);
            wBLISCH.Stop();
            fillNegative(blischArrayProbes);
            probHesabı(randArrayKeys, blischArrayRecord, blischArrayLink, blischArrayProbes);

            dataGridViewEISCH.Rows.Clear();
            dataGridViewBLISCH.Rows.Clear();
            dataGridViewLICH.Rows.Clear();
            dataGridViewREISCH.Rows.Clear();
            for (int i = 0; i < eischArrayRecord.Length; i++)
            {
                if (eischArrayRecord[i] >= 0 && eischArrayLink[i] >= 0  ){dataGridViewEISCH.Rows.Add(new object[] { i , eischArrayRecord[i], eischArrayLink[i], eischArrayProbes[i]});}
                else if(eischArrayRecord[i]>=0 && eischArrayLink[i]<0){ dataGridViewEISCH.Rows.Add(new object[] { i , eischArrayRecord[i] ,"",eischArrayProbes[i]}); }
                else if(eischArrayRecord[i]<0 && eischArrayLink[i] <0) { dataGridViewEISCH.Rows.Add(new object[] { i  }); }

                if (lichArrayRecord[i] >= 0 && lichArrayLink[i] >= 0) { dataGridViewLICH.Rows.Add(new object[] { i , lichArrayRecord[i], lichArrayLink[i], lichArrayProbes[i] }); }
                else if (lichArrayRecord[i] >= 0 && lichArrayLink[i] < 0) { dataGridViewLICH.Rows.Add(new object[] { i , lichArrayRecord[i],"", lichArrayProbes[i] }); }
                else if (lichArrayRecord[i] < 0 && lichArrayLink[i] < 0) { dataGridViewLICH.Rows.Add(new object[] { i  }); }

                if (blischArrayRecord[i] >= 0 && blischArrayLink[i] >= 0) { dataGridViewBLISCH.Rows.Add(new object[] { i , blischArrayRecord[i], blischArrayLink[i], blischArrayProbes[i] }); }
                else if (blischArrayRecord[i] >= 0 && blischArrayLink[i] < 0) { dataGridViewBLISCH.Rows.Add(new object[] { i , blischArrayRecord[i], "", blischArrayProbes[i] }); }
                else if (blischArrayRecord[i] < 0 && blischArrayLink[i] < 0) { dataGridViewBLISCH.Rows.Add(new object[] { i }); }

                if (reischArrayRecord[i] >= 0 && reischArrayLink[i] >= 0) { dataGridViewREISCH.Rows.Add(new object[] { i , reischArrayRecord[i], reischArrayLink[i], reischArrayProbes[i] }); }
                else if (reischArrayRecord[i] >= 0 && reischArrayLink[i] < 0) { dataGridViewREISCH.Rows.Add(new object[] { i , reischArrayRecord[i], "", reischArrayProbes[i] }); }
                else if (reischArrayRecord[i] < 0 && reischArrayLink[i] < 0) { dataGridViewREISCH.Rows.Add(new object[] { i  }); }
            }
            double toplamL = 0, toplamE = 0, toplamB = 0, toplamR = 0;
            for (int i = 0; i < lichArrayRecord.Length; i++)
            {
                if (lichArrayProbes[i] != -1) { toplamL += lichArrayProbes[i]; }
                if (eischArrayProbes[i] != -1) { toplamE += eischArrayProbes[i]; }
                if (blischArrayProbes[i] != -1) { toplamB += blischArrayProbes[i]; }
                if (reischArrayProbes[i] != -1) { toplamR += reischArrayProbes[i]; }
            }

            labelAvrLICH.Text = (toplamL/ randArrayKeys.Length).ToString(); ;
            labelAvrEISCH.Text = (toplamE / randArrayKeys.Length).ToString();
            labelAvrBLISCH.Text = (toplamB / randArrayKeys.Length).ToString();
            labelAvrREISCH.Text = (toplamR / randArrayKeys.Length).ToString();

            labelPerfLICH.Text = Convert.ToString(wLICH.ElapsedTicks);
            labelPerfEISCH.Text = Convert.ToString(wEISCH.ElapsedTicks);
            labelPerfBLISCH.Text = Convert.ToString(wBLISCH.ElapsedTicks);
            labelPerfREISCH.Text = Convert.ToString(wREISCH.ElapsedTicks);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int y=0;
            int x;
            try
            {   
                x=Convert.ToInt32(textBoxSearch.Text);
                for (int i = 0; i < randArrayKeys.Length; i++)
                {
                    if (x == randArrayKeys[i])
                    {
                        y = 1;
                        break;
                    }
                }
                if (y == 0)
                {
                    MessageBox.Show("The value you entered is not in the random array.");
                }
                else if (y == 1)
                {
                    int indis=search(lichArrayRecord,lichArrayLink, x, modAlLICH(x));
                    textBox3.Text = indis + ".  index";
                    textBox1.Text = lichArrayProbes[indis]+" adım";
                }
            }
            catch
            {
                MessageBox.Show("Please enter an Integer value in the Keys array.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x;
            try
            {
                x = Convert.ToInt32(textBoxSearch.Text);
                for (int i = 0; i < randArrayKeys.Length; i++)
                {
                    if (x == randArrayKeys[i])
                    {
                        y = 1;
                        break;
                    }
                }
                if (y == 0)
                {
                    MessageBox.Show("The value you entered is not in the random array.");
                }
                else if (y == 1)
                {
                    int indis = search(eischArrayRecord, eischArrayLink, x, modAl(x));
                    textBox3.Text = indis + ".  index";
                    textBox1.Text = eischArrayProbes[indis] + " adım";
                }
            }
            catch
            {
                MessageBox.Show("Please enter an Integer value in the Keys array.");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x;
            try
            {
                x = Convert.ToInt32(textBoxSearch.Text);
                for (int i = 0; i < randArrayKeys.Length; i++)
                {
                    if (x == randArrayKeys[i])
                    {
                        y = 1;
                        break;
                    }
                }
                if (y == 0)
                {
                    MessageBox.Show("The value you entered is not in the random array.");
                }
                else if (y == 1)
                {
                    int indis = search(blischArrayRecord, blischArrayLink, x, modAl(x));
                    textBox3.Text = indis + ".  index";
                    textBox1.Text = blischArrayProbes[indis] + " adım";
                }
            }
            catch
            {
                MessageBox.Show("Please enter an Integer value in the Keys array.");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x;
            try
            {
                x = Convert.ToInt32(textBoxSearch.Text);
                for (int i = 0; i < randArrayKeys.Length; i++)
                {
                    if (x == randArrayKeys[i])
                    {
                        y = 1;
                        break;
                    }
                }
                if (y == 0)
                {
                    MessageBox.Show("The value you entered is not in the random array.");
                }
                else if (y == 1)
                {
                    int indis = search(reischArrayRecord, reischArrayLink, x, modAl(x));
                    textBox3.Text = indis + ".  index";
                    textBox1.Text = reischArrayProbes[indis] + " adım";
                }
            }
            catch
            {
                MessageBox.Show("Please enter an Integer value in the Keys array.");
            }
        }
        private void textBoxRandomKeysDiziBoyutu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = Convert.ToInt32(textBoxRandomKeysDiziBoyutu.Text);
                if (a <= 0)
                {
                    MessageBox.Show("Please enter a positive integer.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }

    }
}
