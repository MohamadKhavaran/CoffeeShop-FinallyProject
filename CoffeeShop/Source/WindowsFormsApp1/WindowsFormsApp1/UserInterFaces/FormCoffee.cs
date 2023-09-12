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
    public partial class FormCoffee : Form
    {
        public FormCoffee()
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
            MessageBox.Show("Black coffee is simply coffeewith nothing added – no cream, no milk, no sweetener. " +
                "When you leave out those extra ingredients, you leave out the calories, fat, and sugar that come with them. " +
                "That allows you to enjoy the health benefits of coffee without additives that aren't as good for you", "Description",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_MouseEnter(object sender, EventArgs e)
        {
            ChBlackCoffee.ForeColor = Color.GreenYellow;
        }

        private void ChBlackCoffee_MouseLeave(object sender, EventArgs e)
        {
            ChBlackCoffee.ForeColor = Color.White;
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
            MessageBox.Show("It is a type of thick coffee that was invented in the early 20th century in Turin, Italy." +
                " Espresso is prepared by passing water close to the boiling point with high pressure through the coffee powder." +
                " Espresso is a coffee with a higher " +
                "concentration of dissolved and suspended solids." +
                " Espresso is mostly extracted by an espresso machine.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labellatte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a type of coffee drink that is obtained by combining espresso with steamed milk. " +
                "Latte usually contains more milk than cappuccino and has a smoother and creamier texture." +
                " This drink is served in a tall glass and a shot of espresso is added to the milk and a layer of milk foam is placed on it.", "Description",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Cappuccino is a popular coffee drink made by combining a shot of espresso with steamed milk and a layer of milk foam on top. " +
                "Cappuccinos are usually served in a small cup and have a stronger coffee flavor than a latte, with a 1/3 ratio. Espresso, 1/3 steamed milk and 1/3 skimmed milk." +
                " They are often consumed as a dessert coffee in the morning or after a meal and can also be flavored with syrups such as caramel or vanilla.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Americano is a popular coffee drink made by adding hot water to a shot of espresso. " +
                "This drink is usually served in a larger cup than espresso, a shot of espresso is added first, " +
                "and then hot water is poured over it. Some people enjoy adding milk or cream to their Americano," +
                " but it's usually black. This drink is a popular choice for those who prefer a milder coffee taste or want to prolong the enjoyment of their espresso shot.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void labelAffogato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Affogato is a popular Italian dessert that combines a shot of espresso with a scoop of vanilla ice cream or gelato." +
                " This dessert is usually served in a small dish or glass and can be served as a sweet and strong coffee or as an after-dinner dessert. ate food The hot espresso melts the ice cream and creates a rich, creamy taste of bitter espresso and sweet ice cream." +
                " Some types of coffee affogato include the addition of toppings such as whipped cream, chocolate sauce or nuts to enhance the taste and texture of the dessert.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Iced coffee can be a refreshing alternative to hot coffee, especially in hot weather or for those who prefer a colder drink. " +
                "It's also a versatile drink, as it can be customized to suit different preferences," +
                " such as adding cream, sugar or flavours.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Red eye coffee can be a great option for those who need strong caffeine, " +
                "as the combination of brewed coffee and espresso can create a much higher caffeine content than a regular cup of coffee. " +
                "However, it's important to remember that too much caffeine can have negative health effects, " +
                "so it's best to drink red-eye coffee in moderation.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChBlackCoffee_Click(object sender, EventArgs e)
        {
            // BlackCoffee : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(0))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("BlackCoffee", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void ChEspresso_Click(object sender, EventArgs e)
        {
            // Espresso: 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(1))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Espresso", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChLatte_Click(object sender, EventArgs e)
        {
            // Latte : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(2))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Latte", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChCappuccino_Click(object sender, EventArgs e)
        {
            // Cappuccino: 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(3))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Cappuccino", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChAmericano_Click(object sender, EventArgs e)
        {
            // Americano : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(4))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Americano", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChAffogato_Click(object sender, EventArgs e)
        {
            // Affogato : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(5))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Affogato", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ChIceCoffee_Click(object sender, EventArgs e)
        {
            // Ice Coffee : 3$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(6))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Ice Coffee", 3);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ChRedEye_Click(object sender, EventArgs e)
        {
            // Red Eye : 2$
            LLProducts lLProducts = new LLProducts();
            if (lLProducts.UpdateSell(7))
            {
                int Temp_CountShpping = Convert.ToInt32(CountShopping.Text);
                Temp_CountShpping++;
                CountShopping.Text = Temp_CountShpping.ToString();
                LLPurchase lPurchase = new LLPurchase();
                lPurchase.CheckIs("Red Eye", 2);
            }
            else
            {
                MessageBox.Show("This Product Is Not Available In Stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void shopingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPurchases_Show form = new FormPurchases_Show("Coffee");
            form.ShowDialog();
            this.Close();
        }
    }
}
