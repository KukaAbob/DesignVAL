using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V122.Storage;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using OpenQA.Selenium.Support.Events;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double usd;
        private double eur;
        private double rub;

        protected IWebDriver Driver;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
            var edgeDriverPath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedgedriver.exe";

            /*открывается edge веб браузер*/
            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--headless"); /*headless типо убирает экран браузера*/

            Driver = new EdgeDriver(edgeDriverPath, edgeOptions);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelglobal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void curs_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;

            panel6.Visible = true;

            textBoxFir.Visible = true;


            textBoxSec.Visible = true;

            comboBox1.Visible = true;

            textBoxRub.Visible = true;

            // Показать textBoxEuro
            textBoxEuro.Visible = true;

            // Показать textBoxDollar
            textBoxDollar.Visible = true;

            comboBox2.Visible = false;

            textBoxtelekom.Visible = false;
            textBoxtelekom2.Visible = false;
            textBoxtelekom3.Visible = false;
            textBoxkaspi1.Visible = false;
            textBoxkaspi2.Visible = false;
            textBoxkaspi3.Visible = false;

            if (Driver != null)
            {
                Driver.Quit();
            }
            var edgeDriverPath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedgedriver.exe";

            /*открывается edge веб браузер*/
            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--headless"); /*headless типо убирает экран браузера*/

            Driver = new EdgeDriver(edgeDriverPath, edgeOptions);

            Driver.Navigate().GoToUrl("https://pomenyay.kz/?ref=xranks");

            HideEdgeBrowserWindow();
            IWebElement dollar = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/form/div/table/tbody/tr[1]/td[3]/div"));
            IWebElement euro = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/form/div/table/tbody/tr[1]/td[5]/div"));
            IWebElement veznoDerevanny = Driver.FindElement(By.XPath("/html/body/div[2]/div[1]/form/div/table/tbody/tr[1]/td[7]/div"));
            textBoxDollar.Text = dollar.Text;
            textBoxEuro.Text = euro.Text;
            textBoxRub.Text = veznoDerevanny.Text;

            double usd = Convert.ToDouble(dollar.Text);
            double eur = Convert.ToDouble(euro.Text);
            double rub = Convert.ToDouble(veznoDerevanny.Text);



        }



        private void reset_Click(object sender, EventArgs e)
        {

        }

        public double aboba1;
        private void docks_Click(object sender, EventArgs e)
        {

            if (Driver != null)
            {
                Driver.Quit();
            }

            comboBox2.Visible = true;

            panel6.Visible = false;

            textBoxFir.Visible = false;


            textBoxSec.Visible = false;

            comboBox1.Visible = false;

            textBoxRub.Visible = false;

            // Показать textBoxEuro
            textBoxEuro.Visible = false;

            // Показать textBoxDollar
            textBoxDollar.Visible = false;

            flowLayoutPanelCost.Visible = true;

            textBox1.Visible = true;

            textBox2.Visible = true;

            textBox3.Visible = true;

            textBoxtelekom.Visible = true;
            textBoxtelekom2.Visible = true;
            textBoxtelekom3.Visible = true;
            textBoxkaspi1.Visible = true;
            textBoxkaspi2.Visible = true;
            textBoxkaspi3.Visible = true;


            if (Driver != null)
            {
                Driver.Quit();
            }
            var edgeDriverPath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedgedriver.exe";

            /*открывается edge веб браузер*/
            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArgument("--headless"); /*headless типо убирает экран браузера*/

            Driver = new EdgeDriver(edgeDriverPath, edgeOptions);

            Driver.Navigate().GoToUrl("https://kase.kz/ru/shares/");

            HideEdgeBrowserWindow();



            /*Попробуй другой сайт тк этот требует куки которые блокуются*/
            /*if (comboBox2.SelectedIndex == 0)
            {
                *//*IWebElement aboba = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td:nth-child(3)"));
                IWebElement abob = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td:nth-child(4) > span"));
                IWebElement abobus = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td.sorting_1 > span"));

                textBox1.Text = aboba.Text;
                textBox2.Text = abob.Text;
                textBox3.Text = abobus.Text;*//*

            }
            *//*else if (comboBox2.SelectedIndex == 1) {

                IWebElement hahaha = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(5) > td:nth-child(3) > span"));
                IWebElement hahaha1 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(5) > td.datatable-v2_cell__IwP1U.datatable-v2_cell--down__sYmZ4.datatable-v2_cell--bold__cXQUV.dynamic-table_col-other__Eu_RC.text-right.font-bold.rtl\\:text-right"));
                IWebElement hahaha2 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(5) > td:nth-child(4)"));

                textBox1.Text = hahaha.Text;
                textBox2.Text = hahaha1.Text;
                textBox3.Text = hahaha2.Text;

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                IWebElement hahahe = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td:nth-child(3) > span"));
                IWebElement hahahe1 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td.datatable-v2_cell__IwP1U.datatable-v2_cell--up__lVyET.datatable-v2_cell--bold__cXQUV.dynamic-table_col-other__Eu_RC.text-right.font-bold.rtl\\:text-right"));
                IWebElement hahahe2 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td:nth-child(4)"));

                textBox1.Text = hahahe.Text;
                textBox2.Text = hahahe1.Text;
                textBox3.Text = hahahe2.Text;
            }
            *//* text2.Text = Straboba;
             textBox1.Text = Jrabob;*//*
            else
            {
                
                comboBox2.Text = "KCELL";
                textBox1.Text = "abob";
            }*/
        }

        private void panelbutton1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDollar_TextChanged(object sender, EventArgs e)
        {

        }

        private void HideEdgeBrowserWindow()
        {
            // Скрываем окно браузера Edge
            foreach (var process in Process.GetProcessesByName("msedgedriver"))
            {
                IntPtr mainWindowHandle = process.MainWindowHandle;
                ShowWindow(mainWindowHandle, SW_HIDE); // SW_HIDE скрывает окно
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFir_TextChanged(object sender, EventArgs e)
        {

            string a = textBoxFir.Text;
            Convert.ToDouble(a);
            if (double.TryParse(a, out double b))
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    double c = b * usd;
                    textBoxSec.Text = c.ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double d = b * eur;
                    textBoxSec.Text = d.ToString();
                }
                else
                {
                    double o = b * rub;
                    textBoxSec.Text = o.ToString();
                }
            }
        }

        public void textBoxSec_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelMakc_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanelDoxod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelCost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            IWebElement aboba = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td:nth-child(3)"));
            IWebElement abob = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td:nth-child(4) > span"));
            IWebElement abobus = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td.sorting_1 > span"));


            textBox1.Text = aboba.Text;
            textBox2.Text = abob.Text;
            textBox3.Text = abobus.Text;



            IWebElement hahaha = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(5) > td:nth-child(3) > span"));
            IWebElement hahaha1 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(5) > td.datatable-v2_cell__IwP1U.datatable-v2_cell--down__sYmZ4.datatable-v2_cell--bold__cXQUV.dynamic-table_col-other__Eu_RC.text-right.font-bold.rtl\\:text-right"));
            IWebElement hahaha2 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(5) > td:nth-child(4)"));

            textBox1.Text = hahaha.Text;
            textBox2.Text = hahaha1.Text;
            textBox3.Text = hahaha2.Text;


            IWebElement hahahe = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td:nth-child(3) > span"));
            IWebElement hahahe1 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td.datatable-v2_cell__IwP1U.datatable-v2_cell--up__lVyET.datatable-v2_cell--bold__cXQUV.dynamic-table_col-other__Eu_RC.text-right.font-bold.rtl\\:text-right"));
            IWebElement hahahe2 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td:nth-child(4)"));

            textBox1.Text = hahahe.Text;
            textBox2.Text = hahahe1.Text;
            textBox3.Text = hahahe2.Text;


            comboBox2.Text = "KCELL";
            textBox1.Text = "abob";

        }

        private void panelkaspi1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelkaspi2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelkaspi3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxkaspi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxkaspi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxkaspi3_TextChanged(object sender, EventArgs e)
        {

        }

        private void paneltelekom2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltelekom3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxtelekom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtelekom2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtelekom3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtelekom3_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }
    }
}
