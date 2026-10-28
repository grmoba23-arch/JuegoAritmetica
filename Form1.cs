using System;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoAritmetica
{
    public partial class Form1 : Form
    {
      

        Color azulOscuro = Color.FromArgb(24, 46, 83);
        Color fondo = Color.FromArgb(244, 247, 252);



        string[] nombres = new string[2];

        int cantidadJugadores = 1;

        bool jugador1 = true;

        int n1 = 0;
        int n2 = 0;
        int resultado = 0;
        int operacion = 0;

        int nivel = 1;
        int limite = 11;

        int tiempo = 10;




        int[,] jugadores = new int[2, 3];


       

        string[] historialNombres = new string[20];

        int[] historialPuntos = new int[20];

        int cantidadHistorial = 0;


        

        System.Windows.Forms.Timer temporizador =
            new System.Windows.Forms.Timer();


       

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            btnIniciar.Click += btnIniciar_Click;

            btnAceptar.Click += btnAceptar_Click;

            btnOtraVez.Click += btnOtraVez_Click;

            btnSalir.Click += btnSalir_Click;

            rbUno.CheckedChanged += rbUno_CheckedChanged;

            temporizador.Interval = 1000;

            temporizador.Tick += Temporizador_Tick;
        }


    

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Desafío Matemático";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.BackColor =
                fondo;

            pnlInicio.Visible = true;

            pnlJuego.Visible = false;

            pnlResultados.Visible = false;

            rbUno.Checked = true;

            txtJugador2.Enabled = false;

            MostrarClasificacion();
        }



        private void rbUno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUno.Checked)
            {
                txtJugador2.Enabled = false;

                txtJugador2.Clear();
            }
        }




        private void rbDos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDos.Checked)
            {
                txtJugador2.Enabled = true;
            }
        }


    

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // VALIDAR JUGADOR 1

            if (txtJugador1.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Debe escribir el nombre del Jugador 1.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtJugador1.Focus();

                return;
            }


            // CANTIDAD DE JUGADORES

            if (rbUno.Checked)
            {
                cantidadJugadores = 1;
            }
            else
            {
                cantidadJugadores = 2;
            }


            // VALIDAR JUGADOR 2

            if (cantidadJugadores == 2)
            {
                if (txtJugador2.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Debe escribir el nombre del Jugador 2.",
                        "Dato requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtJugador2.Focus();

                    return;
                }
            }


            // GUARDAR NOMBRES

            nombres[0] =
                txtJugador1.Text.Trim();


            if (cantidadJugadores == 2)
            {
                nombres[1] =
                    txtJugador2.Text.Trim();
            }
            else
            {
                nombres[1] =
                    "";
            }


            // LIMPIAR MATRIZ

            for (int fila = 0;
                 fila < 2;
                 fila++)
            {
                for (int columna = 0;
                     columna < 3;
                     columna++)
                {
                    jugadores[fila, columna] = 0;
                }
            }


            jugador1 = true;

            nivel = 1;

            limite = 11;

            tiempo = 10;


            // MOSTRAR PANEL DEL JUEGO

            pnlInicio.Visible = false;

            pnlResultados.Visible = false;

            pnlJuego.Visible = true;

            pnlJuego.BringToFront();


            ActualizarPantalla();

            Seleccion_Operacion();
        }


  

        private int JugadorActual()
        {
            if (jugador1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }


 

        private void ActualizarPantalla()
        {
            int fila =
                JugadorActual();


            lblTurno.Text =
                "Turno: " + nombres[fila];


            lblAciertos.Text =
                jugadores[fila, 0].ToString();


            lblErrores.Text =
                jugadores[fila, 1].ToString();


            lblPuntos.Text =
                jugadores[fila, 2].ToString();


            ActualizarNivel(fila);
        }


    

        private void ActualizarNivel(int fila)
        {
            int aciertos =
                jugadores[fila, 0];


            if (aciertos < 3)
            {
                nivel = 1;

                limite = 11;
            }

            else if (aciertos < 6)
            {
                nivel = 2;

                limite = 51;
            }

            else
            {
                nivel = 3;

                limite = 101;
            }


            lblNivel.Text =
                nivel.ToString();
        }


      

        private void Seleccion_Operacion()
        {
            temporizador.Stop();


            int fila =
                JugadorActual();


            ActualizarNivel(fila);


            n1 =
                Random.Shared.Next(1, limite);


            n2 =
                Random.Shared.Next(1, limite);


            // NIVEL 1
            // SUMA Y RESTA

            if (nivel == 1)
            {
                operacion =
                    Random.Shared.Next(1, 3);
            }


            // NIVEL 2
            // SUMA, RESTA Y MULTIPLICACIÓN

            else if (nivel == 2)
            {
                operacion =
                    Random.Shared.Next(1, 4);
            }


            // NIVEL 3
            // TODAS LAS OPERACIONES

            else
            {
                operacion =
                    Random.Shared.Next(1, 5);
            }


            switch (operacion)
            {
                // SUMA

                case 1:

                    resultado =
                        n1 + n2;

                    lblOperador.Text =
                        "+";

                    break;


                // RESTA

                case 2:

                    if (n2 > n1)
                    {
                        int temporal =
                            n1;

                        n1 =
                            n2;

                        n2 =
                            temporal;
                    }


                    resultado =
                        n1 - n2;

                    lblOperador.Text =
                        "-";

                    break;


                // MULTIPLICACIÓN

                case 3:

                    if (nivel == 2)
                    {
                        n1 =
                            Random.Shared.Next(1, 13);

                        n2 =
                            Random.Shared.Next(1, 13);
                    }
                    else
                    {
                        n1 =
                            Random.Shared.Next(1, 21);

                        n2 =
                            Random.Shared.Next(1, 21);
                    }


                    resultado =
                        n1 * n2;

                    lblOperador.Text =
                        "×";

                    break;


                // DIVISIÓN

                case 4:

                    n2 =
                        Random.Shared.Next(1, 11);


                    resultado =
                        Random.Shared.Next(1, 11);


                    n1 =
                        n2 * resultado;


                    lblOperador.Text =
                        "÷";

                    break;
            }


            lblN1.Text =
                n1.ToString();


            lblN2.Text =
                n2.ToString();


            txtResultado.Clear();

            txtResultado.Focus();


            // REINICIAR TIEMPO

            tiempo = 10;


            lblTiempo.Text =
                tiempo.ToString();


            temporizador.Start();
        }


     

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int respuesta;


            // VALIDAR NÚMERO

            if (!int.TryParse(
                txtResultado.Text,
                out respuesta))
            {
                MessageBox.Show(
                    "Debe escribir una respuesta numérica.",
                    "Respuesta inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtResultado.Clear();

                txtResultado.Focus();

                return;
            }


            temporizador.Stop();


            int fila =
                JugadorActual();


            // RESPUESTA CORRECTA

            if (respuesta == resultado)
            {
                jugadores[fila, 0]++;

                jugadores[fila, 2] += 5;


                MessageBox.Show(
                    "¡Respuesta correcta!\n\nGanaste 5 puntos.",
                    "Muy bien",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }


            // RESPUESTA INCORRECTA

            else
            {
                jugadores[fila, 1]++;


                MessageBox.Show(
                    "Respuesta incorrecta."
                    + "\n\nLa respuesta correcta era: "
                    + resultado,
                    "Respuesta incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


            ContinuarPartida();
        }


        

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempo--;


            lblTiempo.Text =
                tiempo.ToString();


            if (tiempo <= 0)
            {
                temporizador.Stop();


                int fila =
                    JugadorActual();


                jugadores[fila, 1]++;


                MessageBox.Show(
                    "¡Se acabó el tiempo!"
                    + "\n\nLa respuesta correcta era: "
                    + resultado,
                    "Tiempo agotado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                ContinuarPartida();
            }
        }




        private void ContinuarPartida()
        {
            // =================================================
            // UN JUGADOR
            // =================================================

            if (cantidadJugadores == 1)
            {
                if (jugadores[0, 1] >= 3)
                {
                    FinalizarPartida();

                    return;
                }


                ActualizarPantalla();

                Seleccion_Operacion();

                return;
            }


            // =================================================
            // DOS JUGADORES
            // =================================================

            bool jugador1Fuera =
                jugadores[0, 1] >= 3;


            bool jugador2Fuera =
                jugadores[1, 1] >= 3;


            // LOS DOS TERMINARON

            if (jugador1Fuera &&
                jugador2Fuera)
            {
                FinalizarPartida();

                return;
            }


            // CAMBIAR TURNO

            if (jugador1)
            {
                if (!jugador2Fuera)
                {
                    jugador1 = false;
                }
            }
            else
            {
                if (!jugador1Fuera)
                {
                    jugador1 = true;
                }
            }


            ActualizarPantalla();

            Seleccion_Operacion();
        }



        private void FinalizarPartida()
        {
            temporizador.Stop();


            pnlJuego.Visible = false;

            pnlInicio.Visible = false;

            pnlResultados.Visible = true;

            pnlResultados.BringToFront();


            lstResultados.Items.Clear();


            if (cantidadJugadores == 1)
            {
                lblGanador.Text =
                    "PARTIDA FINALIZADA";


                lstResultados.Items.Add(
                    nombres[0]
                    + " | Aciertos: "
                    + jugadores[0, 0]
                    + " | Errores: "
                    + jugadores[0, 1]
                    + " | Puntos: "
                    + jugadores[0, 2]
                );


                GuardarClasificacion(
                    nombres[0],
                    jugadores[0, 2]
                );
            }


  

            else
            {
                lstResultados.Items.Add(
                    nombres[0]
                    + " | Aciertos: "
                    + jugadores[0, 0]
                    + " | Errores: "
                    + jugadores[0, 1]
                    + " | Puntos: "
                    + jugadores[0, 2]
                );


                lstResultados.Items.Add(
                    nombres[1]
                    + " | Aciertos: "
                    + jugadores[1, 0]
                    + " | Errores: "
                    + jugadores[1, 1]
                    + " | Puntos: "
                    + jugadores[1, 2]
                );


                if (jugadores[0, 2] >
                    jugadores[1, 2])
                {
                    lblGanador.Text =
                        "GANADOR: "
                        + nombres[0];
                }

                else if (jugadores[1, 2] >
                         jugadores[0, 2])
                {
                    lblGanador.Text =
                        "GANADOR: "
                        + nombres[1];
                }

                else
                {
                    lblGanador.Text =
                        "RESULTADO: EMPATE";
                }


                GuardarClasificacion(
                    nombres[0],
                    jugadores[0, 2]
                );


                GuardarClasificacion(
                    nombres[1],
                    jugadores[1, 2]
                );
            }


            OrdenarClasificacion();

            MostrarClasificacion();
        }


        

        private void GuardarClasificacion(
            string nombre,
            int puntos)
        {
            if (cantidadHistorial < 20)
            {
                historialNombres[cantidadHistorial] =
                    nombre;


                historialPuntos[cantidadHistorial] =
                    puntos;


                cantidadHistorial++;
            }
        }


        private void OrdenarClasificacion()
        {
            for (int i = 0;
                 i < cantidadHistorial - 1;
                 i++)
            {
                for (int j = 0;
                     j < cantidadHistorial - 1 - i;
                     j++)
                {
                    if (historialPuntos[j] <
                        historialPuntos[j + 1])
                    {
                        int puntosTemporal =
                            historialPuntos[j];


                        historialPuntos[j] =
                            historialPuntos[j + 1];


                        historialPuntos[j + 1] =
                            puntosTemporal;


                        string nombreTemporal =
                            historialNombres[j];


                        historialNombres[j] =
                            historialNombres[j + 1];


                        historialNombres[j + 1] =
                            nombreTemporal;
                    }
                }
            }
        }



        private void MostrarClasificacion()
        {
            listBox1.Items.Clear();


            if (cantidadHistorial == 0)
            {
                listBox1.Items.Add(
                    "Todavía no hay partidas registradas."
                );

                return;
            }


            for (int i = 0;
                 i < cantidadHistorial;
                 i++)
            {
                listBox1.Items.Add(
                    (i + 1)
                    + ". "
                    + historialNombres[i]
                    + " - "
                    + historialPuntos[i]
                    + " puntos"
                );
            }
        }



        private void btnOtraVez_Click(object sender, EventArgs e)
        {
            temporizador.Stop();


            pnlResultados.Visible = false;

            pnlJuego.Visible = false;

            pnlInicio.Visible = true;

            pnlInicio.BringToFront();


            txtResultado.Clear();


            lblAciertos.Text = "0";

            lblErrores.Text = "0";

            lblPuntos.Text = "0";

            lblNivel.Text = "1";

            lblTiempo.Text = "10";


            MostrarClasificacion();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            temporizador.Stop();

            Application.Exit();
        }



        private void Titulo_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}