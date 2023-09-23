using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LogicLayers;
namespace WindowsFormsApp1.UserInterFaces
{
    public partial class FormAppetizers : Form
    {
        public FormAppetizers()
        {
            InitializeComponent();
            LLPurchase llPurchase = new LLPurchase();
            CountShopping.Text = llPurchase.CountPurchases();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back.ForeColor = Color.Yellow;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back.ForeColor = Color.White;
        }

        private void LabelBlackCoffee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caesar salad is a salad consisting of romaine lettuce, crumbled pieces" +
                " of toast with parmesan cheese, lime juice, olive oil, eggs, Worcestershire sauce, garlic and black pepper.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_MouseEnter(object sender, EventArgs e)
        {
            ChStrawberryJelly.ForeColor = Color.GreenYellow;
        }

        private void ChBlackCoffee_MouseLeave(object sender, EventArgs e)
        {
            ChStrawberryJelly.ForeColor = Color.White;
        }

        private void ChEspresso_MouseEnter(object sender, EventArgs e)
        {
            ChEspresso.ForeColor = Color.GreenYellow;
        }

        private void ChEspresso_MouseLeave(object sender, EventArgs e)
        {
            ChEspresso.ForeColor = Color.White;
        }

        private void labelEspresso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caesar Salad is a salad consisting of romaine lettuce, crumbled pieces " +
                "of toast with parmesan cheese, lime juice, olive oil, eggs, Worcestershire sauce, garlic and black pepper.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labellatte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herring Salad is one of the popular and popular Russian salads. Vegetables such as" +
                " beets, potatoes, onions, carrots, mayonnaise and chopped herring are used in layers.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Chlatte_MouseEnter(object sender, EventArgs e)
        {
            ChLatte.ForeColor = Color.GreenYellow;
        }

        private void Chlatte_MouseLeave(object sender, EventArgs e)
        {
            ChLatte.ForeColor = Color.White;
        }

        private void ChCappuccino_MouseEnter(object sender, EventArgs e)
        {
            ChCappuccino.ForeColor = Color.GreenYellow;
        }

        private void ChCappuccino_MouseLeave(object sender, EventArgs e)
        {
            ChCappuccino.ForeColor = Color.White;
        }

        private void labelCappuccino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This salad is traditionally prepared with tomatoes, hard-boiled eggs, olives, anchovies or tuna and served with olive oil. At the beginning of the 20th century, this salad became popular all over the world, and many cooks prepared it and discussed it." +
                " It can be served both as a mixed salad and as a mixed salad.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChAmericano_MouseEnter(object sender, EventArgs e)
        {
            ChAmericano.ForeColor = Color.GreenYellow;
        }

        private void ChAmericano_MouseLeave(object sender, EventArgs e)
        {
            ChAmericano.ForeColor = Color.White;
        }

        private void labelAmericano_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tabbouleh is a Lebanese salad that is traditionally made of bulgur, tomatoes, " +
                "cucumbers and chopped parsley, often accompanied by garlic and onions with olive oil, lemon juice and salt.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChIceCoffee_MouseEnter(object sender, EventArgs e)
        {
            ChIceCoffee.ForeColor = Color.GreenYellow;
        }

        private void ChIceCoffee_MouseLeave(object sender, EventArgs e)
        {
            ChIceCoffee.ForeColor = Color.White;
        }

        private void labelIceCoffee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is a traditional soup in Lithuania called auksta zupa, which looks" +
                " a little strange (it's pink or purple in color), " +
                "but it tastes really good" +
                ".This soup is made from beets, cucumbers," +
                " kefir, milk sausage, eggs, radishes, and fresh vegetables like dill and chives (often topped with sour cream).", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelRedEye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Banana Jelly !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_Click(object sender, EventArgs e)
        {
            // Caesar Salad : 5$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(44))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Caesar Salad", 5);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ChEspresso_Click(object sender, EventArgs e)
        {
            // Rossoli Salad : 5$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(45))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Rossoli Salad ", 5);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChLatte_Click(object sender, EventArgs e)
        {
            // Herring Salad : 5$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(46))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Herring Salad", 5);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChCappuccino_Click(object sender, EventArgs e)
        {
            // Niswaz Salad : 5$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(47))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Niswaz Salad ", 5);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChAmericano_Click(object sender, EventArgs e)
        {
            // Tabbouleh Salad  : 5$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(48))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Tabbouleh Salad ", 5);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChIceCoffee_Click(object sender, EventArgs e)
        {
            // Auksta Zupa : 4$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(49))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Auksta Zupa", 4);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void shopingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchases_Show form = new FormPurchases_Show("Appetizers");
            form.ShowDialog();
            this.Close();
        }
        // MessageBox.Show("","Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void labelAppleJuice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Italian, Fagiolata means a whole bunch of beans for a whole bunch of people,  and when you see the soup, you'll know how apt the name is." +
"Fagiolata is prepared from different types of red beans, white beans, black beans and almost any other kind of beans, " +
"which are slowly cooked with olive oil and a lot of salt and pepper and served with toasted bread.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChAppleJuice_Click(object sender, EventArgs e)
        {
            // Fagiolata  : 4$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(50))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Fagiolata", 4);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChAppleJuice_MouseEnter(object sender, EventArgs e)
        {
            ChAppleJuice.ForeColor = Color.GreenYellow;
        }

        private void ChAppleJuice_MouseLeave(object sender, EventArgs e)
        {
            ChAppleJuice.ForeColor = Color.White;
        }

        private void ChChocolateMilk_Click(object sender, EventArgs e)
        {
            // Penang Laksa : 4$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(51))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Penang Laksa", 4);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void labelChocolateMilk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Penang Laksa is a street food in Malaysia that has spread from the northwest of Penang to the whole country. This noodle soup tastes sweet and sour at the" +
                " same time and is prepared with a spicy fish broth that is usually served with fresh herbs and shrimp paste.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChChocolateMilk_MouseEnter(object sender, EventArgs e)
        {
            ChChocolateMilk.ForeColor = Color.GreenYellow;
        }

        private void ChChocolateMilk_MouseLeave(object sender, EventArgs e)
        {
            ChChocolateMilk.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ciorba de vecuta will be a great feast for your senses. This soup is actually" +
                " a traditional Romanian beef soup that is cooked with sour cream and fresh dill and has a very hearty taste.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBananaMilk_Click(object sender, EventArgs e)
        {
            // Ciorba de Vacuta : 4$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(52))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Ciorba de Vacuta", 4);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChBananaMilk_MouseEnter(object sender, EventArgs e)
        {
            ChBananaMilk.ForeColor = Color.GreenYellow;
        }

        private void ChBananaMilk_MouseLeave(object sender, EventArgs e)
        {
            ChBananaMilk.ForeColor = Color.White;
        }

        private void OrangeCakelabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orange cake is a cake with a unique taste of " +
                "orange with pieces of almonds and rose water.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
