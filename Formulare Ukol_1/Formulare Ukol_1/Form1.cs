using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulare_Ukol_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form form2;

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count <= 10)
            {
                form2 = new Form();
                form2.Size = new Size(300, 150);
                form2.Text = "Zadávání slov";

                TextBox textbox1 = new TextBox();
                textbox1.Location = new Point(10, 20);
                textbox1.Size = new Size(120, 20);

                Button ulozit = new Button();
                ulozit.DialogResult = DialogResult.OK;
                ulozit.Size = new Size(60, 20);
                ulozit.Text = "Uložit";
                ulozit.Location = new Point(10, 40);

                Button zrusit = new Button();
                zrusit.DialogResult = DialogResult.Cancel;
                zrusit.Size = new Size(60, 20);
                zrusit.Text = "Zrušit";
                zrusit.Location = new Point(10, 60);

                form2.Controls.Add(textbox1);
                form2.Controls.Add(ulozit);
                form2.Controls.Add(zrusit);

                form2.ShowDialog();

                form2.ActiveControl = textbox1;
                form2.AcceptButton = ulozit;

                if (textbox1.Text != "")
                {
                    listBox1.Items.Add(textbox1.Text);
                } 
            }
            else
            {
                MessageBox.Show("V listboxu již bylo zapsáno 10 slov. Listbox bude vymazán a můžete zadávat dále.");
                listBox1.Items.Clear();
            }
        }
    }
}
