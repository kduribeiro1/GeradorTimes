namespace GeradorTimes
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttData = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgsbrProgresso = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemJogTime = new System.Windows.Forms.Button();
            this.btnAddJogTime = new System.Windows.Forms.Button();
            this.btnRemMaxTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdeTimes = new System.Windows.Forms.Label();
            this.lblQtdeJogadoresTimes = new System.Windows.Forms.Label();
            this.btnAddMaxTime = new System.Windows.Forms.Button();
            this.lblQtdeTotalJogadores = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblJogadoresEspera = new System.Windows.Forms.Label();
            this.lstBxJogEspera = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnAdicionarJogador = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGerarTimes = new System.Windows.Forms.Button();
            this.btnComputarPartida = new System.Windows.Forms.Button();
            this.btnRemoverPartida = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnLimparTimes = new System.Windows.Forms.Button();
            this.btnTerminarPartida = new System.Windows.Forms.Button();
            this.btnRemoverJogador = new System.Windows.Forms.Button();
            this.btnAddTimeMenorJogador = new System.Windows.Forms.Button();
            this.pnlTimes = new System.Windows.Forms.Panel();
            this.tbLtPnlTime = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimparTime = new System.Windows.Forms.Button();
            this.lblTimeTitulo = new System.Windows.Forms.Label();
            this.lstBxTime = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.pnlTimes.SuspendLayout();
            this.tbLtPnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttHora,
            this.sttData,
            this.pgsbrProgresso,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttHora
            // 
            this.sttHora.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.sttHora.Name = "sttHora";
            this.sttHora.Size = new System.Drawing.Size(0, 17);
            // 
            // sttData
            // 
            this.sttData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.sttData.Name = "sttData";
            this.sttData.Size = new System.Drawing.Size(0, 17);
            // 
            // pgsbrProgresso
            // 
            this.pgsbrProgresso.Name = "pgsbrProgresso";
            this.pgsbrProgresso.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel3.Text = "Kdu Ribeiro Desenvolvimentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlTimes, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 355);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemJogTime, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddJogTime, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemMaxTime, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQtdeTimes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQtdeJogadoresTimes, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddMaxTime, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQtdeTotalJogadores, 10, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnRemJogTime
            // 
            this.btnRemJogTime.Location = new System.Drawing.Point(478, 3);
            this.btnRemJogTime.Name = "btnRemJogTime";
            this.btnRemJogTime.Size = new System.Drawing.Size(29, 23);
            this.btnRemJogTime.TabIndex = 7;
            this.btnRemJogTime.Text = "-";
            this.btnRemJogTime.UseVisualStyleBackColor = true;
            this.btnRemJogTime.Click += new System.EventHandler(this.BtnRemJogTime_Click);
            // 
            // btnAddJogTime
            // 
            this.btnAddJogTime.Location = new System.Drawing.Point(443, 3);
            this.btnAddJogTime.Name = "btnAddJogTime";
            this.btnAddJogTime.Size = new System.Drawing.Size(29, 23);
            this.btnAddJogTime.TabIndex = 6;
            this.btnAddJogTime.Text = "+";
            this.btnAddJogTime.UseVisualStyleBackColor = true;
            this.btnAddJogTime.Click += new System.EventHandler(this.BtnAddJogTime_Click);
            // 
            // btnRemMaxTime
            // 
            this.btnRemMaxTime.Location = new System.Drawing.Point(218, 3);
            this.btnRemMaxTime.Name = "btnRemMaxTime";
            this.btnRemMaxTime.Size = new System.Drawing.Size(29, 23);
            this.btnRemMaxTime.TabIndex = 5;
            this.btnRemMaxTime.Text = "-";
            this.btnRemMaxTime.UseVisualStyleBackColor = true;
            this.btnRemMaxTime.Click += new System.EventHandler(this.BtnRemMaxTime_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Times";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(263, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogadores Por Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdeTimes
            // 
            this.lblQtdeTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdeTimes.Location = new System.Drawing.Point(123, 0);
            this.lblQtdeTimes.Name = "lblQtdeTimes";
            this.lblQtdeTimes.Size = new System.Drawing.Size(54, 29);
            this.lblQtdeTimes.TabIndex = 2;
            this.lblQtdeTimes.Text = "0";
            this.lblQtdeTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdeJogadoresTimes
            // 
            this.lblQtdeJogadoresTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdeJogadoresTimes.Location = new System.Drawing.Point(383, 0);
            this.lblQtdeJogadoresTimes.Name = "lblQtdeJogadoresTimes";
            this.lblQtdeJogadoresTimes.Size = new System.Drawing.Size(54, 29);
            this.lblQtdeJogadoresTimes.TabIndex = 3;
            this.lblQtdeJogadoresTimes.Text = "0";
            this.lblQtdeJogadoresTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMaxTime
            // 
            this.btnAddMaxTime.Location = new System.Drawing.Point(183, 3);
            this.btnAddMaxTime.Name = "btnAddMaxTime";
            this.btnAddMaxTime.Size = new System.Drawing.Size(29, 23);
            this.btnAddMaxTime.TabIndex = 4;
            this.btnAddMaxTime.Text = "+";
            this.btnAddMaxTime.UseVisualStyleBackColor = true;
            this.btnAddMaxTime.Click += new System.EventHandler(this.BtnAddMaxTime_Click);
            // 
            // lblQtdeTotalJogadores
            // 
            this.lblQtdeTotalJogadores.AutoSize = true;
            this.lblQtdeTotalJogadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdeTotalJogadores.Location = new System.Drawing.Point(524, 0);
            this.lblQtdeTotalJogadores.Name = "lblQtdeTotalJogadores";
            this.lblQtdeTotalJogadores.Size = new System.Drawing.Size(91, 29);
            this.lblQtdeTotalJogadores.TabIndex = 8;
            this.lblQtdeTotalJogadores.Text = "Total Jog.: 0";
            this.lblQtdeTotalJogadores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(618, 154);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblJogadoresEspera, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lstBxJogEspera, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 148);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lblJogadoresEspera
            // 
            this.lblJogadoresEspera.AutoSize = true;
            this.lblJogadoresEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJogadoresEspera.Location = new System.Drawing.Point(3, 0);
            this.lblJogadoresEspera.Name = "lblJogadoresEspera";
            this.lblJogadoresEspera.Size = new System.Drawing.Size(188, 35);
            this.lblJogadoresEspera.TabIndex = 0;
            this.lblJogadoresEspera.Text = "Jogadores Em Espera";
            this.lblJogadoresEspera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBxJogEspera
            // 
            this.lstBxJogEspera.AllowDrop = true;
            this.lstBxJogEspera.DisplayMember = "NomeQtde";
            this.lstBxJogEspera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBxJogEspera.FormattingEnabled = true;
            this.lstBxJogEspera.Location = new System.Drawing.Point(3, 38);
            this.lstBxJogEspera.Name = "lstBxJogEspera";
            this.lstBxJogEspera.Size = new System.Drawing.Size(188, 107);
            this.lstBxJogEspera.TabIndex = 1;
            this.lstBxJogEspera.ValueMember = "Nome";
            this.lstBxJogEspera.SelectedIndexChanged += new System.EventHandler(this.LstBxJogEspera_SelectedIndexChanged);
            this.lstBxJogEspera.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.LstBxJogEspera_ControlRemoved);
            this.lstBxJogEspera.DragDrop += new System.Windows.Forms.DragEventHandler(this.LstBxJogEspera_DragDrop);
            this.lstBxJogEspera.DragEnter += new System.Windows.Forms.DragEventHandler(this.LstBxJogEspera_DragEnter);
            this.lstBxJogEspera.DragOver += new System.Windows.Forms.DragEventHandler(this.LstBxJogEspera_DragOver);
            this.lstBxJogEspera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstBxJogEspera_KeyDown);
            this.lstBxJogEspera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LstBxJogEspera_MouseDown);
            this.lstBxJogEspera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LstBxJogEspera_MouseMove);
            this.lstBxJogEspera.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LstBxJogEspera_MouseUp);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(412, 148);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtNomeJogador, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAdicionarJogador, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(406, 28);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jogador:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeJogador.Location = new System.Drawing.Point(67, 3);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(236, 20);
            this.txtNomeJogador.TabIndex = 1;
            this.txtNomeJogador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeJogador_KeyDown);
            // 
            // btnAdicionarJogador
            // 
            this.btnAdicionarJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionarJogador.Location = new System.Drawing.Point(309, 3);
            this.btnAdicionarJogador.Name = "btnAdicionarJogador";
            this.btnAdicionarJogador.Size = new System.Drawing.Size(94, 22);
            this.btnAdicionarJogador.TabIndex = 2;
            this.btnAdicionarJogador.Text = "Adicionar";
            this.btnAdicionarJogador.UseVisualStyleBackColor = true;
            this.btnAdicionarJogador.Click += new System.EventHandler(this.BtnAdicionarJogador_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.btnGerarTimes, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnComputarPartida, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnRemoverPartida, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnLimparTudo, 2, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnLimparTimes, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnTerminarPartida, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnRemoverJogador, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnAddTimeMenorJogador, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(406, 108);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnGerarTimes
            // 
            this.btnGerarTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGerarTimes.Location = new System.Drawing.Point(215, 3);
            this.btnGerarTimes.Name = "btnGerarTimes";
            this.btnGerarTimes.Size = new System.Drawing.Size(188, 21);
            this.btnGerarTimes.TabIndex = 0;
            this.btnGerarTimes.Text = "Gerar Times";
            this.btnGerarTimes.UseVisualStyleBackColor = true;
            this.btnGerarTimes.Click += new System.EventHandler(this.BtnGerarTimes_Click);
            // 
            // btnComputarPartida
            // 
            this.btnComputarPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComputarPartida.Enabled = false;
            this.btnComputarPartida.Location = new System.Drawing.Point(3, 3);
            this.btnComputarPartida.Name = "btnComputarPartida";
            this.btnComputarPartida.Size = new System.Drawing.Size(186, 21);
            this.btnComputarPartida.TabIndex = 3;
            this.btnComputarPartida.Text = "Computar Partida";
            this.btnComputarPartida.UseVisualStyleBackColor = true;
            this.btnComputarPartida.Click += new System.EventHandler(this.BtnComputarPartida_Click);
            // 
            // btnRemoverPartida
            // 
            this.btnRemoverPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverPartida.Enabled = false;
            this.btnRemoverPartida.Location = new System.Drawing.Point(3, 30);
            this.btnRemoverPartida.Name = "btnRemoverPartida";
            this.btnRemoverPartida.Size = new System.Drawing.Size(186, 21);
            this.btnRemoverPartida.TabIndex = 5;
            this.btnRemoverPartida.Text = "Remover Partida";
            this.btnRemoverPartida.UseVisualStyleBackColor = true;
            this.btnRemoverPartida.Click += new System.EventHandler(this.BtnRemoverPartida_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimparTudo.Location = new System.Drawing.Point(215, 84);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(188, 21);
            this.btnLimparTudo.TabIndex = 2;
            this.btnLimparTudo.Text = "Limpar Tudo";
            this.btnLimparTudo.UseVisualStyleBackColor = true;
            this.btnLimparTudo.Click += new System.EventHandler(this.BtnLimparTudo_Click);
            // 
            // btnLimparTimes
            // 
            this.btnLimparTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimparTimes.Location = new System.Drawing.Point(215, 57);
            this.btnLimparTimes.Name = "btnLimparTimes";
            this.btnLimparTimes.Size = new System.Drawing.Size(188, 21);
            this.btnLimparTimes.TabIndex = 1;
            this.btnLimparTimes.Text = "Limpar Times";
            this.btnLimparTimes.UseVisualStyleBackColor = true;
            this.btnLimparTimes.Click += new System.EventHandler(this.BtnLimparTimes_Click);
            // 
            // btnTerminarPartida
            // 
            this.btnTerminarPartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTerminarPartida.Location = new System.Drawing.Point(215, 30);
            this.btnTerminarPartida.Name = "btnTerminarPartida";
            this.btnTerminarPartida.Size = new System.Drawing.Size(188, 21);
            this.btnTerminarPartida.TabIndex = 7;
            this.btnTerminarPartida.Text = "Terminar Partida";
            this.btnTerminarPartida.UseVisualStyleBackColor = true;
            this.btnTerminarPartida.Click += new System.EventHandler(this.BtnTerminarPartida_Click);
            // 
            // btnRemoverJogador
            // 
            this.btnRemoverJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverJogador.Enabled = false;
            this.btnRemoverJogador.Location = new System.Drawing.Point(3, 84);
            this.btnRemoverJogador.Name = "btnRemoverJogador";
            this.btnRemoverJogador.Size = new System.Drawing.Size(186, 21);
            this.btnRemoverJogador.TabIndex = 8;
            this.btnRemoverJogador.Text = "Remover Jogador";
            this.btnRemoverJogador.UseVisualStyleBackColor = true;
            this.btnRemoverJogador.Click += new System.EventHandler(this.BtnRemoverJogador_Click);
            // 
            // btnAddTimeMenorJogador
            // 
            this.btnAddTimeMenorJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTimeMenorJogador.Enabled = false;
            this.btnAddTimeMenorJogador.Location = new System.Drawing.Point(3, 57);
            this.btnAddTimeMenorJogador.Name = "btnAddTimeMenorJogador";
            this.btnAddTimeMenorJogador.Size = new System.Drawing.Size(186, 21);
            this.btnAddTimeMenorJogador.TabIndex = 9;
            this.btnAddTimeMenorJogador.Text = "Adicionar Ao Time Menor";
            this.btnAddTimeMenorJogador.UseVisualStyleBackColor = true;
            this.btnAddTimeMenorJogador.Click += new System.EventHandler(this.BtnAddTimeMenorJogador_Click);
            // 
            // pnlTimes
            // 
            this.pnlTimes.AutoScroll = true;
            this.pnlTimes.Controls.Add(this.tbLtPnlTime);
            this.pnlTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimes.Location = new System.Drawing.Point(3, 198);
            this.pnlTimes.Name = "pnlTimes";
            this.pnlTimes.Size = new System.Drawing.Size(618, 154);
            this.pnlTimes.TabIndex = 2;
            // 
            // tbLtPnlTime
            // 
            this.tbLtPnlTime.ColumnCount = 1;
            this.tbLtPnlTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLtPnlTime.Controls.Add(this.btnLimparTime, 0, 2);
            this.tbLtPnlTime.Controls.Add(this.lblTimeTitulo, 0, 0);
            this.tbLtPnlTime.Controls.Add(this.lstBxTime, 0, 1);
            this.tbLtPnlTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbLtPnlTime.Location = new System.Drawing.Point(0, 0);
            this.tbLtPnlTime.Name = "tbLtPnlTime";
            this.tbLtPnlTime.RowCount = 3;
            this.tbLtPnlTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLtPnlTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLtPnlTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbLtPnlTime.Size = new System.Drawing.Size(200, 154);
            this.tbLtPnlTime.TabIndex = 0;
            // 
            // btnLimparTime
            // 
            this.btnLimparTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimparTime.Location = new System.Drawing.Point(3, 127);
            this.btnLimparTime.Name = "btnLimparTime";
            this.btnLimparTime.Size = new System.Drawing.Size(194, 24);
            this.btnLimparTime.TabIndex = 0;
            this.btnLimparTime.Text = "btnLimparTime";
            this.btnLimparTime.UseVisualStyleBackColor = true;
            // 
            // lblTimeTitulo
            // 
            this.lblTimeTitulo.AutoSize = true;
            this.lblTimeTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTimeTitulo.Name = "lblTimeTitulo";
            this.lblTimeTitulo.Size = new System.Drawing.Size(194, 25);
            this.lblTimeTitulo.TabIndex = 1;
            this.lblTimeTitulo.Text = "lblTimeTitulo";
            this.lblTimeTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBxTime
            // 
            this.lstBxTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBxTime.FormattingEnabled = true;
            this.lstBxTime.Location = new System.Drawing.Point(3, 28);
            this.lstBxTime.Name = "lstBxTime";
            this.lstBxTime.Size = new System.Drawing.Size(194, 93);
            this.lstBxTime.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 440);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.pnlTimes.ResumeLayout(false);
            this.tbLtPnlTime.ResumeLayout(false);
            this.tbLtPnlTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel sttHora;
        private System.Windows.Forms.ToolStripStatusLabel sttData;
        private System.Windows.Forms.ToolStripProgressBar pgsbrProgresso;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemJogTime;
        private System.Windows.Forms.Button btnAddJogTime;
        private System.Windows.Forms.Button btnRemMaxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdeTimes;
        private System.Windows.Forms.Label lblQtdeJogadoresTimes;
        private System.Windows.Forms.Button btnAddMaxTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblJogadoresEspera;
        private System.Windows.Forms.ListBox lstBxJogEspera;
        private System.Windows.Forms.Label lblQtdeTotalJogadores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel pnlTimes;
        private System.Windows.Forms.TableLayoutPanel tbLtPnlTime;
        private System.Windows.Forms.Button btnLimparTime;
        private System.Windows.Forms.Label lblTimeTitulo;
        private System.Windows.Forms.ListBox lstBxTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnAdicionarJogador;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnGerarTimes;
        private System.Windows.Forms.Button btnLimparTimes;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Button btnComputarPartida;
        private System.Windows.Forms.Button btnRemoverPartida;
        private System.Windows.Forms.Button btnRemoverJogador;
        private System.Windows.Forms.Button btnTerminarPartida;
        private System.Windows.Forms.Button btnAddTimeMenorJogador;
    }
}

