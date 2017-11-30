using DataConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DomainModel;
using MovingAverageCalc;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        private List<CurrencyRate> currencyList;
        private List<TypeRate> typeRateList;
        
        int count;
        double parametrEMA;

        public Form1()
        {
            InitializeComponent();
            currencyList = new List<CurrencyRate>();
            typeRateList = new List<TypeRate>()
            {
                new TypeRate()
                {
                    Id = 1, Name = "Close"
                },
                new TypeRate()
                {
                    Id = 2, Name = "Open"
                },
                new TypeRate()
                {
                    Id = 3, Name = "High"
                },
                new TypeRate()
                {
                    Id = 4, Name = "Low"
                }
            };

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeRateComboBox.DataSource = typeRateList;
            typeRateComboBox.DisplayMember = "Name";
            typeRateComboBox.ValueMember = "Id";

            chart1.Series.Add(new Series() { Name = "SMA", BorderWidth = 2, ChartType = SeriesChartType.Spline });
            chart1.Series.Add(new Series() { Name = "EMA", BorderWidth = 2, ChartType = SeriesChartType.Spline });
            chart1.Series.Add(new Series() { Name = "Курс USD/RUB", BorderWidth = 2, ChartType = SeriesChartType.FastLine });

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            fileDialog.Filter = "CSV file(*.csv)|*.csv|All files(*.*)|*.*"; //формат загружаемого файла
            fileDialog.InitialDirectory = @"D:\Новая папка\Учеба\4 курс\Проектирование ИС и ИТ\Лаба 6\Laba6";
            if (fileDialog.ShowDialog() == DialogResult.OK && fileDialog.FileName != null)
                //если в окне была нжата кнопка "ОК"
            {
                string path = fileDialog.FileName;
                var conversion = new ConversionFromCSV(path);
                currencyList = conversion.ToObject();
            }
            else
            {
                MessageBox.Show("Выберите файл");
            }

        }

        private void BuildChartButton_Click(object sender, EventArgs e)
        {
            if (currencyList != null && currencyList.Count !=0)
            {
                if (periodTextBox.Text != "")
                {
                    count = Int32.Parse(periodTextBox.Text);
                }
                else
                {
                    count = 20;
                }

                if (parametrEmaTextBox.Text != "")
                {
                    parametrEMA = Double.Parse(parametrEmaTextBox.Text, new CultureInfo("en-US"));
                }
                else
                {
                    parametrEMA = 0.5;
                }

                TypeRate typeRate = typeRateComboBox.SelectedItem as TypeRate;

                MovingAverageCalculate calc = new MovingAverageCalculate();
                calc.Calculate(currencyList, count, parametrEMA, typeRate);

                //count = period;
                #region    calc       
                //List<DateTime> date = new List<DateTime>();

                //for (int i = 0; i < count; i++)
                //{
                //    date.Add(currencyList[i].Date);
                //}

                //double[] sma = new double[count];
                //double[] ema = new double[count];

                //List<double> currencyRate = new List<double>();
                //double sum = 0;

                //switch (typeRate.Name)
                //{
                //    case "Close":
                //        currencyRate.AddRange(currencyList.Select(item => item.Close));

                //        for (int i = 0; i < count; i++)
                //        {
                //            sum += currencyRate[i];
                //            sma[i] = sum / (i + 1);
                //        }
                //        ema[0] = sma[0];
                //        for (int i = 1; i < count; i++)
                //        {
                //            //                        EMA = (CLOSE(i) * P) + (EMA(i - 1) * (1 - P))
                //            //                        где:
                //            //                        CLOSE(i) — цена закрытия текущего периода;
                //            //                        EMA(i - 1) — значение скользящего среднего предыдущего периода;
                //            //                        P — доля использования значения цен.
                //            ema[i] = currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA));
                //        }
                //        break;
                //    case "Open":
                //        currencyRate.AddRange(currencyList.Select(item => item.Open));
                //        //double sum = 0;
                //        for (int i = 0; i < count; i++)
                //        {
                //            sum += currencyRate[i];
                //            sma[i] = sum / (i + 1);
                //        }
                //        ema[0] = sma[0];
                //        for (int i = 1; i < count; i++)
                //        {
                //            ema[i] = currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA));
                //        }

                //        break;
                //    case "High":
                //        currencyRate.AddRange(currencyList.Select(item => item.High));
                //        for (int i = 0; i < count; i++)
                //        {
                //            sum += currencyRate[i];
                //            sma[i] = sum / (i + 1);
                //        }
                //        ema[0] = sma[0];
                //        for (int i = 1; i < count; i++)
                //        {
                //            ema[i] = currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA));
                //        }

                //        break;
                //    default:
                //        currencyRate.AddRange(currencyList.Select(item => item.Low));
                //        for (int i = 0; i < count; i++)
                //        {
                //            sum += currencyRate[i];
                //            sma[i] = sum / (i + 1);
                //        }
                //        ema[0] = sma[0];
                //        for (int i = 1; i < count; i++)
                //        {
                //            ema[i] = currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA));
                //        }

                //        break;
                //}
                //List<double> rate = new List<double>();
                //for (int i = 0; i < count; i++)
                //{
                //    rate.Add(currencyRate[i]);
                //}
                #endregion

                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;

                //chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine());
                //chart1.ChartAreas[0].AxisY.StripLines[0].BackColor = Color.FromArgb(80, 252, 180, 65);
                //chart1.ChartAreas[0].AxisY.StripLines[0].StripWidth = 4;
                //chart1.ChartAreas[0].AxisY.StripLines[0].Interval = 10;
                //chart1.ChartAreas[0].AxisY.StripLines[0].IntervalOffset = 20;

                chart1.ChartAreas[0].AxisY.Maximum = calc.rate.Max() + 2;
                chart1.ChartAreas[0].AxisY.Minimum = calc.rate.Min() - 2;


                chart1.Series[0].XValueType = ChartValueType.Date;
                chart1.Series[0].Points.DataBindXY(calc.date, calc.sma);


                chart1.Series[1].XValueType = ChartValueType.Date;
                chart1.Series[1].Points.DataBindXY(calc.date, calc.ema);


                chart1.Series[2].XValueType = ChartValueType.Date;
                chart1.Series[2].Points.DataBindXY(calc.date, calc.rate);

                calc.Dispose();
                //chart1.ChartAreas[0].AxisY.Maximum = rate.Max() + 2;
                //chart1.ChartAreas[0].AxisY.Minimum = rate.Min() - 2;

                //chart1.Series[0].XValueType = ChartValueType.Date;
                //chart1.Series[0].Points.DataBindXY(date, sma);

                //chart1.Series[1].XValueType = ChartValueType.Date;
                //chart1.Series[1].Points.DataBindXY(date, ema);

                //chart1.Series[2].XValueType = ChartValueType.Date;
                //chart1.Series[2].Points.DataBindXY(date, rate);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (chart1.Series.Count!=0)
            {
                int[] sma0 = new int[count];
                //chart1.Series[0].XValueType = ChartValueType.Date;
                chart1.Series[0].Points.DataBindXY(sma0, sma0);
                //chart1.Series[1].XValueType = ChartValueType.Date;
                chart1.Series[1].Points.DataBindXY(sma0, sma0);
                //chart1.Series[2].XValueType = ChartValueType.Date;
                chart1.Series[2].Points.DataBindXY(sma0, sma0);

            }
            
        }
    }
}
