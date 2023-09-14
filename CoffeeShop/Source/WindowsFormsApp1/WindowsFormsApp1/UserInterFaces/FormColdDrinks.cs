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
    public partial class FormColdDrinks : Form
    {
        public FormColdDrinks()
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
            MessageBox.Show("Lemonade is one of the famous cold drinks for summer that can be prepared for winter season as well." +
                " You can find different types of lemonade in the menu of coffee shops. But its most famous type is mint lemonade. At the same time, " +
                "for those who are on a slimming diet and want to add fewer calories to their diet, you can use ingredients that make it easier to consume this cool drink.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_MouseEnter(object sender, EventArgs e)
        {
            ChLemonade.ForeColor = Color.GreenYellow;
        }

        private void ChBlackCoffee_MouseLeave(object sender, EventArgs e)
        {
            ChLemonade.ForeColor = Color.White;
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
            MessageBox.Show("The classic Mojito cold drink has Cuban roots and is generally made from a combination of sparkling water, mint leaves," +
                " white rum and lime juice, ingredients with Cuban roots that ultimately give us a mocktail or non-alcoholic drink. But you can make a mojito or coffee shop drink with a variety of fruits, including strawberries, mangoes, apples, and even bananas." +
"One of the cold mojito drinks is that it is a cool and refreshing summer syrup to quench thirst and heatstroke on hot summer days .", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labellatte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Strawberry milk is a useful and delicious spring mixture that can help strengthen your immune system and regulate your blood pressure. " +
                "In the preparation of strawberry milk, used can use sugar and natural sweeteners such as honey.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Mocktail is one of the best non-alcoholic cold drinks that has many fans in Islamic countries. Mocktail is considered an American drink and is made from the combination of various juices and beer." +
                           "Combine lemonade, ice and some orange juice.You have a delicious and cool mocktail that will be the perfect drink to" +
                           " quench your thirst on a hot day.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Malaysian people love the aroma and taste of rose water and make this pink drink from the combination of milk and rose water. Rose juice is used in this drink because of its properties." +
                           "Malaysians serve this drink with ice during Ramadan and religious holidays.Nowadays, they add a little carbonated water in it to make it taste better." +
                           "Rose and rose water give a mild taste to this drink and make you feel relaxed.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void labelAffogato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scoops of vanilla ice cream were poured into a blender with milk and mixed well until the mixture was smooth. " +
                "Pour the drink into a serving glass and decorate it with whipped cream, chopped chocolate and a cherry.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ChAffogato_MouseEnter(object sender, EventArgs e)
        {
            ChAffogato.ForeColor = Color.GreenYellow;
        }

        private void ChAffogato_MouseLeave(object sender, EventArgs e)
        {
            ChAffogato.ForeColor = Color.White;
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
            MessageBox.Show("Fresh orange juice with ice cubes and a few fresh green lemons suitable for hot and summer weather."
                , "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ChRedEye_MouseEnter(object sender, EventArgs e)
        {
            ChRedEye.ForeColor = Color.GreenYellow;
        }
        private void ChRedEye_MouseLeave(object sender, EventArgs e)
        {
            ChRedEye.ForeColor = Color.White;
        }

        private void labelRedEye_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Watermelon milkshake consists of fresh cow's milk and red watermelon and several " +
                 "fruits such as blackberry and blueberry. Sweet, nutritious and fresh for very hot days.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ChBlackCoffee_Click(object sender, EventArgs e)
        {
            // Lemonade : 1$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(8))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Lemonade", 1);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ChEspresso_Click(object sender, EventArgs e)
        {
            // Mojito: 1$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(9))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Mojito", 1);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChLatte_Click(object sender, EventArgs e)
        {
            // Strawberry Milk : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(10))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Strawberry Milk ", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChCappuccino_Click(object sender, EventArgs e)
        {
            // Mocktail: 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(11))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Mocktail", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChAmericano_Click(object sender, EventArgs e)
        {
            // Bandung : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(12))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Bandung", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChAffogato_Click(object sender, EventArgs e)
        {
            // Vanilla Milkshake : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(13))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Vanilla Milkshake", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChIceCoffee_Click(object sender, EventArgs e)
        {
            // Orange Juice : 1$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(14))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Orange Juice", 1);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChRedEye_Click(object sender, EventArgs e)
        {
            // Watermelon Milkshake : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(15))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Watermelon Milkshake", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void shopingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchases_Show form = new FormPurchases_Show("Cold Drinks");
            form.ShowDialog();
            this.Close();
        }
        // MessageBox.Show("","Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void labelAppleJuice_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Fresh apple juice with a combination of yellow, red and green apples. a little sour", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ChAppleJuice_Click(object sender, EventArgs e)
        {
            // Apple Juice : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(16))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Apple Juice", 2);
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
            // Chocolate Milk : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(17))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Chocolate Milk", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void labelChocolateMilk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fresh cow's milk plus fresh and bitter " +
                "Brazilian cocoa with sugar and a little Nutella.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Fresh milk plus delicious and sweet bananas with a few pieces of ice.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBananaMilk_Click(object sender, EventArgs e)
        {
            // Banana Milk : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(18))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Banana Milk", 2);
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
    }
}
