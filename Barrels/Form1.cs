using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1 hour
namespace Barrels
{
    public partial class Form1 : Form
    {
        DataTable BarrelTable = new DataTable();
        BarrelLine BarrelList = new BarrelLine();
        public Form1()
        {
            InitializeComponent();
            BarrelTable.Columns.Add("ID", typeof(int));
            BarrelTable.Columns.Add("Diameter", typeof(int));
            BarrelTable.Columns.Add("Height", typeof(int));
            BarrelTable.Columns.Add("Volume", typeof(double));
            BarrelTable.Columns.Add("Diagonal", typeof(double));
            dataGridView1.DataSource = BarrelTable;

        }

        private BarrelLineList SortBarrels(BarrelLine barList)
        {
            List<Barrel> bars = barList.OrderByDescending(b => b.Volume).ToList();
            
            BarrelLineList barsPack = new BarrelLineList();

            while (bars.Count > 0)
            {

                Barrel currbar = null;
                BarrelLine barsLine = new BarrelLine();
                foreach (Barrel bar in bars)
                {
                    if ((currbar == null)//First barrel in line
                        || (bar.Diameter < currbar.Diameter && bar.Height < currbar.Height)//fit vertically
                        || (bar.Diagonal < currbar.Diameter && bar.Diameter < currbar.Height && canRotate.Checked)) //fit horizontally (with rotate) 
                    {
                        currbar = bar;
                        barsLine.Add(currbar);
                    }

                }
                foreach (Barrel bar in barsLine)
                {
                    bars.Remove(bar);
                }
                barsPack.Add(barsLine);
            }
            return barsPack;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog bDialog = new OpenFileDialog();
            bDialog.Title = "Open text file";
            bDialog.Filter = "Text Files|*.txt;";

            if (bDialog.ShowDialog() == DialogResult.OK)
            {
                BarrelList.Clear();
                BarrelTable.Clear();

                string[] File2Lines = System.IO.File.ReadAllLines(bDialog.FileName.ToString());
                foreach (string line in File2Lines)
                {

                    string[] lineData = line.Split(' ');
                    bool isID = Int32.TryParse(lineData[0], out int id);
                    bool isDeameter = Double.TryParse(lineData[1], out Double diameter);
                    bool isHeight = Double.TryParse(lineData[2], out Double height);
                    
                    if (isID && isDeameter && isHeight)
                    { 
                        Barrel bar = new Barrel(id, diameter, height);

                        BarrelList.Add(bar);
                        BarrelTable.Rows.Add(bar.ID, bar.Diameter, bar.Height, Math.Round(bar.Volume, 2), Math.Round(bar.Diagonal, 2));

                    }
                }
            }
        }
        

        private void SortBtn_Click(object sender, EventArgs e)
        {
            BarrelLineList sortedBars = SortBarrels(BarrelList);

            double totalval = 0;
            SortResultBox.Clear();
            foreach (BarrelLine brl in sortedBars)
            {
                totalval += brl[0].Volume;
                foreach (Barrel br in brl)
                {
                    SortResultBox.AppendText(br.ID + " ");
                }
                SortResultBox.AppendText(Environment.NewLine);
                
            }
            TotalVolume.Text = Math.Round(totalval,2).ToString();
        }

    }
}
