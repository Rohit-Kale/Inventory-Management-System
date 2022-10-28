using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSales
{
    public partial class Alert : Form
    {
        private Random random;
        private int tempIndex;
        MainForm main;
        public Alert(MainForm mn)
        {
            InitializeComponent();
            random = new Random();
            Color color = SelectThemeColor();
            panel1.BackColor = color;
            main = mn;                        
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }
        private Alert.enmAction action;
        private int x, y;

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            StockIn stock = new StockIn(main);
            main.openChildForm(stock);
            ProductStockIn stockIn = new ProductStockIn(stock);
            stock.ProductForSupplier(lblPcode.Text);
            stockIn.addStockIn(lblPcode.Text);
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex==index)
            {
                //if the color has already been selected, we select again to choose a different one.
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
    }
}
