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
using System.Globalization;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Wpf;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;


namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        /*обязательно обьявляем как отдельный метод чтобы можно было обращаться из других методов */
        public double usd;
        private double eur;
        private double rub;

        public void AY52CANKPETERBYRG()
        {

        }

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

        private async void curs_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            textBox1.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;



            comboBox1.Visible = true;

            textBoxRub.Visible = true;

            textBoxEuro.Visible = true;

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
            /*культуринфо типо стандартизирует твои настройки на пк и поэтому у тебя щас все работает :)*/
            usd = Convert.ToDouble(dollar.Text, CultureInfo.InvariantCulture);
            eur = Convert.ToDouble(euro.Text, CultureInfo.InvariantCulture);
            rub = Convert.ToDouble(veznoDerevanny.Text, CultureInfo.InvariantCulture);



            /*пропиши визибл это гениально бро просто ты не тут прописываешь*/


            /*    var data = new List<DataPoint>
            {
            new DataPoint(2016, dollar2016),
            new DataPoint(2017, dollar2017),
            new DataPoint(2018, dollar2018),
            new DataPoint(2019, dollar2019),
            new DataPoint(2020, dollar2020),
            new DataPoint(2021, dollar2021),
            new DataPoint(2022, dollar2022),
            new DataPoint(2023, dollar2023),
            new DataPoint(2024, usd),

            };*/
        }







        /*тут мы создаем обьект plotview чтобы в будущем к нему обращаться
         дальше идет впринципе шаблон и берется данные из массива data который мы указали выше 
        и выводим точки
         */
        private OxyPlot.WindowsForms.PlotView plotView;
        private void PlotGraph(List<DataPoint> data)
        {
            var plotModel = new PlotModel { Title = "График данных" };

            var series = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColors.Blue,
                Color = OxyColors.Red,
                StrokeThickness = 2
            };

            series.Points.AddRange(data);

            plotModel.Series.Add(series);

            plotView = new OxyPlot.WindowsForms.PlotView();
            plotView.Model = plotModel;

            panel6.Controls.Clear();
            panel6.Controls.Add(plotView);
            plotView.Dock = DockStyle.Fill;
        }

        public double abob
        {
            set { Convert.ToString(usd); }
        }



        private void reset_Click(object sender, EventArgs e)
        {

        }

        public double aboba1;
        private async void docks_Click(object sender, EventArgs e)
        {

            if (Driver != null)
            {
                Driver.Quit();
            }

            comboBox2.Visible = true;

            panel6.Visible = false;

            comboBox1.Visible = false;

            textBoxRub.Visible = false;

            textBoxEuro.Visible = false;

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

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));


            /*Попробуй другой сайт тк этот требует куки которые блокуются*/
            /*возможно нужно создать еще переменные как посредник между парсером и тексбоксом*/
            IWebElement aboba = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td:nth-child(3)"));
            IWebElement abob = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td:nth-child(4) > span"));
            IWebElement abobus = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(3) > td.sorting_1 > span"));
            string kakdela = aboba.Text;
            string danormvrode = abob.Text;
            string atikak = abobus.Text;
            textBox1.Text = kakdela;
            textBox2.Text = danormvrode;
            textBox3.Text = atikak;
            Console.WriteLine("textBox1.Text: " + textBox1.Text);
            Console.WriteLine("textBox2.Text: " + textBox2.Text);
            Console.WriteLine("textBox3.Text: " + textBox3.Text);




            /*                IWebElement hahaha = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(7) > td:nth-child(3)"));
                            IWebElement hahaha1 = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(7) > td:nth-child(4) > span"));
                            IWebElement hahaha2 = Driver.FindElement(By.CssSelector("#sorting_table_shares_top > tbody > tr:nth-child(7) > td.sorting_1 > span"));

                            textBox1.Text = hahaha.Text;
                            textBox2.Text = hahaha1.Text;
                            textBox3.Text = hahaha2.Text;*/


            /*                IWebElement hahahe = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td:nth-child(3) > span"));
                            IWebElement hahahe1 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td.datatable-v2_cell__IwP1U.datatable-v2_cell--up__lVyET.datatable-v2_cell--bold__cXQUV.dynamic-table_col-other__Eu_RC.text-right.font-bold.rtl\\:text-right"));
                            IWebElement hahahe2 = Driver.FindElement(By.CssSelector("#__next > div.desktop\\:relative.desktop\\:bg-background-default > div.relative.flex > div.grid.flex-1.grid-cols-1.px-4.pt-5.font-sans-v2.text-\\[\\#232526\\].antialiased.xl\\:container.sm\\:px-6.md\\:grid-cols-\\[1fr_72px\\].md\\:gap-6.md\\:px-7.md\\:pt-10.md2\\:grid-cols-\\[1fr_420px\\].md2\\:gap-8.md2\\:px-8.xl\\:mx-auto > div.min-w-0 > div:nth-child(4) > div.relative.w-full > div.relative.dynamic-table-v2_dynamic-table-wrapper__fBEvo.dynamic-table-v2_scrollbar-x__R96pe > table > tbody > tr:nth-child(8) > td:nth-child(4)"));

                            textBox1.Text = hahahe.Text;
                            textBox2.Text = hahahe1.Text;
                            textBox3.Text = hahahe2.Text;
                       */
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
            if (comboBox1.SelectedIndex == 0)
            {
                double dollar2023 = 442.64;
                double dollar2022 = 475.88;
                double dollar2021 = 425.01;
                double dollar2020 = 410.96;
                double dollar2019 = 381.18;
                double dollar2018 = 341.19;
                double dollar2017 = 324.04;
                double dollar2016 = 334.12;
                var data = new List<DataPoint>
            {
            new DataPoint(2016, dollar2016),
            new DataPoint(2017, dollar2017),
            new DataPoint(2018, dollar2018),
            new DataPoint(2019, dollar2019),
            new DataPoint(2020, dollar2020),
            new DataPoint(2021, dollar2021),
            new DataPoint(2022, dollar2022),
            new DataPoint(2023, dollar2023),
            new DataPoint(2024, usd),

            };
                PlotGraph(data);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double euro2023 = 495.25;
                double euro2022 = 453.33;
                double euro2021 = 501.47;
                double euro2020 = 468.78;
                double euro2019 = 429.43;
                double euro2018 = 399.31;
                double euro2017 = 373.28;
                double euro2016 = 377.14;

                var data = new List<DataPoint>
                    {
                    new DataPoint(2016, euro2016),
                    new DataPoint(2017, euro2017),
                    new DataPoint(2018, euro2018),
                    new DataPoint(2019, euro2019),
                    new DataPoint(2020, euro2020),
                    new DataPoint(2021, euro2021),
                    new DataPoint(2022, euro2022),
                    new DataPoint(2023, euro2023),
                    new DataPoint(2024, eur),
                    };
                PlotGraph(data);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double rub2023 = 5;
                double rub2022 = 6.5;
                double rub2021 = 5.73;
                double rub2020 = 5.77;
                double rub2019 = 6.04;
                double rub2018 = 5.64;
                double rub2017 = 5.53;
                double rub2016 = 5.13;

                var data = new List<DataPoint>
                    {
                    new DataPoint(2016, rub2016),
                    new DataPoint(2017, rub2017),
                    new DataPoint(2018, rub2018),
                    new DataPoint(2019, rub2019),
                    new DataPoint(2020, rub2020),
                    new DataPoint(2021,rub2021),
                    new DataPoint(2022, rub2022),
                    new DataPoint(2023, rub2023),
                    new DataPoint(2024, rub),
                    };
                PlotGraph(data);
            }
            else if (comboBox1.SelectedIndex == 3) 
            {
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    
             

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string url = "C:\\Users\\Askha\\Downloads";
                        url = dialog.FileName;
                        Console.WriteLine("Выбранный файл: " + url);
                    }
                    else
                    {
                        Console.WriteLine("Выбор файла отменен.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка исключения, например, вывод в консоль сообщения об ошибке
                    Console.WriteLine("Ошибка при открытии файла: " + ex.Message);
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

        private void notifyIcon3_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon8_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void paneltelek_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

       

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        /*private void axWindowsMediaPlayer12_Enter(object sender, EventArgs e)
        {
            
        }*/
    }
}
