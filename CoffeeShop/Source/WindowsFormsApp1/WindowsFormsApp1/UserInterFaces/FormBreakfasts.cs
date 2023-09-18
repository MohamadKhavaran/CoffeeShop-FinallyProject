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
    public partial class FormBreakfasts : Form
    {
        public FormBreakfasts()
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
            MessageBox.Show("Iranian breakfast includes Sangak bread, strawberry jam, carrot jam, butter and saffron tea.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("French breakfast consists of plain croissant bread with chopped almonds, butter, honey and chocolate.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labellatte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("English breakfast includes beans, sausage, bacon, eggs, mushrooms, toast and a cup of lemon tea.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Raspberry Jelly !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Blueberry Jelly !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void labelAffogato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orange Jelly !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Apple pie or apple tart is one of the types of fruit pies whose main ingredient is apple." +
                " In some of its types, whipped cream or ice cream may be placed on it. The dough of this pastry usually consists of two parts, the lower part is one piece and the upper part has narrow strips."
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
            MessageBox.Show("Banana Jelly !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_Click(object sender, EventArgs e)
        {
            // Iranian Breakfast : 12$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(34))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Iranian Breakfast", 12);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ChEspresso_Click(object sender, EventArgs e)
        {
            // French Breakfast : 12$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(35))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("French Breakfast", 12);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChLatte_Click(object sender, EventArgs e)
        {
            // English Breakfast : 12$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(36))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("English Breakfast", 12);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChCappuccino_Click(object sender, EventArgs e)
        {
            // Raspberry Jelly: 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(22))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Raspberry Jelly", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChAmericano_Click(object sender, EventArgs e)
        {
            // Blueberry Jelly : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(23))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Blueberry Jelly", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChAffogato_Click(object sender, EventArgs e)
        {
            // Orange Jelly : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(24))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Orange Jelly", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChIceCoffee_Click(object sender, EventArgs e)
        {
            // Apple Pie : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(26))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Apple Pie", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChRedEye_Click(object sender, EventArgs e)
        {
            // Banana Jelly : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(25))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Banana Jelly", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void shopingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchases_Show form = new FormPurchases_Show("Breakfasts");
            form.ShowDialog();
            this.Close();
        }
        // MessageBox.Show("","Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void labelAppleJuice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caramel cream cake is one of the most delicious and fragrant types of cakes that is very popular. " +
                "This cake is super easy and delicious.At the stage when the sugar turns orange-brown and has a stretchy texture, it is called caramel." +
                " At this stage, the sugar temperature reaches about 170 degrees Celsius. Caramel sauce is obtained from the combination of heated sugar with cream and butter and is used" +
                " as a topping or filling for all kinds of cakes and desserts.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChAppleJuice_Click(object sender, EventArgs e)
        {
            // Caramel Cake : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(27))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Caramel Cake", 2);
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
            // Carrot Cake : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(28))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Carrot Cake", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void labelChocolateMilk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carrot cake is a cake that contains carrots mixed with butter. Carrot usually softens" +
                " during cooking, and the cake has a soft and dense texture.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("It is a kind of cake flavored with melted" +
                " chocolate and cocoa powder. A piece of a chocolate cake sprinkled with cocoa powder is served on a white plate decorated with chocolate sauce. " +
"be made", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBananaMilk_Click(object sender, EventArgs e)
        {
            // Chocolate Cake : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(29))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Chocolate Cake", 3);
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

        private void ChOrangeCake_Click(object sender, EventArgs e)
        {
            // Orange Cake : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(30))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Orange Cake", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChOrangeCake_MouseEnter(object sender, EventArgs e)
        {
            ChOrangeCake.ForeColor = Color.GreenYellow;
        }

        private void ChOrangeCake_MouseLeave(object sender, EventArgs e)
        {
            ChOrangeCake.ForeColor = Color.White;
        }

        private void ChHazelnutCookies_Click(object sender, EventArgs e)
        {
            // Hazelnut Cookies : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(31))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Hazelnut Cookies", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void HazelnutCookieslabel_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Pack Of 3", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChHazelnutCookies_MouseEnter(object sender, EventArgs e)
        {
            ChHazelnutCookies.ForeColor = Color.GreenYellow;    
        }

        private void ChHazelnutCookies_MouseLeave(object sender, EventArgs e)
        {
            ChHazelnutCookies.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Walnut Cookie : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(32))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Walnut Cookie", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void WalnutCookielabel_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Pack Of 3","Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChWalnutCookie_MouseEnter(object sender, EventArgs e)
        {
            ChWalnutCookie.ForeColor = Color.GreenYellow;   
        }

        private void ChWalnutCookie_MouseLeave(object sender, EventArgs e)
        {
            ChWalnutCookie.ForeColor = Color.White;
        }

        private void CoconutCookieslabel_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Pack Of 3","Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CoconutCookielabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pack Of 3", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChCoconutCookie_MouseEnter(object sender, EventArgs e)
        {
            ChCoconutCookie.ForeColor = Color.GreenYellow;
        }

        private void ChCoconutCookie_MouseLeave(object sender, EventArgs e)
        {
            ChCoconutCookie.ForeColor = Color.White;
        }

        private void ChCoconutCookie_Click(object sender, EventArgs e)
        {
            // Coconut Cookie : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(33))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Coconut Cookie", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
