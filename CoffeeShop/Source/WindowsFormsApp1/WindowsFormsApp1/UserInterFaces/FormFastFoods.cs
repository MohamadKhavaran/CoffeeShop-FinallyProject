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
    public partial class FormFastFoods : Form
    {
        public FormFastFoods()
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
            MessageBox.Show("Cheese, basil, and tomatoes are the main ingredients of Margherita pizza, which is not dissimilar to the colors of the Italian flag." +
                " Margherita pizza may be served all over the world with a slightly different recipe, but the Italian version definitely has more to say." +
                " If you have never tasted the delicious taste of margarita, we recommend that you make this delicious experience in Italy.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("When you think of Hawaii, one of the first things that comes to mind is colorful and unique fruits and delicious fruit cocktails, but don't forget Hawaiian pizza." +
                " As it is clear from the name of this type of pizza, tropical fruits such as pineapple are used to cook it.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labellatte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The recipe for this pizza, which belongs to Japan, " +
                "includes mayonnaise, pork, paprika, tomato sauce, corn and onion." +
                " Don't imagine eating Mayo Jaga with Japanese wooden spoons and forget about Japanese eating culture for a moment. " +
                "This culture can be overlooked while enjoying" +
                " the delicious Mayujaga.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Longos pizza is a soft and fairly thick bread toasted in oil and topped with sour cream, garlic, butter and pizza cheese. Of course," +
                " the recipe for the ingredients on the bread is different and it is prepared with two flavors, salty or sweet," +
                " but the most popular type is langos served with sour cream, garlic and butter.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("This popular and delicious pizza is served in rectangular slices and its predominant flavor is pepperoni and cheese." +
                " The main difference between Detroit pizza and Chicago or New York pizza is the thickness of the toasted dough layer.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void labelAffogato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The lovely name of mozzarella leaves no doubt about the deliciousness of Neapolitan pizza;" +
                " Especially if it is accompanied by fresh garlic and basil." +
                " This pizza was prepared and served for the first time in the city of the same name, Naples." +
                " Its relatively thick dough is cooked for 20 to 60 seconds on a stone stove and oak fire. " +
                "We all have the idea of ​​a thin and delicate dough for Italian pizzas; But Naples confuses us.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("The ingredients of the Swiss vegetable burger are barley, " +
                "lentils and mushrooms, which are served with delicious cheese slices and fried mushrooms.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            MessageBox.Show("The Royal Burger is cooked and served from a combination of minced meat with tail, eggs, onions, garlic, breadcrumbs," +
                " garlic powder, shallot powder, salt, pepper, cheddar cheese," +
                " mushrooms and chicken ham.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_Click(object sender, EventArgs e)
        {
            // Margherita Pizza : 15$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(53))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Margherita Pizza", 15);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ChEspresso_Click(object sender, EventArgs e)
        {
            // Hawaiian Pizza : 15$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(54))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Hawaiian Pizza", 15);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChLatte_Click(object sender, EventArgs e)
        {
            // Mayo Jaga Pizza : 15$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(55))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Mayo Jaga Pizza", 15);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChCappuccino_Click(object sender, EventArgs e)
        {
            //Longos Pizza : 15$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(56))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Longos Pizza", 15);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChAmericano_Click(object sender, EventArgs e)
        {
            // Detroit Pizza : 15$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(57))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Detroit Pizza", 15);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChAffogato_Click(object sender, EventArgs e)
        {
            // Neapolitan Pizza : 15$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(58))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Neapolitan Pizza", 15);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChIceCoffee_Click(object sender, EventArgs e)
        {
            // Swiss Veggie Burger  : 11$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(59))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Swiss Veggie Burger", 11);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChRedEye_Click(object sender, EventArgs e)
        {
            // Royal Burger : 14$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(62))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Royal Burger", 14);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void shopingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchases_Show form = new FormPurchases_Show("FastFoods");
            form.ShowDialog();
            this.Close();
        }
        // MessageBox.Show("","Description", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void labelAppleJuice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turkish burger, which is one of the famous hamburgers in Turkey, is prepared from minced meat," +
                " breadcrumbs, chopped chives, grated onion, mayonnaise, tomato sauce, chopped basil, salt and pepper.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChAppleJuice_Click(object sender, EventArgs e)
        {
            // Turkish Burger : 8$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(60))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Turkish Burger", 8);
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
            // Beef Burger : 10$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(61))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Beef Burger", 10);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void labelChocolateMilk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the preparation of veal hamburgers, they use veal, hamburger bun, milk, onion, garlic, aromatic vegetables, and salt and pepper.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void OrangeCakelabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orange cake is a cake with a unique taste of " +
                "orange with pieces of almonds and rose water.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void ChHazelnutCookies_Click(object sender, EventArgs e)
        {
            // French Fries : 6$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(63))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("French Fries", 6);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void HazelnutCookieslabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pack Of 400 Grams", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Fried Mushrooms And Cheese : 6$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(64))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Fried Mushrooms And Cheese", 6);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void WalnutCookielabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fried Mushrooms And Cheese !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChWalnutCookie_MouseEnter(object sender, EventArgs e)
        {
            ChWalnutCookie.ForeColor = Color.GreenYellow;
        }

        private void ChWalnutCookie_MouseLeave(object sender, EventArgs e)
        {
            ChWalnutCookie.ForeColor = Color.White;
        }

        private void CoconutCookielabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fried Chicken !", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Fried Chicken : 8$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(65))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Fried Chicken", 8);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
