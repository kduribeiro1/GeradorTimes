using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorTimes
{
    public class Jogadores
    {
        public int QtdeMaxTimes { get; set; }
        public int QtdeMaxJogadores { get; set; }
        public List<Jogador> Lista { get; set; }

        public List<int?> Times 
        { 
            get
            {
                try
                {
                    if (Lista == null)
                    {
                        return new List<int?>();
                    }
                    else
                    {
                        if (!Lista.Any())
                        {
                            return new List<int?>();
                        }
                        else
                        {
                            if (!Lista.Where(x => x.Time != null).Any())
                            {
                                return new List<int?>();
                            }
                            else
                            {
                                return Lista.Where(x => x.Time != null).Select(p => p.Time).Distinct().ToList();
                            }
                        }
                    }
                }
                catch 
                { 
                    return new List<int?>();
                }
            }
        }


        public Jogadores() 
        {
            Lista = new List<Jogador>();
            QtdeMaxJogadores = 0;
            QtdeMaxTimes = 0;
        }

        public Jogadores(List<Jogador> lista, int qtdemaxjogadores = 0, int qtdemaxtimes = 0)
        {
            Lista = lista;
            QtdeMaxJogadores = qtdemaxjogadores;
            QtdeMaxTimes = qtdemaxtimes;
        }

        public List<Jogador> PuxarTime(int? time)
        {
            try
            {
                if (Lista.Where(p => p.Time == time).Any())
                {
                    return Lista.Where(p => p.Time == time).ToList();
                }
                else
                {
                    return new List<Jogador>();
                }
            }
            catch 
            { 
                return new List<Jogador>();
            }
        }

        public List<List<Jogador>> PuxarTimes()
        {
            List<List<Jogador>> times = new List<List<Jogador>>();
            if (QtdeMaxTimes > 0)
            {
                for(int i = 0; i < QtdeMaxTimes; i++)
                {
                    List<Jogador> jogadores = new List<Jogador>();
                    if (Lista.Where(p => p.Time == i).Any())
                    {
                        jogadores = Lista.Where(p => p.Time == i).ToList();
                    }
                    times.Add(jogadores);
                }
            }
            return times;
        }

        public void AddTime()
        {
            QtdeMaxTimes++;
        }

        public void RemTime(int? id = null)
        {
            if (id == null)
            {
                if (QtdeMaxTimes >= 1)
                {
                    int qtdeTimes = Times.Count;
                    QtdeMaxTimes--;
                    if (qtdeTimes > QtdeMaxTimes)
                    {
                        int qtde = Lista.Count;
                        for (int i = 0; i < qtde; i++)
                        {
                            if (Lista[i].Time >= QtdeMaxTimes)
                            {
                                Lista[i].UnsetTime();
                            }
                        }
                    }
                }
            }
            else
            {
                List<int?> times = Times.OrderBy(p => p).ToList();
                int? idMax = times.Last();
                if (times.Contains(id))
                {
                    if (id == idMax)
                    {
                        int qtde = Lista.Count;
                        for(int i = 0; i < qtde; i++)
                        {
                            if (Lista[i].Time == id)
                            {
                                Lista[i].UnsetTime();
                            }
                        }
                    }
                    else
                    {
                        int qtde = Lista.Count;
                        for (int i = 0; i < qtde; i++)
                        {
                            if (Lista[i].Time == id)
                            {
                                Lista[i].UnsetTime();
                            }
                            else if (Lista[i].Time > id)
                            {
                                Lista[i].AjustaTime(Lista[i].Time - 1);
                            }
                        }
                    }
                }
            }
        }
        
        public void AddQtdeJogadores()
        {
            QtdeMaxJogadores++;
        }

        public void RemQtdeJogadores()
        {
            if (QtdeMaxJogadores >= 1) 
            {
                QtdeMaxJogadores--;
                int qtde = Times.Count;
                if (qtde > 0)
                {
                    for (int i = 0; i < qtde; i++)
                    {
                        List<Jogador> jogadores = Lista.Where(p => p.Time == i).ToList();
                        if (jogadores.Count > QtdeMaxJogadores)
                        {
                            jogadores = jogadores.OrderBy(d => d.DataHora).ToList();
                            while(jogadores.Count > QtdeMaxJogadores)
                            {
                                Jogador player = jogadores.Last();
                                int qtdeJ = Lista.Count;
                                for(int j = 0; j < qtdeJ; j++)
                                {
                                    if (Lista[j].Nome == player.Nome)
                                    {
                                        Lista[j].UnsetTime();
                                        jogadores = Lista.Where(p => p.Time == i).ToList();
                                        if (jogadores.Count > QtdeMaxJogadores)
                                        {
                                            jogadores = jogadores.OrderBy(d => d.DataHora).ToList();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void AddNovoJogador(string jogador)
        {
            if (!Lista.Where(p => p.Nome == jogador).Any())
            {
                Lista.Add(new Jogador(jogador));
            }
        }

        public void RemJogador(Jogador jogador)
        {
            if (Lista.Where(p => p.Nome == jogador.Nome).Any())
            {
                List<Jogador> lista = Lista.Where(p => p.Nome == jogador.Nome).ToList();
                foreach (var jog in lista)
                {
                    Lista.Remove(jogador);
                }
            }
        }

        public int QtdeJogadores
        {
            get 
            {
                try
                {
                    return Lista.Count;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public Jogador ReturnJogador(string nome)
        {
            try
            {
                Jogador jogador = Lista.First(p => p.Nome == nome);
                return jogador;
            }
            catch
            {
                return null;
            }
        }

        public void SetTimeJogador(string jogador, int? time)
        {
            int qtdeJogador = Lista.Count;
            if (time != null)
            {
                if (PuxarTime(time).Count < QtdeMaxJogadores) 
                {
                    for (int i = 0; i < qtdeJogador; i++)
                    {
                        if (Lista[i].Nome == jogador)
                        {
                            Lista[i].SetTime(time);
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Esse time já possui a quantidade máxima de jogadores.", Program.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                for (int i = 0; i < qtdeJogador; i++)
                {
                    if (Lista[i].Nome == jogador)
                    {
                        Lista[i].UnsetTime();
                    }
                }
            }
        }

        public void UnsetTimeJogador(string jogador)
        {
            int qtdeJogador = Lista.Count;
            for(int i = 0; i < qtdeJogador; i++)
            {
                if (Lista[i].Nome == jogador)
                {
                    Lista[i].UnsetTime();
                }
            }
        }

        public void FimPartida(bool manterTime = false)
        {
            int qtde = Lista.Count;
            for(int i = 0; i < qtde;i++)
            {
                if (Lista[i].Time != null)
                {
                    Lista[i].FimPartida(manterTime);
                }
            }
        }

        public void LimparTime(int? time)
        {
            int qtde = Lista.Count;
            if (qtde > 0) 
            {
                if (time != null)
                {
                    if (Lista.Where(p => p.Time == time).Any())
                    {
                        for (int i = 0; i < qtde; i++)
                        {
                            if (Lista[i].Time == time)
                            {
                                Lista[i].UnsetTime();
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < qtde; i++)
                    {
                        if (Lista[i].Time != null)
                        {
                            Lista[i].UnsetTime();
                        }
                    }
                }
            }
        }

        public void GerarTimeAleatorio()
        {
            if (QtdeMaxTimes > 0)
            {
                bool timesCompletos = false;
                List<TimeVal> listTimes = new List<TimeVal>();
                for(int i = 0; i < QtdeMaxTimes; i++)
                {
                    int qtde = 0;
                    if (PuxarTime(i).Any())
                    {
                        qtde = PuxarTime(i).Count();
                    }
                    if (qtde > QtdeMaxJogadores)
                    {
                        List<Jogador> jogadores = Lista.Where(p => p.Time == i).ToList();
                        if (jogadores.Count > QtdeMaxJogadores)
                        {
                            jogadores = jogadores.OrderBy(d => d.DataHora).ToList();
                            while (jogadores.Count > QtdeJogadores)
                            {
                                Jogador player = jogadores.Last();
                                int qtdeJ = Lista.Count;
                                for (int j = 0; j < jogadores.Count; j++)
                                {
                                    if (Lista[j].Nome == player.Nome)
                                    {
                                        Lista[j].UnsetTime();
                                        jogadores = Lista.Where(p => p.Time == i).ToList();
                                        if (jogadores.Count > QtdeMaxJogadores)
                                        {
                                            jogadores = jogadores.OrderBy(d => d.DataHora).ToList();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    listTimes.Add(new TimeVal(i, qtde, qtde == QtdeMaxJogadores));
                }
                if (listTimes.Count > 1)
                {
                    listTimes = listTimes.OrderBy(p => p.Qtde).ToList();
                }
                timesCompletos = !listTimes.Where(p => p.Completo == false).Any();
                if (!timesCompletos)
                {
                    List<Jogador> emEspera = PuxarTime(null);
                    if (emEspera.Count > 0)
                    {
                        for(int i = 0; i < QtdeMaxJogadores; i++)
                        {
                            if (listTimes.Where(p => p.Qtde == i).Any() && emEspera.Count >= 1)
                            {
                                List<TimeVal> timesAjustar = listTimes.Where(p => p.Qtde == i).ToList();
                                foreach (TimeVal t in timesAjustar)
                                {
                                    if (emEspera.Count > 1)
                                    {
                                        Random random = new Random();
                                        int idxJ = random.Next(0, emEspera.Count);
                                        while (idxJ >= emEspera.Count)
                                        {
                                            idxJ = random.Next(-1, emEspera.Count);
                                        }
                                        Jogador jogador = emEspera[idxJ];
                                        if (jogador != null)
                                        {
                                            int qtdeLista = Lista.Count;
                                            for(int j = 0; j < qtdeLista; j++)
                                            {
                                                if (Lista[j].Nome == jogador.Nome)
                                                {
                                                    Lista[j].SetTime(t.Id);
                                                    int qtdeTimesLista = listTimes.Count;
                                                    for(int k = 0; k < qtdeTimesLista; k++)
                                                    {
                                                        if (listTimes[k].Id == t.Id)
                                                        {
                                                            listTimes[k].Qtde++;
                                                            break;
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        emEspera = PuxarTime(null);
                                    }
                                    else if (emEspera.Count == 1)
                                    {
                                        Jogador jogador = emEspera[0];
                                        if (jogador != null)
                                        {
                                            int qtdeLista = Lista.Count;
                                            for (int j = 0; j < qtdeLista; j++)
                                            {
                                                if (Lista[j].Nome == jogador.Nome)
                                                {
                                                    Lista[j].SetTime(t.Id);
                                                    int qtdeTimesLista = listTimes.Count;
                                                    for (int k = 0; k < qtdeTimesLista; k++)
                                                    {
                                                        if (listTimes[k].Id == t.Id)
                                                        {
                                                            listTimes[k].Qtde++;
                                                            break;
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        emEspera = PuxarTime(null);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void AddJogadorTimeMenor(string jogador)
        {
            if (QtdeMaxTimes > 0)
            {
                List<TimeVal> listTimes = new List<TimeVal>();
                for (int i = 0; i < QtdeMaxTimes; i++)
                {
                    int qtde = 0;
                    if (PuxarTime(i).Any())
                    {
                        qtde = PuxarTime(i).Count();
                    }
                    if (qtde < QtdeMaxJogadores)
                    {
                        listTimes.Add(new TimeVal(i, qtde, qtde == QtdeMaxJogadores));
                    }
                }
                if (listTimes.Count > 0)
                {
                    if (listTimes.Count > 1)
                    {
                        listTimes = listTimes.OrderBy(p => p.Qtde).ToList();
                    }
                    SetTimeJogador(jogador, listTimes[0].Id);
                }
            }
        }

        public void ComputarPartidaJogador(string jogador)
        {
            int qtde = Lista.Count;
            for (int i = 0; i < qtde; i++)
            {
                if (Lista[i].Nome == jogador)
                {
                    Lista[i].AddPartida();
                }
            }
        }

        public void RemoverPartidaJogador(string jogador)
        {
            int qtde = Lista.Count;
            for (int i = 0; i < qtde; i++)
            {
                if (Lista[i].Nome == jogador)
                {
                    Lista[i].RemPartida();
                }
            }
        }
    }

    public class TimeVal
    {
        public int? Id { get; set; }
        public int Qtde { get; set; }
        public bool Completo { get; set; }

        public TimeVal(int? id, int qtde, bool completo)
        {
            Id = id;
            Qtde = qtde;
            Completo = completo;
        }
    }

    public class Jogador 
    {
        public string Nome { get; set; }
        public int QtdePartidas { get; set; }
        public int? Time { get; set; }
        public DateTime? DataHora { get; set; }

        public string NomeQtde
        {
            get
            {
                try
                {
                    return $"{Nome} ({QtdePartidas})";
                }
                catch
                {
                    return $"{Nome} (0)";
                }
            }
        }

        public Jogador()
        {
            QtdePartidas = 0;
            Time = null;
            DataHora = null;
        }

        public Jogador(string nome, int qtde = 0, int? time = null)
        {
            Nome = nome;
            QtdePartidas = qtde;
            Time = time;
            if (time != null)
            {
                DataHora = DateTime.Now;
            }
            else
            {
                DataHora = null;
            }
        }

        public void AddPartida()
        {
            QtdePartidas++;
        }

        public void RemPartida()
        {
            if (QtdePartidas > 0)
            {
                QtdePartidas--;
            }
        }

        public void SetTime(int? time)
        {
            Time = time;
            if (time != null)
            {
                DataHora = DateTime.Now;
            }
            else
            {
                DataHora = null;
            }

        }
        
        public void AjustaTime(int? time)
        {
            Time = time;
        }

        public void UnsetTime()
        {
            Time = null;
            DataHora = null;
        }

        public void FimPartida(bool manterTime = false)
        {
            QtdePartidas++;
            if (!manterTime)
            {
                Time = null;
                DataHora = null;
            }
        }
    }
}
