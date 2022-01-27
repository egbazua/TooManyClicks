using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooManyClicks
{
    public partial class TooManyClicks_Form : Form
    {
        // Variables
        int click;
        int contador;

        public TooManyClicks_Form()
        {
            InitializeComponent();
            click = 0;
            contador = 0;
        }

        //Evento del botón para iniciar o reiniciar el juego.
        private void Iniciar_Btn_Click(object sender, EventArgs e)
        {
            temporizador_Tmr.Enabled = false;
            numerocontador_Lbl.Text = "30";
            jugar_Btn.Enabled = true;
            temporizador_Tmr.Enabled = true;
            contador = 30;
            click = 0;
            clicks_Lbl.Text = Convert.ToString(click);
            iniciar_Btn.Text = "REINICIAR";
        }

        //Evento del botón que cuenta los clicks.
        private void Jugar_Btn_Click(object sender, EventArgs e)
        {
            click++;

            //Modificación del label de la cantidad de clicks.
            clicks_Lbl.Text = Convert.ToString(click);
        }

        //Evento del temporizador en segundos.
        private void Temporizador_Tmr_Tick(object sender, EventArgs e)
        {
            contador--;
            numerocontador_Lbl.Text = Convert.ToString(contador);
            if (contador == 0) {
                temporizador_Tmr.Stop();
                jugar_Btn.Enabled = false;
                iniciar_Btn.Text = "INICIAR";

                // userForm Instance
                userForm myUserForm = new userForm(clicks_Lbl.Text);
                myUserForm.ShowDialog();
            } 
        }

        private void recordsBtn_Click(object sender, EventArgs e)
        {
            recordsForm myRecordsForm = new recordsForm();
            myRecordsForm.ShowDialog();
        }

        private void TooManyClicks_Form_Load(object sender, EventArgs e)
        {
            ConnectionDB myConnection = new ConnectionDB();
            myConnection.open();
        }
    }//Fin de la Clase.
}
