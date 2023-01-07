using System;
using System.Globalization;

namespace DateFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            // var date = new DateTime(2020, 10, 12, 8, 23, 14);
            // var date = DateTime.Now;

            /*Data sem timezone (quando nao se faz umna aplicação somente para um pais,
             mas como o facebook, por exemplo)

             Nesse caso, publicações ficariam com o horário UTC no servidor mas na tela do front-end
             seria convertido para o culture info do usuário utilizando o comando date.ToLocalTime()
            */
            var date = DateTime.UtcNow;

            //Criar um Date time como null
            // DateTime? date = null;

            Console.WriteLine(date);

            //TimesSpan
            /*
            Formato de contador de tempo
            */
            var timeSpan = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpan.Add(new TimeSpan(0,2,59)));

            /*
             Nesse caso, publicações ficariam com o horário UTC no servidor mas na tela do front-end
             seria convertido para o culture info da maquina utilizando o comando date.ToLocalDateTime()
            */
            // Console.WriteLine(date.ToLocalTime());
            /*
            CASE UTC
            Para converter para o timezone NÃO da MAQUINA, mas do USUÁRIO
            Ex:Minha maquina ta nos EUA mas meu user é da austrália.
            */
            // var timeZoneHawai = TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time");
            // Console.WriteLine(timeZoneHawai);
            // var horaHwai = TimeZoneInfo.ConvertTimeFromUtc(date, timeZoneHawai);
            // Console.WriteLine("Time zone Hawai: "+horaHwai);

            /*
            Para verificar todos os timezones, execute o código abaixo:
            */
            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(date, timezone));
            //     Console.WriteLine("-----------");
            // }

            //Formatando datas com ToString e escolhendo globalização
            // Console.WriteLine(date.ToString("D", atual));

            //O if abaixo nunca vai funcionar pois DateTime.Now pega até as fraçoes de segundo
            // if (date == DateTime.Now)
            // {
            //     Console.WriteLine("Datas iguais");
            // }

            // //O if abaixo pode ser comparado
            // //Pode se usar todas as comparações normais... como <,>,<>,>=, etc...
            // if (date.Date == DateTime.Now.Date)
            // {
            //     Console.WriteLine("Datas iguais 2");
            // }

            //AddDays
            // Console.WriteLine(date.AddDays(25));
            //AddMonth
            // Console.WriteLine(date.AddMonths(-1));
            //OBS: A função DaysInMonth traz a quantidade de dias de um certo mes
            //OBS: A função IsWeekDay retorna true se for final de semana (sabado ou domingo)
            //OBS: A função IsDaylightSavingTime diz se está em horário de verão

            //ff é fração de segundo e z é zone time... No Brasil é -3 (a maior parte do pais)
            // Console.WriteLine(String.Format("{0:yyyy/MM/dd hh:mm:ss }", date));
            //Short patern horário -> t
            // Console.WriteLine(String.Format("{0:t}", date));
            // //Short patern data -> d
            // Console.WriteLine(String.Format("{0:d}", date));
            // //Long patern horário -> T
            // Console.WriteLine(String.Format("{0:T}", date));
            // //Long patern data -> D
            // Console.WriteLine(String.Format("{0:D}", date));
            // //Short patern data e horário -> g
            // Console.WriteLine(String.Format("{0:g}", date));
            //Patern -> r
            // Console.WriteLine(String.Format("{0:r}", date));
            // //Patern usado em alguns sistemas -> R
            // Console.WriteLine(String.Format("{0:R}", date));
            // //Patern sortible... Usado em tipos JSON para converter para o frontend e em banco de dados -> s
            // Console.WriteLine(String.Format("{0:s}", date));
            // //Patern universal -> u
            // Console.WriteLine(String.Format("{0:u}", date));

            //O DayOfWeek é um enumerador... Pode trazer o dia da semana em ingles
            // Console.WriteLine(date.DayOfWeek);
            //Ou pode ser convertido para numero do enumerador
            // Console.WriteLine((int)date.DayOfWeek);
        }
    }
}
