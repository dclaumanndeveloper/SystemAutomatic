using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAutomatic.Comands
{
    public class Commands
    {
        public static List<String> Comandos;

        public static List<String>  GetCommands()
        {
            Comandos = new List<String>();
            Comandos.Add("Jarvis");
            return Comandos;
        }
        public static String RetornoComando(string comandoEnviado)
        {
            if (comandoEnviado.Contains("Jarvis"))
            {
                return "Olá chefe, o que deseja?";
            }
            else if (comandoEnviado.Contains("que horas são"))
            {
                return "Agora são: " + DateTime.Now.ToShortTimeString() + "";
            }
            else if (comandoEnviado.Contains("que dia é hoje"))
            {
                return "Hoje é: " + DateTime.Now.ToLongDateString() + "";
            }
            else if (comandoEnviado.Contains("abra o navegador"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://google.com", UseShellExecute = true });

            }
            else if (comandoEnviado.Contains("abra o youtube"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://youtube.com", UseShellExecute = true });
                Process.Start(new ProcessStartInfo { FileName = @"C:\", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o aurera"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://aurera-global.com", UseShellExecute = true });
                Process.Start(new ProcessStartInfo { FileName = @"C:\", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o word"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o excel"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o power point"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o whatsapp"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://web.whatsapp.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o visual studio"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra as noticias nacionais"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://globo.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o r7"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://r7.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra as noticias de maringá"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://gmconline.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra a cotação das ações"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.b3.com.br/pt_br/market-data-e-indices/servicos-de-dados/market-data/cotacoes/", UseShellExecute = true });

            }
            else if (comandoEnviado.Contains("abra o projudi"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://projudi.tjpr.jus.br/projudi/", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o instagram"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://instagram.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o outlook"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://outlook.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o facebook"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://facebook.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o gmail"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://gmail.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o gameloop"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\TxGameAssistant\AppMarket\AppMarket.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o sound"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\FxSound LLC\FxSound\FxSound.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o linkedin"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://linkedin.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o netflix"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://netflix.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o prime"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://primevideo.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o trello"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://trello.com/w/inventivaapps", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra a amazon"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://amazon.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o stackoverflow"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://pt.stackoverflow.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o starplus"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.starplus.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o disneyplus"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.disneyplus.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o booking"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://booking.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o tiktok"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://tiktok.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o bitdefender"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Bitdefender\Bitdefender Security\seccenter.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o obs"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\obs-studio\bin\64bit\obs64.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o github"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://github.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o proton"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://proton.me", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("abra o maps"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.google.com.br/maps", UseShellExecute = true });
            }
            return "Ok";
            
            
        }
    }
}
