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
 
        public static String RetornoComando(string comandoEnviado)
        {
            if (comandoEnviado.Contains("jarvis"))
            {
                return "Olá chefe, o que deseja?";
            }
            else if (comandoEnviado.Contains("comandos"))
            {
                return "1 Jarvis\r\n2 que horas são\r\n3 que dia é hoje\r\n4 abra o navegador\r\n5 abra o youtube\r\n6 abra o aurera\r\n7 abra o word\r\n8 abra o excel\r\n9 abra o power point\r\n10 abra o whatsapp\r\n11 abra o visual studio\r\n12 abra as noticias nacionais\r\n13 abra o r7\r\n14 abra as noticias de maringá\r\n15 abra a cotação das ações\r\n16 abra o projudi\r\n17 abra o instagram\r\n18 abra o outlook\r\n19 abra o facebook\r\n20 abra o gmail\r\n21 abra o gameloop\r\n22 abra o sound\r\n23 abra o linkedin\r\n24 abra o netflix\r\n25 abra o prime\r\n26 abra o trello\r\n27 abra a amazon\r\n28 abra o stackoverflow\r\n29 abra o starplus\r\n30 abra o disneyplus\r\n31 abra o booking\r\n32 abra o tiktok\r\n33 abra o bitdefender\r\n34 desligar\r\n35 abra o github\r\n36 abra o proton\r\n37 abra o maps\r\n38 abra o discord\r\n39 abra o calendário\r\n40 abra o meet\r\n";
            }
            else if (comandoEnviado.Contains("horas"))
            {
                return "Agora são: " + DateTime.Now.ToShortTimeString() + "";
            }
            else if (comandoEnviado.Contains("hoje"))
            {
                return "Hoje é: " + DateTime.Now.ToLongDateString() + "";
            }
            else if (comandoEnviado.Contains("navegador"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://google.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("youtube"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://youtube.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("aurera"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://aurera-global.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("word"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("excel"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("powerpoint"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("whatsapp"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://web.whatsapp.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("visual studio"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("noticias nacionais"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://globo.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("r7"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://r7.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("noticias de maringá"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://gmconline.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("cotação"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.b3.com.br/pt_br/market-data-e-indices/servicos-de-dados/market-data/cotacoes/", UseShellExecute = true });

            }
            else if (comandoEnviado.Contains("projudi"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://projudi.tjpr.jus.br/projudi/", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("instagram"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://instagram.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("outlook"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://outlook.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("facebook"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://facebook.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("gmail"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://gmail.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("gameloop"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\TxGameAssistant\AppMarket\AppMarket.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("sound"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"C:\Program Files\FxSound LLC\FxSound\FxSound.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("linkedin"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://linkedin.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("netflix"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://netflix.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("prime"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://primevideo.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("trello"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://trello.com/w/inventivaapps", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("amazon"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://amazon.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("stackoverflow"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://pt.stackoverflow.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("starplus"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.starplus.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("disneyplus"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.disneyplus.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("booking"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://booking.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("tiktok"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://tiktok.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("bitdefender"))
            {
                Process.Start(new ProcessStartInfo {FileName = @"C:\Program Files\Bitdefender\Bitdefender Security\seccenter.exe", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("desligar"))
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "shutdown.exe";
                psi.Arguments = "-s -f -t 0";
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
            }
            else if (comandoEnviado.Contains("github"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://github.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("proton"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://proton.me", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("maps"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://www.google.com.br/maps", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("discord"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://discordapp.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("calendário"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://calendar.google.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("meet"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://meet.google.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("onedrive"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://onedrive.live.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("magazine"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://magazineluiza.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("inventiva"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://inventivaapps.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("heavy"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://heavyhost.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("microsoft"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://microsoft.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("apple"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://apple.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("shoppe"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://shoppe.com", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("telegram"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://web.telegram.org/k/", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("gov"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://gov.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("twitch"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://twitch.tv", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("kabum"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://kabum.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("netshoes"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://netshoes.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("centauro"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://centauro.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("muffato"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://supermufatto.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("condor"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://condor.com.br", UseShellExecute = true });
            }
            else if (comandoEnviado.Contains("canção"))
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://cancao.com", UseShellExecute = true });
            }
            return "Ok";
        }
    }
}
