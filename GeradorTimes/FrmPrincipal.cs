using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorTimes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text = Program.AssemblyTitle;
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizaLabelQtdeJogadoresTimes();
            AtualizaLabelQtdeMaxTimes();
            pnlTimes.Controls.Clear();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            sttHora.Text = agora.ToString("T");
            sttData.Text = agora.ToString("D");
        }

        private void AtualizaLabelQtdeJogadores()
        {
            lblQtdeTotalJogadores.Text = $"Total Jog.: {Program.Jogadores.QtdeJogadores}";
        }

        private void AtualizaLabelQtdeMaxTimes()
        {
            int qtde = Program.Jogadores.QtdeMaxTimes;
            lblQtdeTimes.Text = qtde.ToString();
            if (qtde > 0)
            {
                btnRemMaxTime.Enabled = true;
            }
            else
            {
                btnRemMaxTime.Enabled = false;
            }
        }

        private void AtualizaLabelQtdeJogadoresTimes()
        {
            int qtde = Program.Jogadores.QtdeMaxJogadores;
            lblQtdeJogadoresTimes.Text = qtde.ToString();
            if (qtde > 0)
            {
                btnRemJogTime.Enabled = true;
            }
            else
            {
                btnRemJogTime.Enabled = false;
            }
        }

        private void AtualizaJogadoresEspera()
        {
            List<Jogador> timeEspera = Program.Jogadores.PuxarTime(null);
            lblJogadoresEspera.Text = $"Jogadores Em Espera ({timeEspera.Count})";
            lstBxJogEspera.Items.Clear();
            if (timeEspera.Count > 0 )
            {
                foreach(var jog in timeEspera)
                {
                    lstBxJogEspera.Items.Add(jog);
                }
            }
        }

        public void AtualizarListaTimes()
        {
            pnlTimes.Controls.Clear();
            for (int i = (Program.Jogadores.QtdeMaxTimes - 1); i >= 0; i--)
            {
                TableLayoutPanelTime tableLayout = new TableLayoutPanelTime(i);
                tableLayout.OnRefreshTimes += AtualizarListaTimes;
                tableLayout.OnRefreshJogadoresEspera += AtualizaJogadoresEspera;
                pnlTimes.Controls.Add(tableLayout);
            }
            foreach(TableLayoutPanelTime tableLayout in pnlTimes.Controls)
            {
                tableLayout.RefreshList();
            }
        }

        private void BtnAddMaxTime_Click(object sender, EventArgs e)
        {
            Program.Jogadores.AddTime();
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizaLabelQtdeJogadoresTimes();
            AtualizaLabelQtdeMaxTimes();
            AtualizarListaTimes();
        }

        private void BtnRemMaxTime_Click(object sender, EventArgs e)
        {
            Program.Jogadores.RemTime();
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizaLabelQtdeJogadoresTimes();
            AtualizaLabelQtdeMaxTimes();
            AtualizarListaTimes();
        }

        private void BtnAddJogTime_Click(object sender, EventArgs e)
        {
            Program.Jogadores.AddQtdeJogadores();
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizaLabelQtdeJogadoresTimes();
            AtualizaLabelQtdeMaxTimes();
            AtualizarListaTimes();
        }

        private void BtnRemJogTime_Click(object sender, EventArgs e)
        {
            Program.Jogadores.RemQtdeJogadores();
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizaLabelQtdeJogadoresTimes();
            AtualizaLabelQtdeMaxTimes();
            AtualizarListaTimes();
        }



        private void BtnAdicionarJogador_Click(object sender, EventArgs e)
        {
            if (txtNomeJogador.Text.Trim() != "")
            {
                Program.Jogadores.AddNovoJogador(txtNomeJogador.Text.Trim());
                txtNomeJogador.Text = "";
                txtNomeJogador.Focus();
                AtualizaJogadoresEspera();
                AtualizaLabelQtdeJogadores();
            }
        }

        private void TxtNomeJogador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (txtNomeJogador.Text.Trim() != "")
                {
                    Program.Jogadores.AddNovoJogador(txtNomeJogador.Text.Trim());
                    txtNomeJogador.Text = "";
                    txtNomeJogador.Focus();
                    AtualizaJogadoresEspera();
                    AtualizaLabelQtdeJogadores();
                }
            }
        }

        private void BtnGerarTimes_Click(object sender, EventArgs e)
        {
            if (Program.Jogadores.Lista.Where(p => p.Time != null).Any())
            {
                var resultbox = MessageBox.Show("Deseja limpar todos os times antes de gerar?", Program.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultbox == DialogResult.Yes)
                {
                    Program.Jogadores.GerarTimeAleatorio();
                    AtualizaJogadoresEspera();
                    AtualizarListaTimes();
                }
                else if (resultbox == DialogResult.No)
                {
                    Program.Jogadores.GerarTimeAleatorio();
                    AtualizaJogadoresEspera();
                    AtualizarListaTimes();
                }
            }
            else
            {
                Program.Jogadores.GerarTimeAleatorio();
                AtualizaJogadoresEspera();
                AtualizarListaTimes();
            }
        }

        private void BtnLimparTimes_Click(object sender, EventArgs e)
        {
            var resultbox = MessageBox.Show("Deseja limpar todos os times e computar uma partida para cada jogador?", Program.AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultbox == DialogResult.Yes)
            {
                Program.Jogadores.FimPartida(false);
                AtualizaJogadoresEspera();
                AtualizarListaTimes();
            }
            else if (resultbox == DialogResult.No)
            {
                Program.Jogadores.LimparTime(null);
                AtualizaJogadoresEspera();
                AtualizarListaTimes();
            }
        }

        private void BtnLimparTudo_Click(object sender, EventArgs e)
        {
            Program.Jogadores.Lista.Clear();
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizaLabelQtdeJogadoresTimes();
            AtualizaLabelQtdeMaxTimes();
            AtualizarListaTimes();
        }

        private void LstBxJogEspera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstBxJogEspera.SelectedItem != null)
            {
                try
                {
                    Jogador jogador = lstBxJogEspera.SelectedItem as Jogador;
                    if (MessageBox.Show($"Deseja remover o jogador '{jogador.Nome}'?", Program.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int qtde = Program.Jogadores.QtdeJogadores;
                        if (qtde > 0)
                        {
                            Program.Jogadores.Lista.Remove(jogador);
                        }
                        AtualizaJogadoresEspera();
                        AtualizaLabelQtdeJogadores();
                        AtualizarListaTimes();
                    }
                }
                catch { }
            }
        }

        private void BtnComputarPartida_Click(object sender, EventArgs e)
        {
            if (lstBxJogEspera.SelectedItem != null)
            {
                try
                {
                    Jogador jogador = lstBxJogEspera.SelectedItem as Jogador;
                    Program.Jogadores.ComputarPartidaJogador(jogador.Nome);
                    AtualizaJogadoresEspera();
                    lstBxJogEspera.SelectedItem = jogador;
                }
                catch { }
            }
        }

        private void BtnRemoverPartida_Click(object sender, EventArgs e)
        {
            if (lstBxJogEspera.SelectedItem != null)
            {
                try
                {
                    Jogador jogador = lstBxJogEspera.SelectedItem as Jogador;
                    Program.Jogadores.RemoverPartidaJogador(jogador.Nome);
                    AtualizaJogadoresEspera();
                    lstBxJogEspera.SelectedItem = jogador;
                }
                catch { }
            }
        }

        private void LstBxJogEspera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxJogEspera.SelectedItem != null)
            {
                btnComputarPartida.Enabled = true;
                btnRemoverPartida.Enabled = true;
                btnAddTimeMenorJogador.Enabled = true;
                btnRemoverJogador.Enabled = true;
            }
            else
            {
                btnComputarPartida.Enabled = false;
                btnRemoverPartida.Enabled = false;
                btnAddTimeMenorJogador.Enabled = false;
                btnRemoverJogador.Enabled = false;
            }
        }

        private void BtnRemoverJogador_Click(object sender, EventArgs e)
        {
            if (lstBxJogEspera.SelectedItem != null)
            {
                try
                {
                    Jogador jogador = lstBxJogEspera.SelectedItem as Jogador;
                    if (MessageBox.Show($"Deseja remover o jogador '{jogador.Nome}'?", Program.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int qtde = Program.Jogadores.QtdeJogadores;
                        if (qtde > 0)
                        {
                            Program.Jogadores.Lista.Remove(jogador);
                        }
                        AtualizaJogadoresEspera();
                        AtualizaLabelQtdeJogadores();
                        AtualizarListaTimes();

                        lstBxJogEspera.SelectedIndex = -1;
                        btnComputarPartida.Enabled = false;
                        btnRemoverPartida.Enabled = false;
                        btnAddTimeMenorJogador.Enabled = false;
                        btnRemoverJogador.Enabled = false;
                    }
                }
                catch { }
            }
        }

        private void BtnAddTimeMenorJogador_Click(object sender, EventArgs e)
        {
            if (lstBxJogEspera.SelectedItem != null)
            {
                try
                {
                    Jogador jogador = lstBxJogEspera.SelectedItem as Jogador;
                    Program.Jogadores.AddJogadorTimeMenor(jogador.Nome);
                    AtualizaJogadoresEspera();
                    AtualizaLabelQtdeJogadores();
                    AtualizarListaTimes();
                    lstBxJogEspera.SelectedIndex = -1;
                    btnComputarPartida.Enabled = false;
                    btnRemoverPartida.Enabled = false;
                    btnAddTimeMenorJogador.Enabled = false;
                    btnRemoverJogador.Enabled = false;
                }
                catch { }
            }
        }

        private void BtnTerminarPartida_Click(object sender, EventArgs e)
        {
            bool resultbox = MessageBox.Show("Deseja manter os times?", Program.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            Program.Jogadores.FimPartida(resultbox);
            AtualizaJogadoresEspera();
            AtualizaLabelQtdeJogadores();
            AtualizarListaTimes();
        }

        bool mouseDown = false;

        private void LstBxJogEspera_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void LstBxJogEspera_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (lstBxJogEspera.SelectedItem != null)
            {
                btnComputarPartida.Enabled = true;
                btnRemoverPartida.Enabled = true;
                btnAddTimeMenorJogador.Enabled = true;
                btnRemoverJogador.Enabled = true;
            }
            else
            {
                btnComputarPartida.Enabled = false;
                btnRemoverPartida.Enabled = false;
                btnAddTimeMenorJogador.Enabled = false;
                btnRemoverJogador.Enabled = false;
            }
        }

        private void LstBxJogEspera_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseDown = false;
                int indexOfItem = lstBxJogEspera.IndexFromPoint(e.X, e.Y);
                if (indexOfItem >= 0 && indexOfItem < lstBxJogEspera.Items.Count)  // check we clicked down on a string
                {
                    Jogador jogador = lstBxJogEspera.Items[indexOfItem] as Jogador;
                    lstBxJogEspera.DoDragDrop(jogador.Nome, DragDropEffects.Copy);
                }
            }
        }

        private void LstBxJogEspera_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy || e.AllowedEffect == DragDropEffects.Move))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void LstBxJogEspera_DragOver(object sender, DragEventArgs e)
        {
            int indexOfItemUnderMouseToDrop = lstBxJogEspera.IndexFromPoint(lstBxJogEspera.PointToClient(new Point(e.X, e.Y)));
            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                lstBxJogEspera.SelectedIndex = indexOfItemUnderMouseToDrop;
            }
            else
            {
                lstBxJogEspera.SelectedIndex = indexOfItemUnderMouseToDrop;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                Jogador jogador = Program.Jogadores.ReturnJogador((string)e.Data.GetData(DataFormats.Text));
                lstBxJogEspera.Items.Remove(jogador);
            }
        }

        private void LstBxJogEspera_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                Program.Jogadores.UnsetTimeJogador((string)e.Data.GetData(DataFormats.Text));
                AtualizaJogadoresEspera();
                AtualizarListaTimes();
            }
        }

        private void LstBxJogEspera_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnComputarPartida.Enabled = false;
            btnRemoverPartida.Enabled = false;
            btnAddTimeMenorJogador.Enabled = false;
            btnRemoverJogador.Enabled = false;
        }
    }
}
