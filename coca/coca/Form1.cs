using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coca
{
    public partial class Form1 : Form
    {
        ExpenderProcess exp = new ExpenderProcess();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            
            this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/coca.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = exp.Precio + "";
            label15.Text =exp.Coca+"";
            label16.Text = exp.Fresca + "";
            label17.Text = exp.Fanta + "";
            label18.Text = exp.Sprite + "";
            label19.Text = exp.Manzanita + "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/spriten.jpg");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                String message = "Por favor ingrese coins";
                String caption = "¡OoPs!";
                MessageBox.Show(message, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                double valor;
                double coins = 0;
                if (!(double.TryParse(textBox1.Text, out valor)))
                {

                    String mensajeInser = "Por favor ingresa numeros";
                    String captionInser = "¡OoPs!";
                    MessageBox.Show(mensajeInser, captionInser,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                    textBox1.Text = "";

                }
                else
                {

                    int validacionTotal = 0;

                    validacionTotal = exp.ValidarExisteneTotal();


                    if (validacionTotal == 0)
                    {
                        String mensajeval = "Esta maquina esta vacia, se le devuelve sus dinero, espere a ser llenada";
                        String captionval = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeval, captionval,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);


                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                        radioButton3.Enabled = false;
                        radioButton4.Enabled = false;
                        radioButton5.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;

                        button1.Enabled = false;
                        textBox1.Enabled = true;
                        textBox1.Text = "";
                        button2.Enabled = true;
                        label13.Text = "";
                        label14.Text = "";
                        this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/verde.jpg");
                        exp.Coins = 0.0;
                        exp.ResultInsert = 0.0;



                    }
                    else
                    {

                        coins = Convert.ToDouble(textBox1.Text);
                        exp.Coins = coins;

                        if (coins == 0.5 || coins == 1 || coins == 2 || coins == 5 || coins == 10)
                        {

                            exp.CalculoMonetario();
                            label13.Text = "$" + exp.ResultInsert;
                            textBox1.Text = "";

                            if (exp.Precio <= exp.ResultInsert)
                            {
                                radioButton1.Enabled = true;
                                radioButton2.Enabled = true;
                                radioButton3.Enabled = true;
                                radioButton4.Enabled = true;
                                radioButton5.Enabled = true;
                                radioButton1.Checked = true;
                                button1.Enabled = true;
                                textBox1.Enabled = false;
                                button2.Enabled = false;
                                label14.Text = exp.Cambio + "";
                            }


                        }
                        else
                        {
                            String mensajeInser = "Solo se aceptan coins de $0.5  $1  $2  $5  $10 ";
                            String captionInser = "¡OoPs!";
                            MessageBox.Show(mensajeInser, captionInser,
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Warning);

                            textBox1.Text = "";
                        }

                    }
                }

            }
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resurtirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cant = "";
            cant = Microsoft.VisualBasic.Interaction.InputBox("¿De Cuantas cocas es el refill ?",
                                                                   "Refil de cocas", "1");


            int valor;
            int cantfill = 0;

            if (!(int.TryParse(cant, out valor)))
            {
                String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                String captionPrecio = "¡ Chescos el angiano!";
                MessageBox.Show(mensajePrecio, captionPrecio,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

            }
            else
            {
                cantfill = Convert.ToInt32(cant);


                if (!(int.TryParse(cant, out valor)) || cantfill <= 0)
                {
                    String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                    String captionPrecio = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePrecio, captionPrecio,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);


                }
                else
                {
                    int refil = Convert.ToInt32(cant);
                    exp.Coca += refil;
                    label15.Text = exp.Coca + "";
                }
            }
        }

        private void precioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cant = "";
                   cant = Microsoft.VisualBasic.Interaction.InputBox("¿Quieres cambiar el precio?", 
                                                                          "Cambio de precio", "4.5");

            double valor;
            double precio = 0;

            if (!(double.TryParse(cant, out valor)))
            {
                String mensajePrecio = "Esa cifra no es valida ingrese numeros";
                String captionPrecio = "¡ Chescos el angiano!";
                MessageBox.Show(mensajePrecio, captionPrecio,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

            }
            else
            {
                precio = Convert.ToDouble(cant);

                if (!(precio % 0.5 == 0))
                {
                    String mensajePre = "Esa cifra no es valida, " +
                        "por favor ingrese valores enteros o enteros con .50 positivos, " +
                        " ejemplos: Aceptables =>(.50,1,1.50,2,2.50) " +
                        "Inaceptables ==> (0.1,0.2,1.25,2.35) ";
                    String captionPre = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePre, captionPre,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);

                }
                else
                {

                    if (!(double.TryParse(cant, out valor)) || precio <= 0)
                    {
                        String mensajePrecio = "Esa cifra no es valida ";
                        String captionPrecio = "¡ Chescos el angiano!";
                        MessageBox.Show(mensajePrecio, captionPrecio,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);


                    }
                    else
                    {
                        double nprecio = Convert.ToDouble(cant);
                        exp.Precio = nprecio;
                        label8.Text = nprecio + "";
                    }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/fresca.jpg");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/fanta.jpg");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/manzanita.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validacionTotal = 0;

            validacionTotal = exp.ValidarExisteneTotal();


            if (validacionTotal == 0)
            {
                String mensajeval = "Esta maquina esta vacia, se le devuelve sus $" + exp.ResultInsert;
                String captionval = "¡Gracias por comprar en chescos el angiano!";
                MessageBox.Show(mensajeval, captionval,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);


                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                
                button1.Enabled = false;
                textBox1.Enabled = true;
                button2.Enabled = true;
                label13.Text = "";
                label14.Text = "";
                this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/verde.jpg");
                exp.Coins = 0.0;
                exp.ResultInsert = 0.0;



            }
            else
            {

                int validacionExist = 0;
                if (radioButton1.Checked)
                {
                    int existencias = exp.validarExistencias(1);
                    if (existencias == 0)
                    {
                        String mensajeInser = "Ya no hay mas coca-cola";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                    }
                    else
                    {
                        exp.expendercoca();
                        label15.Text = exp.Coca + "";
                        String mensajeInser = "Disfrute su bebida coca-cola";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);

                        validacionExist = 1;
                        radioButton1.Checked = false;
                    }
                }


                if (radioButton2.Checked)
                {

                    int existencias = exp.validarExistencias(2);
                    if (existencias == 0)
                    {
                        String mensajeInser = "Ya no hay mas Fresca";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                    }
                    else
                    {
                        exp.expenderFresca();
                        label16.Text = exp.Fresca + "";

                        String mensajeInser = "Disfrute su bebida Fresca";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        validacionExist = 1;
                        radioButton2.Checked = false;
                    }
                }


                if (radioButton3.Checked)
                {
                    int existencias = exp.validarExistencias(3);
                    if (existencias == 0)
                    {
                        String mensajeInser = "Ya no hay mas Fanta";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                    }
                    else
                    {
                        exp.expenderFanta();
                        label17.Text = exp.Fanta + "";

                        String mensajeInser = "Disfrute su bebida fanta";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        validacionExist = 1;
                        radioButton3.Checked = false;
                    }
                }



                if (radioButton4.Checked)
                {

                    int existencias = exp.validarExistencias(4);
                    if (existencias == 0)
                    {
                        String mensajeInser = "Ya no hay mas Sprite";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                    }
                    else
                    {
                        exp.expenderSprite();
                        label18.Text = exp.Sprite + "";

                        String mensajeInser = "Disfrute su bebida Sprite";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        validacionExist = 1;
                        radioButton4.Checked = false;
                    }
                }


                if (radioButton5.Checked)
                {
                    int existencias = exp.validarExistencias(5);
                    if (existencias == 0)
                    {
                        String mensajeInser = "Ya no hay mas Manzanita";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                    }
                    else
                    {
                        exp.expenderManzanita();
                        label19.Text = exp.Manzanita + "";

                        String mensajeInser = "Disfrute su bebida Manzanita sol";
                        String captionInser = "¡Gracias por comprar en chescos el angiano!";
                        MessageBox.Show(mensajeInser, captionInser,
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        validacionExist = 1;
                        radioButton5.Checked = false;
                    }
                }

                if (validacionExist == 1)
                {
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    radioButton5.Enabled = false;
                    button1.Enabled = false;
                    textBox1.Enabled = true;
                    button2.Enabled = true;
                    label13.Text = "";
                    label14.Text = "";
                    this.pictureBox7.Image = System.Drawing.Image.FromFile("../../Resources/verde.jpg");
                    exp.Coins = 0.0;
                    exp.ResultInsert = 0.0;

                }
                else
                {


                }
            }
        }

        private void fantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cant = "";
            cant = Microsoft.VisualBasic.Interaction.InputBox("¿De Cuantas Fantas es el refill ?",
                                                                   "Refil de Fantas", "1");


            int valor;
            int cantfill = 0;

            if (!(int.TryParse(cant, out valor)))
            {
               String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                    String captionPrecio = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePrecio, captionPrecio,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);

            }
            else
            {
                cantfill = Convert.ToInt32(cant);
                if (!(int.TryParse(cant, out valor)) || cantfill <= 0)
                {

                    String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                    String captionPrecio = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePrecio, captionPrecio,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);


                }
                else
                {
                    int refil = Convert.ToInt32(cant);
                    exp.Fanta += refil;
                    label17.Text = exp.Fanta + "";
                }
            }
        }

        private void spriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cant = "";
            cant = Microsoft.VisualBasic.Interaction.InputBox("¿De Cuantos Sprits es el refill ?",
                                                                   "Refil de Sprits", "1");


            int valor;
            int cantfill = 0;

            if (!(int.TryParse(cant, out valor)))
            {
                String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                String captionPrecio = "¡ Chescos el angiano!";
                MessageBox.Show(mensajePrecio, captionPrecio,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

            }
            else
            {
                cantfill = Convert.ToInt32(cant);
                if (!(int.TryParse(cant, out valor)) || cantfill <= 0)
                {
                    String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                    String captionPrecio = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePrecio, captionPrecio,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);


                }
                else
                {
                    int refil = Convert.ToInt32(cant);
                    exp.Sprite += refil;
                    label18.Text = exp.Sprite + "";
                }
            }
        }

        private void frescaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cant = "";
            cant = Microsoft.VisualBasic.Interaction.InputBox("¿De Cuantas Frescas es el refill ?",
                                                                   "Refil de fresca", "1");
            int valor;
            int cantfill = 0;

            if (!(int.TryParse(cant, out valor)))
            {
                String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                String captionPrecio = "¡ Chescos el angiano!";
                MessageBox.Show(mensajePrecio, captionPrecio,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

            }
            else
            {
                cantfill = Convert.ToInt32(cant);
                if (!(int.TryParse(cant, out valor)) || cantfill <= 0)
                {
                    String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                    String captionPrecio = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePrecio, captionPrecio,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);


                }
                else
                {
                    int refil = Convert.ToInt32(cant);
                    exp.Fresca += refil;
                    label16.Text = exp.Fresca + "";
                }
            }
        }

        private void manzanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cant = "";
            cant = Microsoft.VisualBasic.Interaction.InputBox("¿De Cuantas Manzanitas es el refill ?",
                                                                   "Refil de manzanitas", "1");


            int valor;
            int cantfill = 0;

            if (!(int.TryParse(cant, out valor)))
            {
                String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                String captionPrecio = "¡ Chescos el angiano!";
                MessageBox.Show(mensajePrecio, captionPrecio,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);

            }
            else
            {
                cantfill = Convert.ToInt32(cant);


                if (!(int.TryParse(cant, out valor)) || cantfill <= 0)
                {
                    String mensajePrecio = "Esa cifra no es valida ingrese numeros y enteros";
                    String captionPrecio = "¡ Chescos el angiano!";
                    MessageBox.Show(mensajePrecio, captionPrecio,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);


                }
                else
                {
                    int refil = Convert.ToInt32(cant);
                    exp.Manzanita += refil;
                    label19.Text = exp.Manzanita + "";
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
