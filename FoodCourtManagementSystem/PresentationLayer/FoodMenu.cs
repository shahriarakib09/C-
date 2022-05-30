using System;
using FoodCourtManagementSystem.PresentationLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodCourtManagementSystem.DataAccessLayer.Entities;
using FoodCourtManagementSystem.BusinessLayer;

namespace FoodCourtManagementSystem.PresentationLayer
{
    public partial class FoodMenu : Form
    {
        UserInfo userInfo=new UserInfo();
        OrderLists orderList;
        int Id;
        OrderService orderService = new OrderService();
        public FoodMenu(int id)
        {
            InitializeComponent();
            Id = id;
            if (txtReceipt.Text == "")
            {
                txtReceipt.AppendText("-----------------------------------------------------------------------------------------" + Environment.NewLine);
                txtReceipt.AppendText("\t" + " Food Court   \t  " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + Environment.NewLine);
                txtReceipt.AppendText("-----------------------------------------------------------------------------------------" + Environment.NewLine);
            }
        }

        int grandTotal = 0;

        private void cbPorota_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorota.Checked)
                {
                txtPorotaQuantity.Text = "";
                txtPorotaQuantity.ReadOnly = false;
                }
            else if (!cbPorota.Checked)
            {
                txtPorotaQuantity.ReadOnly = true;
                txtPorotaQuantity.Text = "0";
            }
                
        }

        private void cbDalVaji_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDalVaji.Checked)
            {
                txtDaalVajiQuantity.Text = "";
                txtDaalVajiQuantity.ReadOnly = false;
            }
            else if (!cbDalVaji.Checked)
            {
                txtDaalVajiQuantity.ReadOnly = true;
                txtDaalVajiQuantity.Text = "0";
            }
        }

        private void cbDimVaji_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDimVaji.Checked)
            {
                txtDimVajiQuantity.Text = "";
                txtDimVajiQuantity.ReadOnly = false;
            }
            else if (!cbDimVaji.Checked)
            {
                txtDimVajiQuantity.ReadOnly = true;
                txtDimVajiQuantity.Text = "0";
            }
        }

        private void cbNehari_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNehari.Checked)
            {
                txtNehariQuantity.Text = "";
                txtNehariQuantity.ReadOnly = false;
            }
            else if (!cbPorota.Checked)
            {
                txtNehariQuantity.ReadOnly = true;
                txtNehariQuantity.Text = "0";
            }
        }

        private void cbKacchiBiriyani_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKacchiBiriyani.Checked)
            {
                txtKachhiQuantity.Text = "";
                txtKachhiQuantity.ReadOnly = false;
            }
            else if (!cbKacchiBiriyani.Checked)
            {
                txtKachhiQuantity.ReadOnly = true;
                txtKachhiQuantity.Text = "0";
            }

        }

        private void cbMorogPulaw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMorogPulaw.Checked)
            {
                txtMorogPulawQuantity.Text = "";
                txtMorogPulawQuantity.ReadOnly = false;
            }
            else if (!cbMorogPulaw.Checked)
            {
                txtMorogPulawQuantity.ReadOnly = true;
                txtMorogPulawQuantity.Text = "0";
            }
        }

        private void cbBeefKhichuri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBeefKhichuri.Checked)
            {
                txtBeefKhichuriQuantity.Text = "";
                txtBeefKhichuriQuantity.ReadOnly = false;
            }
            else if (!cbBeefKhichuri.Checked)
            {
                txtBeefKhichuriQuantity.ReadOnly = true;
                txtBeefKhichuriQuantity.Text = "0";
            }
        }

        private void cbBeefTehari_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBeefTehari.Checked)
            {
                txtBeefTehariQuantity.Text = "";
                txtBeefTehariQuantity.ReadOnly = false;
            }
            else if (!cbBeefTehari.Checked)
            {
                txtBeefTehariQuantity.ReadOnly = true;
                txtBeefTehariQuantity.Text = "0";
            }
        }

        private void cbFriedRice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFriedRice.Checked)
            {
                txtFriedRiceQuantity.Text = "";
                txtFriedRiceQuantity.ReadOnly = false;
            }
            else if (!cbFriedRice.Checked)
            {
                txtFriedRiceQuantity.ReadOnly = true;
                txtFriedRiceQuantity.Text = "0";
            }
        }

        private void cbRIce_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRIce.Checked)
            {
                txtRiceQuantity.Text = "";
                txtRiceQuantity.ReadOnly = false;
            }
            else if (!cbRIce.Checked)
            {
                txtRiceQuantity.ReadOnly = true;
                txtRiceQuantity.Text = "0";
            }

        }

        private void cbBeefBhuna_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBeefBhuna.Checked)
            {
                txtBeefBhunaQuantity.Text = "";
                txtBeefBhunaQuantity.ReadOnly = false;
            }
            else if (!cbBeefBhuna.Checked)
            {
                txtBeefBhunaQuantity.ReadOnly = true;
                txtBeefBhunaQuantity.Text = "0";
            }

        }
        private void cbChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChicken.Checked)
            {
                txtChickenJholQuantity.Text = "";
                txtChickenJholQuantity.ReadOnly = false;
            }
            else if (!cbBeefTehari.Checked)
            {
                txtChickenJholQuantity.ReadOnly = true;
                txtChickenJholQuantity.Text = "0";
            }
        }

        private void cbCrispyChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCrispyChicken.Checked)
            {
                txtCrispyChickenQuantity.Text = "";
                txtCrispyChickenQuantity.ReadOnly = false;
            }
            else if (!cbCrispyChicken.Checked)
            {
                txtCrispyChickenQuantity.ReadOnly = true;
                txtCrispyChickenQuantity.Text = "0";
            }
        }

        private void cbDoubleCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDoubleCheese.Checked)
            {
                txtDoubleCheeseBlastQuantity.Text = "";
                txtDoubleCheeseBlastQuantity.ReadOnly = false;
            }
            else if (!cbDoubleCheese.Checked)
            {
                txtDoubleCheeseBlastQuantity.ReadOnly = true;
                txtDoubleCheeseBlastQuantity.Text = "0";
            }
        }

        private void cbSmokeyBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSmokeyBeef.Checked)
            {
                txtSmokeyBeefQuantity.Text = "";
                txtSmokeyBeefQuantity.ReadOnly = false;
            }
            else if (!cbSmokeyBeef.Checked)
            {
                txtSmokeyBeefQuantity.ReadOnly = true;
                txtSmokeyBeefQuantity.Text = "0";
            }
        }

        private void cbBbqChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBbqChicken.Checked)
            {
                txtBbqQuantity.Text = "";
                txtBbqQuantity.ReadOnly = false;
            }
            else if (!cbBbqChicken.Checked)
            {
                txtBbqQuantity.ReadOnly = true;
                txtBbqQuantity.Text = "0";
            }
        }

        private void cbJorda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJorda.Checked)
            {
                txtJordaQuantity.Text = "";
                txtJordaQuantity.ReadOnly = false;
            }
            else if (!cbJorda.Checked)
            {
                txtJordaQuantity.ReadOnly = true;
                txtJordaQuantity.Text = "0";
            }
        }

        private void cbPhirni_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhirni.Checked)
            {
                txtPhirniQuantity.Text = "";
                txtPhirniQuantity.ReadOnly = false;
            }
            else if (!cbPhirni.Checked)
            {
                txtPhirniQuantity.ReadOnly = true;
                txtPhirniQuantity.Text = "0";
            }
        }

        private void cbPudding_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPudding.Checked)
            {
                txtPuddingQuantity.Text = "";
                txtPuddingQuantity.ReadOnly = false;
            }
            else if (!cbPudding.Checked)
            {
                txtPuddingQuantity.ReadOnly = true;
                txtPuddingQuantity.Text = "0";
            }


        }
        private void cbPastry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPastry.Checked)
            {
                txtPastryQuantity.Text = "";
                txtPastryQuantity.ReadOnly = false;
            }
            else if (!cbPastry.Checked)
            {
                txtPastryQuantity.ReadOnly = true;
                txtPastryQuantity.Text = "0";
            }
        }

        private void cbColdDrinks_CheckedChanged(object sender, EventArgs e)
        {

            if (cbColdDrinks.Checked)
            {
                txtColdDrinksQuantity.Text = "";
                txtColdDrinksQuantity.ReadOnly = false;
            }
            else if (!cbColdDrinks.Checked)
            {
                txtColdDrinksQuantity.ReadOnly = true;
                txtColdDrinksQuantity.Text = "0";
            }
        }

        private void cbCoffee_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCoffee.Checked)
            {
                txtCoffeeQuantity.Text = "";
                txtCoffeeQuantity.ReadOnly = false;
            }
            else if (!cbCoffee.Checked)
            {
                txtCoffeeQuantity.ReadOnly = true;
                txtCoffeeQuantity.Text = "0";
            }
        }

        private void cbLemonade_CheckedChanged(object sender, EventArgs e)
        {

            if (cbLemonade.Checked)
            {
                txtLemonadeQuantity.Text = "";
                txtLemonadeQuantity.ReadOnly = false;
            }
            else if (!cbLemonade.Checked)
            {
                txtLemonadeQuantity.ReadOnly = true;
                txtLemonadeQuantity.Text = "0";
            }
        }

        private void cbWater_CheckedChanged(object sender, EventArgs e)
        {

            if (cbWater.Checked)
            {
                txtWaterQuantity.Text = "";
                txtWaterQuantity.ReadOnly = false;
            }
            else if (!cbWater.Checked)
            {
                txtWaterQuantity.ReadOnly = true;
                txtWaterQuantity.Text = "0";
            }
        }

        private void cbPepparoni_CheckedChanged(object sender, EventArgs e)
        {

            if (cbPepparoni.Checked)
            {
                txtPepparoniQuantity.Text = "";
                txtPepparoniQuantity.ReadOnly = false;
            }
            else if (!cbPepparoni.Checked)
            {
                txtPepparoniQuantity.ReadOnly = true;
                txtPepparoniQuantity.Text = "0";
            }
        }

        private void cbSpicyChicken_CheckedChanged(object sender, EventArgs e)
        {

            if (cbSpicyChicken.Checked)
            {
                txtSpicyChickenQuantity.Text = "";
                txtSpicyChickenQuantity.ReadOnly = false;
            }
            else if (!cbSpicyChicken.Checked)
            {
                txtSpicyChickenQuantity.ReadOnly = true;
                txtSpicyChickenQuantity.Text = "0";
            }
        }

        private void cbBeefCheese_CheckedChanged(object sender, EventArgs e)
        {

            if (cbBeefCheese.Checked)
            {
                txtBeefCheeseQuantity.Text = "";
                txtBeefCheeseQuantity.ReadOnly = false;
            }
            else if (!cbBeefCheese.Checked)
            {
                txtBeefCheeseQuantity.ReadOnly = true;
                txtBeefCheeseQuantity.Text = "0";
            }
        }

        private void cbDeepDish_CheckedChanged(object sender, EventArgs e)
        {

            if (cbDeepDish.Checked)
            {
                txtDeepDishQuantity.Text = "";
                txtDeepDishQuantity.ReadOnly = false;
            }
            else if (!cbDeepDish.Checked)
            {
                txtDeepDishQuantity.ReadOnly = true;
                txtDeepDishQuantity.Text = "0";
            }
        }
       
        private void btnBreakfastAdd_Click(object sender, EventArgs e)
        {
            string Porota,DalVaji,DimVaji,Nehari;
            int amountPorota=0, amountDal=0, amountDim=0, amountNehari=0;

            if (cbPorota.Checked && txtPorotaQuantity.Text != "")
            {                
                    amountPorota = Convert.ToInt32(txtPorotaQuantity.Text) * 15;
                    Porota = "Porota  15X " + txtPorotaQuantity.Text + "=" + amountPorota + "";                                   

            }
            else 
            {
                Porota = "";
            }

            if (cbDalVaji.Checked && txtDaalVajiQuantity.Text != "")
            {
                amountDal= Convert.ToInt32(txtDaalVajiQuantity.Text) * 30;
                DalVaji = "Dal Vaji 30 X " + txtDaalVajiQuantity.Text + "=" + amountDal + "";
            }
            else { DalVaji = ""; }

            if (cbDimVaji.Checked && txtDimVajiQuantity.Text!="")
            {
                amountDim = Convert.ToInt32(txtDimVajiQuantity.Text) * 20;
                DimVaji = "Dim Vaji  20X " + txtDimVajiQuantity.Text + "=" + amountDim + "";

            }
            else { DimVaji = ""; }

            if (cbNehari.Checked && txtNehariQuantity.Text!="")
            {
                amountNehari = Convert.ToInt32(txtNehariQuantity.Text) * 80;
                Nehari = "Nehari  80X " + txtNehariQuantity.Text + "=" + amountNehari + "";
            }
            else { Nehari = ""; }

            if(Porota!="")
            {
                txtReceipt.AppendText(Porota + Environment.NewLine);
            }
            if(DalVaji!="")
            {
                txtReceipt.AppendText(DalVaji + Environment.NewLine);
            }
            if(DimVaji!="")
            {
                txtReceipt.AppendText(DimVaji + Environment.NewLine);
            }
            if(Nehari!="")
            {
                txtReceipt.AppendText(Nehari + Environment.NewLine);
            }
            grandTotal =grandTotal+ amountPorota + amountNehari + amountDim + amountDal;
            txtBreakfast.Text =( amountPorota + amountNehari + amountDim + amountDal).ToString();

        }

        private void btnLunchAdd_Click(object sender, EventArgs e)
        {
            string KacchiBiriyani, MorogPulaw, BeefKhichuri, BeefTehari;
            int amountKacchi = 0, amountMorogPulaw = 0, amountBeefKhichuri = 0, amountBeefTehari = 0;





            if (cbKacchiBiriyani.Checked && txtKachhiQuantity.Text != "")
            {
                amountKacchi = Convert.ToInt32(txtKachhiQuantity.Text) * 230;
                KacchiBiriyani = "Kacchi Biriyani  230X " + txtKachhiQuantity.Text + "=" + amountKacchi + "";

            }
            else
            {
                KacchiBiriyani = "";
            }

            if (cbMorogPulaw.Checked && txtMorogPulawQuantity.Text != "")
            {
                amountMorogPulaw = Convert.ToInt32(txtMorogPulawQuantity.Text) * 120;
                MorogPulaw = "Morog Pulaw 120 X " + txtMorogPulawQuantity.Text + "=" + amountMorogPulaw + "";
            }
            else { MorogPulaw = ""; }

            if (cbBeefKhichuri.Checked && txtBeefKhichuriQuantity.Text != "")
            {
                amountBeefKhichuri = Convert.ToInt32(txtBeefKhichuriQuantity.Text) * 160;
                BeefKhichuri = "Beef Khicuri  160X " + txtBeefKhichuriQuantity.Text + "=" + amountBeefKhichuri + "";

            }
            else { BeefKhichuri = ""; }

            if (cbBeefTehari.Checked && txtBeefTehariQuantity.Text != "")
            {
                amountBeefTehari = Convert.ToInt32(txtBeefTehariQuantity.Text) * 140;
                BeefTehari = "Beef Tehari  140X " + txtBeefTehariQuantity.Text + "=" + amountBeefTehari + "";
            }
            else { BeefTehari = ""; }

            if (KacchiBiriyani != "")
            {
                txtReceipt.AppendText(KacchiBiriyani + Environment.NewLine);
            }
            if (MorogPulaw != "")
            {
                txtReceipt.AppendText(MorogPulaw + Environment.NewLine);
            }
            if (BeefKhichuri != "")
            {
                txtReceipt.AppendText(BeefKhichuri + Environment.NewLine);
            }
            if (BeefTehari != "")
            {
                txtReceipt.AppendText(BeefTehari + Environment.NewLine);
            }
            grandTotal =grandTotal+ amountKacchi + amountMorogPulaw + amountBeefKhichuri + amountBeefTehari;
            txtLunch.Text = (amountKacchi + amountMorogPulaw + amountBeefKhichuri + amountBeefTehari).ToString();


        }

        private void btnDinnerAdd_Click(object sender, EventArgs e)
        {

            string FriedRice, Rice, BeefBhuna, ChickenJhol;
            int amountFriedRice = 0, amountRice = 0, amountBeefBhuna = 0, amountChickenJhol = 0;



            if (cbFriedRice.Checked && txtFriedRiceQuantity.Text != "")
            {
                amountFriedRice = Convert.ToInt32(txtFriedRiceQuantity.Text) * 180;
                FriedRice = "Fried Rice  180X " + txtFriedRiceQuantity.Text + "=" + amountFriedRice + "";

            }
            else
            {
                FriedRice = "";
            }

            if (cbRIce.Checked && txtRiceQuantity.Text != "")
            {
                amountRice = Convert.ToInt32(txtRiceQuantity.Text) * 20;
                Rice = "Rice 20 X " + txtRiceQuantity.Text + "=" + amountRice + "";
            }
            else { Rice = ""; }

            if (cbBeefBhuna.Checked && txtBeefBhunaQuantity.Text != "")
            {
                amountBeefBhuna = Convert.ToInt32(txtBeefBhunaQuantity.Text) * 250;
                BeefBhuna = "Beef Bhuna  250X " + txtBeefBhunaQuantity.Text + "=" + amountBeefBhuna + "";

            }
            else { BeefBhuna = ""; }

            if (cbChicken.Checked && txtChickenJholQuantity.Text != "")
            {
                amountChickenJhol = Convert.ToInt32(txtChickenJholQuantity.Text) * 80;
                ChickenJhol = "Chicken Jhol  80X " + txtChickenJholQuantity.Text + "=" + amountChickenJhol + "";
            }
            else { ChickenJhol = ""; }

            if (FriedRice != "")
            {
                txtReceipt.AppendText(FriedRice + Environment.NewLine);
            }
            if (Rice != "")
            {
                txtReceipt.AppendText(Rice + Environment.NewLine);
            }
            if (BeefBhuna != "")
            {
                txtReceipt.AppendText(BeefBhuna + Environment.NewLine);
            }
            if (ChickenJhol != "")
            {
                txtReceipt.AppendText(ChickenJhol + Environment.NewLine);
            }
            grandTotal = grandTotal+ amountFriedRice + amountFriedRice + amountBeefBhuna + amountChickenJhol;
            txtDinner.Text = (amountFriedRice + amountFriedRice + amountBeefBhuna + amountChickenJhol).ToString();

        }

        private void btnBurgerAdd_Click(object sender, EventArgs e)
        {
            string CrispyChicken, DoubleCheese, SmokeyBeef, BBQChicken;
            int amountCrispyChicken = 0, amountDoubleCheese = 0, amountSmokeyBeef = 0, amountBBQChicken = 0;


            if (cbCrispyChicken.Checked && txtCrispyChickenQuantity.Text != "")
            {
                amountCrispyChicken = Convert.ToInt32(txtCrispyChickenQuantity.Text) * 300;
                CrispyChicken = "Crispy Chicken Burger  300X " + txtCrispyChickenQuantity.Text + "=" + amountCrispyChicken + "";

            }
            else
            {
                CrispyChicken = "";
            }

            if (cbDoubleCheese.Checked && txtDoubleCheeseBlastQuantity.Text != "")
            {
                amountDoubleCheese = Convert.ToInt32(txtDoubleCheeseBlastQuantity.Text) * 350;
                DoubleCheese = "Double cheese Blast Burger 350 X " + txtDoubleCheeseBlastQuantity.Text + "=" + amountDoubleCheese + "";
            }
            else { DoubleCheese = ""; }

            if (cbSmokeyBeef.Checked && txtSmokeyBeefQuantity.Text != "")
            {
                amountSmokeyBeef = Convert.ToInt32(txtSmokeyBeefQuantity.Text) * 380;
                SmokeyBeef = "Smokey Beef Burger 380X " + txtSmokeyBeefQuantity.Text + "=" + amountSmokeyBeef + "";

            }
            else { SmokeyBeef = ""; }

            if (cbBbqChicken.Checked && txtBbqQuantity.Text != "")
            {
                amountBBQChicken = Convert.ToInt32(txtBbqQuantity.Text) * 340;
                BBQChicken = "BBQ Chicken Burger  340X " + txtBbqQuantity.Text + "=" + amountBBQChicken + "";
            }
            else { BBQChicken = ""; }

            if (CrispyChicken != "")
            {
                txtReceipt.AppendText(CrispyChicken + Environment.NewLine);
            }
            if (DoubleCheese != "")
            {
                txtReceipt.AppendText(DoubleCheese + Environment.NewLine);
            }
            if (SmokeyBeef != "")
            {
                txtReceipt.AppendText(SmokeyBeef + Environment.NewLine);
            }
            if (BBQChicken != "")
            {
                txtReceipt.AppendText(BBQChicken + Environment.NewLine);
            }
            
            grandTotal = grandTotal+ amountCrispyChicken + amountDoubleCheese + amountSmokeyBeef + amountBBQChicken;
            txtBurger.Text = (amountCrispyChicken + amountDoubleCheese + amountSmokeyBeef + amountBBQChicken).ToString();


        }

        private void btnDessertAdd_Click(object sender, EventArgs e)
        {

            string Jorda, Phirni, Pudding, Pastry;
            int amountJorda = 0, amountPhirni = 0, amountPudding = 0, amountPastry = 0;


            if (cbJorda.Checked && txtJordaQuantity.Text != "")
            {
                amountJorda = Convert.ToInt32(txtJordaQuantity.Text) * 80;
                Jorda = "Jorda 80X " + txtJordaQuantity.Text + "=" + amountJorda + "";

            }
            else
            {
                Jorda = "";
            }

            if (cbPhirni.Checked && txtPhirniQuantity.Text != "")
            {
                amountPhirni = Convert.ToInt32(txtPhirniQuantity.Text) * 100;
                Phirni = "Phirni 100X " + txtPhirniQuantity.Text + "=" + amountPhirni + "";
            }
            else { Phirni = ""; }

            if (cbPudding.Checked && txtPuddingQuantity.Text != "")
            {
                amountPudding = Convert.ToInt32(txtPuddingQuantity.Text) * 140;
                Pudding = "Pudding 140X " + txtPuddingQuantity.Text + "=" + amountPudding + "";

            }
            else { Pudding = ""; }

            if (cbPastry.Checked && txtPastryQuantity.Text != "")
            {
                amountPastry = Convert.ToInt32(txtPastryQuantity.Text) * 90;
                Pastry = "Pastry 90X " + txtPastryQuantity.Text + "=" + amountPastry + "";
            }
            else { Pastry = ""; }

            if (Jorda != "")
            {
                txtReceipt.AppendText(Jorda + Environment.NewLine);
            }
            if (Phirni != "")
            {
                txtReceipt.AppendText(Phirni + Environment.NewLine);
            }
            if (Pudding != "")
            {
                txtReceipt.AppendText(Pudding + Environment.NewLine);
            }
            if (Pastry != "")
            {
                txtReceipt.AppendText(Pastry + Environment.NewLine);
            }
            grandTotal = grandTotal+ amountJorda + amountPhirni + amountPudding + amountPastry;
            txtDessert.Text = (amountJorda + amountPhirni + amountPudding + amountPastry).ToString();


        }

        private void btnDrinksAdd_Click(object sender, EventArgs e)
        {
            string ColdDrinks, Coffee, Lemonade, Water;
            int amountColdDrinks = 0, amountCoffee = 0, amountLemonade = 0, amountWater = 0;



            if (cbColdDrinks.Checked && txtColdDrinksQuantity.Text != "")
            {
                amountColdDrinks = Convert.ToInt32(txtColdDrinksQuantity.Text) * 40;
                ColdDrinks = "Cold Drinks 40X " + txtColdDrinksQuantity.Text + "=" + amountColdDrinks + "";

            }
            else
            {
                ColdDrinks = "";
            }

            if (cbCoffee.Checked && txtCoffeeQuantity.Text != "")
            {
                amountCoffee = Convert.ToInt32(txtCoffeeQuantity.Text) * 100;
                Coffee = "Coffee 100X " + txtCoffeeQuantity.Text + "=" + amountCoffee + "";
            }
            else { Coffee = ""; }

            if (cbLemonade.Checked && txtLemonadeQuantity.Text != "")
            {
                amountLemonade = Convert.ToInt32(txtLemonadeQuantity.Text) * 80;
                Lemonade = "Lemonade 80X " + txtLemonadeQuantity.Text + "=" + amountLemonade + "";

            }
            else { Lemonade = ""; }

            if (cbWater.Checked && txtWaterQuantity.Text != "")
            {
                amountWater = Convert.ToInt32(txtWaterQuantity.Text) * 20;
                Water = "Water 20X " + txtWaterQuantity.Text + "=" + amountWater + "";
            }
            else { Water = ""; }

            if (ColdDrinks != "")
            {
                txtReceipt.AppendText(ColdDrinks + Environment.NewLine);
            }
            if (Coffee != "")
            {
                txtReceipt.AppendText(Coffee + Environment.NewLine);
            }
            if (Lemonade != "")
            {
                txtReceipt.AppendText(Lemonade + Environment.NewLine);
            }
            if (Water != "")
            {
                txtReceipt.AppendText(Water + Environment.NewLine);
            }

            grandTotal =grandTotal+ amountColdDrinks + amountCoffee + amountLemonade + amountWater;
            txtDrinks.Text = (amountColdDrinks + amountCoffee + amountLemonade + amountWater).ToString();



        }

        private void btnPizzaAdd_Click(object sender, EventArgs e)
        {

            string PepparoniPizza, SpicyChickenPizza, BeefCheesePizza, DeepDishPizza;
            int amountPepparoniPizza=0, amountSpicyChickenPizza=0, amountBeefCheesePizza=0, amountDeepDishPizza=0;

            if (cbPepparoni.Checked && txtPepparoniQuantity.Text != "")
            {
                amountPepparoniPizza = Convert.ToInt32(txtPepparoniQuantity.Text) * 830;
                PepparoniPizza = "Pepparoni Pizza 830X " + txtPepparoniQuantity.Text + "=" + amountPepparoniPizza + "";

            }
            else
            {
                PepparoniPizza = "";
            }

            if (cbSpicyChicken.Checked && txtSpicyChickenQuantity.Text != "")
            {
                amountSpicyChickenPizza = Convert.ToInt32(txtSpicyChickenQuantity.Text) * 430;
                SpicyChickenPizza = "Spicy Chicken Pizza 430X " + txtSpicyChickenQuantity.Text + "=" + amountSpicyChickenPizza + "";
            }
            else { SpicyChickenPizza = ""; }

            if (cbBeefCheese.Checked && txtBeefCheeseQuantity.Text != "")
            {
                amountBeefCheesePizza = Convert.ToInt32(txtBeefCheeseQuantity.Text) * 520;
                BeefCheesePizza = "Beef Chesee Pizza 520X " + txtBeefCheeseQuantity.Text + "=" + amountBeefCheesePizza + "";

            }
            else { BeefCheesePizza = ""; }

            if (cbDeepDish.Checked && txtDeepDishQuantity.Text != "")
            {
                amountDeepDishPizza = Convert.ToInt32(txtDeepDishQuantity.Text) * 1020;
                DeepDishPizza = "Deep Dish Pizza 1020X " + txtDeepDishQuantity.Text + "=" + amountDeepDishPizza + "";
            }
            else { DeepDishPizza = ""; }

            if (PepparoniPizza != "")
            {
                txtReceipt.AppendText(PepparoniPizza + Environment.NewLine);
            }
            if (SpicyChickenPizza != "")
            {
                txtReceipt.AppendText(SpicyChickenPizza + Environment.NewLine);
            }
            if (BeefCheesePizza != "")
            {
                txtReceipt.AppendText(BeefCheesePizza + Environment.NewLine);
            }
            if (DeepDishPizza != "")
            {
                txtReceipt.AppendText(DeepDishPizza + Environment.NewLine);
            }
           
            grandTotal =grandTotal+ amountPepparoniPizza + amountSpicyChickenPizza + amountSpicyChickenPizza + amountDeepDishPizza;
            txtPizza.Text = (amountPepparoniPizza + amountSpicyChickenPizza + amountSpicyChickenPizza + amountDeepDishPizza).ToString();



        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
           if(!txtReceipt.Text.Contains("Grand Total") && txtReceipt.Text.Contains("X"))
            {
                OrderLists orderLists = new OrderLists();
                orderLists.FoodItem = txtReceipt.Text;
                orderLists.Price = grandTotal;
                orderLists.UserID = Id;
                orderLists.Date = Convert.ToString( DateTime.Now.ToString("MM/dd/yyyy h:mm tt"));

                txtReceipt.AppendText("-----------------------------------------------------------------------------------------" + Environment.NewLine);
                txtReceipt.AppendText("Grand Total:" + grandTotal + Environment.NewLine);

                int verify = orderService.OrderConfirmation(orderLists);
                if(verify>0)
                {
                    MessageBox.Show("Your Order has been Confirmed");
                }
                else
                {
                    MessageBox.Show("Invalid Request.");
                }
                

            }
           else if(!txtReceipt.Text.Contains("X"))
            {
                MessageBox.Show("Please select an item first ");
            }
        }

        private void txtBreakfast_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
        }

        private void btnBack6_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
        }

        private void btnBack7_Click(object sender, EventArgs e)
        {
            userInfo.UserId = Id;
            this.Hide();
            UserHomePage userHomePage = new UserHomePage(Id);
            userHomePage.ShowDialog();
        }

        private void FoodMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }


