using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorTimes
{
    public class TableLayoutPanelTime : TableLayoutPanel
    {
        public event Action OnRefreshTimes;
        public event Action OnRefreshJogadoresEspera;

        public int? Id { get; set; }
        public Label LblTituloTime = new Label()
        {
            Dock = DockStyle.Fill,
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        };
        public Button BtnLimparTime = new Button()
        {
            Dock = DockStyle.Fill,
            Text = "Limpar Time"
        };
        public ListBox ListaTime = new ListBox()
        {
            Dock = DockStyle.Fill,
            ValueMember = "Nome",
            DisplayMember = "NomeQtde",
            AllowDrop = true
        };

        public TableLayoutPanelTime(int? id)
        {
            Id = id;
            this.Width = 200;
            this.Dock = DockStyle.Left;
            this.Controls.Clear();
            this.ColumnStyles.Clear();
            this.ColumnCount = 1;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            this.RowStyles.Clear();
            this.RowCount = 3;
            this.ListaTime.KeyDown += ListaTime_KeyDown;
            this.ListaTime.MouseDown += ListaTime_MouseDown;
            this.ListaTime.MouseUp += ListaTime_MouseUp;
            this.ListaTime.MouseMove += ListaTime_MouseMove;
            this.ListaTime.DragEnter += ListaTime_DragEnter;
            this.ListaTime.DragOver += ListaTime_DragOver;
            this.ListaTime.DragDrop += ListaTime_DragDrop;
            this.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            this.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            this.Controls.Add(this.LblTituloTime, 0, 0);
            this.Controls.Add(this.ListaTime, 0, 1);
            this.Controls.Add(this.BtnLimparTime, 0, 2);
            this.BtnLimparTime.Click += BtnLimparTime_Click;
            RefreshList();
        }

        private void BtnLimparTime_Click(object sender, EventArgs e)
        {
            Program.Jogadores.LimparTime(Id);
            OnRefreshJogadoresEspera?.Invoke();
            OnRefreshTimes?.Invoke();
        }

        public void RefreshList()
        {
            this.ListaTime.Items.Clear();
            List<Jogador> jogadores = Program.Jogadores.PuxarTime(Id);
            int qtde = jogadores.Count;
            if (qtde > 0)
            {
                jogadores = jogadores.OrderBy(p => p.DataHora).ToList();
                for (int i = 0; i < qtde; i++)
                {
                    this.ListaTime.Items.Add(jogadores[i]);
                }
            }
            this.LblTituloTime.Text = $"Time {Id} ({qtde})";
        }

        private void ListaTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && this.ListaTime.SelectedItem != null)
            {
                try
                {
                    Jogador nomejogador = this.ListaTime.SelectedItem as Jogador;
                    int qtde = Program.Jogadores.QtdeJogadores;
                    if (qtde > 0) 
                    { 
                        for(int i = 0; i < qtde; i++)
                        {
                            if (Program.Jogadores.Lista[i].Nome == nomejogador.Nome)
                            {
                                Program.Jogadores.Lista[i].UnsetTime();
                            }
                        }
                    }
                    RefreshList();
                    OnRefreshJogadoresEspera?.Invoke();
                }
                catch { }
            }
        }

        bool mouseDown = false;

        private void ListaTime_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void ListaTime_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ListaTime_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseDown = false;
                int indexOfItem = this.ListaTime.IndexFromPoint(e.X, e.Y);
                if (indexOfItem >= 0 && indexOfItem < this.ListaTime.Items.Count)  // check we clicked down on a string
                {
                    Jogador jogador = this.ListaTime.Items[indexOfItem] as Jogador;
                    this.ListaTime.DoDragDrop(jogador.Nome, DragDropEffects.Copy);
                }
            }
        }

        private void ListaTime_DragEnter(object sender, DragEventArgs e)
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

        private void ListaTime_DragOver(object sender, DragEventArgs e)
        {
            int indexOfItemUnderMouseToDrop = this.ListaTime.IndexFromPoint(this.ListaTime.PointToClient(new Point(e.X, e.Y)));
            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                this.ListaTime.SelectedIndex = indexOfItemUnderMouseToDrop;
            }
            else
            {
                this.ListaTime.SelectedIndex = indexOfItemUnderMouseToDrop;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                Jogador jogador = Program.Jogadores.ReturnJogador((string)e.Data.GetData(DataFormats.Text));
                this.ListaTime.Items.Remove(jogador);
            }
        }

        private void ListaTime_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                Program.Jogadores.SetTimeJogador((string)e.Data.GetData(DataFormats.Text), Id);
                OnRefreshJogadoresEspera?.Invoke();
                OnRefreshTimes?.Invoke();
            }
        }
    }
}
