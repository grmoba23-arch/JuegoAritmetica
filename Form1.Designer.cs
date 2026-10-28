namespace JuegoAritmetica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlInicio = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblJugador1 = new Label();
            txtJugador1 = new TextBox();
            lblJugador2 = new Label();
            txtJugador2 = new TextBox();
            grpJugadores = new GroupBox();
            rbUno = new RadioButton();
            rbDos = new RadioButton();
            btnIniciar = new Button();
            lblClasificacion = new Label();
            listBox1 = new ListBox();
            pnlJuego = new Panel();
            pnlEncabezadoJuego = new Panel();
            lblTituloJuego = new Label();
            lblTurno = new Label();
            pnlOperacion = new Panel();
            lblInstruccion = new Label();
            lblN1 = new Label();
            lblOperador = new Label();
            lblN2 = new Label();
            label4 = new Label();
            txtResultado = new TextBox();
            btnAceptar = new Button();
            pnlEstadisticas = new Panel();
            label1 = new Label();
            lblAciertos = new Label();
            label2 = new Label();
            lblErrores = new Label();
            label3 = new Label();
            lblPuntos = new Label();
            label5 = new Label();
            lblNivel = new Label();
            label6 = new Label();
            lblTiempo = new Label();
            pnlResultados = new Panel();
            pnlEncabezadoResultados = new Panel();
            lblTituloResultados = new Label();
            pnlGanador = new Panel();
            lblTrofeo = new Label();
            lblGanador = new Label();
            lblResumen = new Label();
            lstResultados = new ListBox();
            btnOtraVez = new Button();
            btnSalir = new Button();
            pnlInicio.SuspendLayout();
            grpJugadores.SuspendLayout();
            pnlJuego.SuspendLayout();
            pnlEncabezadoJuego.SuspendLayout();
            pnlOperacion.SuspendLayout();
            pnlEstadisticas.SuspendLayout();
            pnlResultados.SuspendLayout();
            pnlEncabezadoResultados.SuspendLayout();
            pnlGanador.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInicio
            // 
            pnlInicio.BackColor = Color.FromArgb(244, 247, 252);
            pnlInicio.Controls.Add(lblTitulo);
            pnlInicio.Controls.Add(lblSubtitulo);
            pnlInicio.Controls.Add(lblJugador1);
            pnlInicio.Controls.Add(txtJugador1);
            pnlInicio.Controls.Add(lblJugador2);
            pnlInicio.Controls.Add(txtJugador2);
            pnlInicio.Controls.Add(grpJugadores);
            pnlInicio.Dock = DockStyle.Fill;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(984, 611);
            pnlInicio.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 46, 83);
            lblTitulo.Location = new Point(285, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(460, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DESAFÍO MATEMÁTICO";
            lblTitulo.Click += Titulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.ForeColor = Color.FromArgb(105, 115, 130);
            lblSubtitulo.Location = new Point(310, 90);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(316, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Demuestra cuánto sabes y supera cada nivel";
            // 
            // lblJugador1
            // 
            lblJugador1.AutoSize = true;
            lblJugador1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblJugador1.ForeColor = Color.FromArgb(24, 46, 83);
            lblJugador1.Location = new Point(170, 145);
            lblJugador1.Name = "lblJugador1";
            lblJugador1.Size = new Size(166, 20);
            lblJugador1.TabIndex = 2;
            lblJugador1.Text = "Nombre del Jugador 1";
            // 
            // txtJugador1
            // 
            txtJugador1.BackColor = Color.White;
            txtJugador1.BorderStyle = BorderStyle.FixedSingle;
            txtJugador1.Font = new Font("Segoe UI", 12F);
            txtJugador1.ForeColor = Color.FromArgb(24, 46, 83);
            txtJugador1.Location = new Point(170, 175);
            txtJugador1.Name = "txtJugador1";
            txtJugador1.Size = new Size(260, 29);
            txtJugador1.TabIndex = 3;
            // 
            // lblJugador2
            // 
            lblJugador2.AutoSize = true;
            lblJugador2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblJugador2.ForeColor = Color.FromArgb(24, 46, 83);
            lblJugador2.Location = new Point(550, 145);
            lblJugador2.Name = "lblJugador2";
            lblJugador2.Size = new Size(166, 20);
            lblJugador2.TabIndex = 4;
            lblJugador2.Text = "Nombre del Jugador 2";
            // 
            // txtJugador2
            // 
            txtJugador2.BackColor = Color.White;
            txtJugador2.BorderStyle = BorderStyle.FixedSingle;
            txtJugador2.Font = new Font("Segoe UI", 12F);
            txtJugador2.ForeColor = Color.FromArgb(24, 46, 83);
            txtJugador2.Location = new Point(550, 175);
            txtJugador2.Name = "txtJugador2";
            txtJugador2.Size = new Size(260, 29);
            txtJugador2.TabIndex = 5;
            // 
            // grpJugadores
            // 
            grpJugadores.BackColor = Color.White;
            grpJugadores.Controls.Add(rbUno);
            grpJugadores.Controls.Add(rbDos);
            grpJugadores.Controls.Add(btnIniciar);
            grpJugadores.Controls.Add(lblClasificacion);
            grpJugadores.Controls.Add(listBox1);
            grpJugadores.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpJugadores.ForeColor = Color.FromArgb(24, 46, 83);
            grpJugadores.Location = new Point(170, 240);
            grpJugadores.Name = "grpJugadores";
            grpJugadores.Size = new Size(640, 315);
            grpJugadores.TabIndex = 6;
            grpJugadores.TabStop = false;
            grpJugadores.Text = "  CONFIGURACIÓN DE LA PARTIDA  ";
            // 
            // rbUno
            // 
            rbUno.AutoSize = true;
            rbUno.Checked = true;
            rbUno.Font = new Font("Segoe UI", 11F);
            rbUno.ForeColor = Color.FromArgb(24, 46, 83);
            rbUno.Location = new Point(105, 48);
            rbUno.Name = "rbUno";
            rbUno.Size = new Size(91, 24);
            rbUno.TabIndex = 0;
            rbUno.TabStop = true;
            rbUno.Text = "1 jugador";
            rbUno.UseVisualStyleBackColor = true;
            // 
            // rbDos
            // 
            rbDos.AutoSize = true;
            rbDos.Font = new Font("Segoe UI", 11F);
            rbDos.ForeColor = Color.FromArgb(24, 46, 83);
            rbDos.Location = new Point(425, 48);
            rbDos.Name = "rbDos";
            rbDos.Size = new Size(105, 24);
            rbDos.TabIndex = 1;
            rbDos.Text = "2 jugadores";
            rbDos.UseVisualStyleBackColor = true;
            rbDos.CheckedChanged += rbDos_CheckedChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(54, 105, 230);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(215, 88);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(210, 50);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "INICIAR PARTIDA";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClasificacion.ForeColor = Color.FromArgb(24, 46, 83);
            lblClasificacion.Location = new Point(195, 158);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(234, 21);
            lblClasificacion.TabIndex = 3;
            lblClasificacion.Text = "🏆  TABLA DE CLASIFICACIÓN";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(248, 250, 253);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 10F);
            listBox1.ForeColor = Color.FromArgb(24, 46, 83);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(120, 195);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(400, 87);
            listBox1.TabIndex = 4;
            // 
            // pnlJuego
            // 
            pnlJuego.BackColor = Color.FromArgb(244, 247, 252);
            pnlJuego.Controls.Add(pnlOperacion);
            pnlJuego.Controls.Add(btnAceptar);
            pnlJuego.Controls.Add(pnlEstadisticas);
            pnlJuego.Controls.Add(pnlEncabezadoJuego);
            pnlJuego.Dock = DockStyle.Fill;
            pnlJuego.Location = new Point(0, 0);
            pnlJuego.Name = "pnlJuego";
            pnlJuego.Size = new Size(984, 611);
            pnlJuego.TabIndex = 1;
            pnlJuego.Visible = false;
            // 
            // pnlEncabezadoJuego
            // 
            pnlEncabezadoJuego.BackColor = Color.FromArgb(24, 46, 83);
            pnlEncabezadoJuego.Controls.Add(lblTituloJuego);
            pnlEncabezadoJuego.Controls.Add(lblTurno);
            pnlEncabezadoJuego.Dock = DockStyle.Top;
            pnlEncabezadoJuego.Location = new Point(0, 0);
            pnlEncabezadoJuego.Name = "pnlEncabezadoJuego";
            pnlEncabezadoJuego.Size = new Size(984, 100);
            pnlEncabezadoJuego.TabIndex = 0;
            // 
            // lblTituloJuego
            // 
            lblTituloJuego.AutoSize = true;
            lblTituloJuego.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTituloJuego.ForeColor = Color.White;
            lblTituloJuego.Location = new Point(42, 22);
            lblTituloJuego.Name = "lblTituloJuego";
            lblTituloJuego.Size = new Size(396, 46);
            lblTituloJuego.TabIndex = 0;
            lblTituloJuego.Text = "DESAFÍO MATEMÁTICO";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(185, 215, 255);
            lblTurno.Location = new Point(755, 38);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(137, 21);
            lblTurno.TabIndex = 1;
            lblTurno.Text = "Turno: Jugador 1";
            // 
            // pnlOperacion
            // 
            pnlOperacion.BackColor = Color.White;
            pnlOperacion.BorderStyle = BorderStyle.FixedSingle;
            pnlOperacion.Controls.Add(lblInstruccion);
            pnlOperacion.Controls.Add(lblN1);
            pnlOperacion.Controls.Add(lblOperador);
            pnlOperacion.Controls.Add(lblN2);
            pnlOperacion.Controls.Add(label4);
            pnlOperacion.Controls.Add(txtResultado);
            pnlOperacion.Location = new Point(117, 140);
            pnlOperacion.Name = "pnlOperacion";
            pnlOperacion.Size = new Size(750, 220);
            pnlOperacion.TabIndex = 1;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(120, 130, 145);
            lblInstruccion.Location = new Point(245, 25);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(273, 20);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "RESUELVE LA SIGUIENTE OPERACIÓN";
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblN1.ForeColor = Color.FromArgb(24, 46, 83);
            lblN1.Location = new Point(100, 85);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(53, 62);
            lblN1.TabIndex = 1;
            lblN1.Text = "8";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblOperador.ForeColor = Color.FromArgb(225, 72, 86);
            lblOperador.Location = new Point(205, 85);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(60, 62);
            lblOperador.TabIndex = 2;
            lblOperador.Text = "+";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblN2.ForeColor = Color.FromArgb(24, 46, 83);
            lblN2.Location = new Point(300, 85);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(53, 62);
            lblN2.TabIndex = 3;
            lblN2.Text = "4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(130, 140, 150);
            label4.Location = new Point(400, 85);
            label4.Name = "label4";
            label4.Size = new Size(60, 62);
            label4.TabIndex = 4;
            label4.Text = "=";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(248, 250, 253);
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            txtResultado.ForeColor = Color.FromArgb(24, 46, 83);
            txtResultado.Location = new Point(490, 92);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(140, 47);
            txtResultado.TabIndex = 5;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(54, 105, 230);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(372, 385);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(240, 52);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "COMPROBAR RESPUESTA";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // pnlEstadisticas
            // 
            pnlEstadisticas.BackColor = Color.White;
            pnlEstadisticas.BorderStyle = BorderStyle.FixedSingle;
            pnlEstadisticas.Controls.Add(label1);
            pnlEstadisticas.Controls.Add(lblAciertos);
            pnlEstadisticas.Controls.Add(label2);
            pnlEstadisticas.Controls.Add(lblErrores);
            pnlEstadisticas.Controls.Add(label3);
            pnlEstadisticas.Controls.Add(lblPuntos);
            pnlEstadisticas.Controls.Add(label5);
            pnlEstadisticas.Controls.Add(lblNivel);
            pnlEstadisticas.Controls.Add(label6);
            pnlEstadisticas.Controls.Add(lblTiempo);
            pnlEstadisticas.Location = new Point(117, 465);
            pnlEstadisticas.Name = "pnlEstadisticas";
            pnlEstadisticas.Size = new Size(750, 105);
            pnlEstadisticas.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 170, 112);
            label1.Location = new Point(45, 20);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "✓ ACIERTOS";
            // 
            // lblAciertos
            // 
            lblAciertos.AutoSize = true;
            lblAciertos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAciertos.ForeColor = Color.FromArgb(28, 170, 112);
            lblAciertos.Location = new Point(75, 50);
            lblAciertos.Name = "lblAciertos";
            lblAciertos.Size = new Size(33, 37);
            lblAciertos.TabIndex = 1;
            lblAciertos.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(225, 72, 86);
            label2.Location = new Point(185, 20);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 2;
            label2.Text = "✕ ERRORES";
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblErrores.ForeColor = Color.FromArgb(225, 72, 86);
            lblErrores.Location = new Point(215, 50);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(33, 37);
            lblErrores.TabIndex = 3;
            lblErrores.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(54, 105, 230);
            label3.Location = new Point(325, 20);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 4;
            label3.Text = "★ PUNTOS";
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPuntos.ForeColor = Color.FromArgb(54, 105, 230);
            lblPuntos.Location = new Point(350, 50);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(33, 37);
            lblPuntos.TabIndex = 5;
            lblPuntos.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(239, 150, 45);
            label5.Location = new Point(465, 20);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 6;
            label5.Text = "◆ NIVEL";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNivel.ForeColor = Color.FromArgb(239, 150, 45);
            lblNivel.Location = new Point(490, 50);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(33, 37);
            lblNivel.TabIndex = 7;
            lblNivel.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(127, 86, 217);
            label6.Location = new Point(600, 20);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 8;
            label6.Text = "◷ TIEMPO";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTiempo.ForeColor = Color.FromArgb(127, 86, 217);
            lblTiempo.Location = new Point(625, 50);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(49, 37);
            lblTiempo.TabIndex = 9;
            lblTiempo.Text = "10";
            // 
            // pnlResultados
            // 
            pnlResultados.BackColor = Color.FromArgb(244, 247, 252);
            pnlResultados.Controls.Add(pnlGanador);
            pnlResultados.Controls.Add(lblResumen);
            pnlResultados.Controls.Add(lstResultados);
            pnlResultados.Controls.Add(btnOtraVez);
            pnlResultados.Controls.Add(btnSalir);
            pnlResultados.Controls.Add(pnlEncabezadoResultados);
            pnlResultados.Dock = DockStyle.Fill;
            pnlResultados.Location = new Point(0, 0);
            pnlResultados.Name = "pnlResultados";
            pnlResultados.Size = new Size(984, 611);
            pnlResultados.TabIndex = 2;
            pnlResultados.Visible = false;
            // 
            // pnlEncabezadoResultados
            // 
            pnlEncabezadoResultados.BackColor = Color.FromArgb(24, 46, 83);
            pnlEncabezadoResultados.Controls.Add(lblTituloResultados);
            pnlEncabezadoResultados.Dock = DockStyle.Top;
            pnlEncabezadoResultados.Location = new Point(0, 0);
            pnlEncabezadoResultados.Name = "pnlEncabezadoResultados";
            pnlEncabezadoResultados.Size = new Size(984, 100);
            pnlEncabezadoResultados.TabIndex = 0;
            // 
            // lblTituloResultados
            // 
            lblTituloResultados.AutoSize = true;
            lblTituloResultados.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTituloResultados.ForeColor = Color.White;
            lblTituloResultados.Location = new Point(275, 27);
            lblTituloResultados.Name = "lblTituloResultados";
            lblTituloResultados.Size = new Size(486, 46);
            lblTituloResultados.TabIndex = 0;
            lblTituloResultados.Text = "RESULTADOS DE LA PARTIDA";
            // 
            // pnlGanador
            // 
            pnlGanador.BackColor = Color.White;
            pnlGanador.BorderStyle = BorderStyle.FixedSingle;
            pnlGanador.Controls.Add(lblTrofeo);
            pnlGanador.Controls.Add(lblGanador);
            pnlGanador.Location = new Point(142, 135);
            pnlGanador.Name = "pnlGanador";
            pnlGanador.Size = new Size(700, 150);
            pnlGanador.TabIndex = 1;
            // 
            // lblTrofeo
            // 
            lblTrofeo.AutoSize = true;
            lblTrofeo.Font = new Font("Segoe UI Emoji", 38F);
            lblTrofeo.Location = new Point(310, 5);
            lblTrofeo.Name = "lblTrofeo";
            lblTrofeo.Size = new Size(95, 68);
            lblTrofeo.TabIndex = 0;
            lblTrofeo.Text = "🏆";
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblGanador.ForeColor = Color.FromArgb(24, 46, 83);
            lblGanador.Location = new Point(215, 85);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(318, 37);
            lblGanador.TabIndex = 1;
            lblGanador.Text = "GANADOR: JUGADOR 1";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResumen.ForeColor = Color.FromArgb(24, 46, 83);
            lblResumen.Location = new Point(380, 315);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(206, 21);
            lblResumen.TabIndex = 2;
            lblResumen.Text = "RESUMEN DE LA PARTIDA";
            // 
            // lstResultados
            // 
            lstResultados.BackColor = Color.White;
            lstResultados.BorderStyle = BorderStyle.FixedSingle;
            lstResultados.Font = new Font("Segoe UI", 12F);
            lstResultados.ForeColor = Color.FromArgb(24, 46, 83);
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(242, 355);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(500, 107);
            lstResultados.TabIndex = 3;
            // 
            // btnOtraVez
            // 
            btnOtraVez.BackColor = Color.FromArgb(54, 105, 230);
            btnOtraVez.Cursor = Cursors.Hand;
            btnOtraVez.FlatAppearance.BorderSize = 0;
            btnOtraVez.FlatStyle = FlatStyle.Flat;
            btnOtraVez.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOtraVez.ForeColor = Color.White;
            btnOtraVez.Location = new Point(252, 505);
            btnOtraVez.Name = "btnOtraVez";
            btnOtraVez.Size = new Size(220, 50);
            btnOtraVez.TabIndex = 3;
            btnOtraVez.Text = "JUGAR OTRA VEZ";
            btnOtraVez.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(225, 72, 86);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(512, 505);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 252);
            ClientSize = new Size(984, 611);
            Controls.Add(pnlJuego);
            Controls.Add(pnlInicio);
            Controls.Add(pnlResultados);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desafío Matemático";
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            grpJugadores.ResumeLayout(false);
            grpJugadores.PerformLayout();
            pnlJuego.ResumeLayout(false);
            pnlEncabezadoJuego.ResumeLayout(false);
            pnlEncabezadoJuego.PerformLayout();
            pnlOperacion.ResumeLayout(false);
            pnlOperacion.PerformLayout();
            pnlEstadisticas.ResumeLayout(false);
            pnlEstadisticas.PerformLayout();
            pnlResultados.ResumeLayout(false);
            pnlResultados.PerformLayout();
            pnlEncabezadoResultados.ResumeLayout(false);
            pnlEncabezadoResultados.PerformLayout();
            pnlGanador.ResumeLayout(false);
            pnlGanador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion



        private Panel pnlInicio;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Label lblJugador1;
        private TextBox txtJugador1;

        private Label lblJugador2;
        private TextBox txtJugador2;

        private GroupBox grpJugadores;

        private RadioButton rbUno;
        private RadioButton rbDos;

        private Button btnIniciar;

        private Label lblClasificacion;
        private ListBox listBox1;


        private Panel pnlJuego;

        private Panel pnlEncabezadoJuego;

        private Label lblTituloJuego;
        private Label lblTurno;

        private Panel pnlOperacion;

        private Label lblInstruccion;

        private Label lblN1;
        private Label lblOperador;
        private Label lblN2;

        private Label label4;

        private TextBox txtResultado;

        private Button btnAceptar;

        private Panel pnlEstadisticas;

        private Label label1;
        private Label lblAciertos;

        private Label label2;
        private Label lblErrores;

        private Label label3;
        private Label lblPuntos;

        private Label label5;
        private Label lblNivel;

        private Label label6;
        private Label lblTiempo;


        private Panel pnlResultados;

        private Panel pnlEncabezadoResultados;

        private Label lblTituloResultados;

        private Panel pnlGanador;

        private Label lblTrofeo;
        private Label lblGanador;

        private Label lblResumen;

        private ListBox lstResultados;

        private Button btnOtraVez;

        private Button btnSalir;
    }
}