using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataHoraPadrao();
            //DataHoraAgora();
            //DataHoraDefinida();
            //DataHoraFormatada();
            //AdicionandoValoresData();
            //ComparacaoDatas();
            //Culture();
            //TimeZone();
            //TimeSpan();
            DiasMes();

        }

        static void DataHoraPadrao()
        {

            Console.Clear();

            //Mostra o valor padrão da estrutura DateTime, no caso 1/1/0001 12:00:00 AM
            var data = new DateTime();
            Console.WriteLine(data);
        }

        static void DataHoraAgora()
        {

            Console.Clear();

            //Mostra a data configurada na máquina.
            var data = DateTime.Now;
            Console.WriteLine(data);
        }

        static void DataHoraDefinida()
        {

            Console.Clear();

            //Mostra o valor definido de data e hora;
            var data = new DateTime(2022, 10, 12, 13, 23, 14);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }

        static void DataHoraFormatada()
        {

            Console.Clear();

            var data = DateTime.Now;

            //Formata da data da forma como foi definida. dd: dia, MM: Mês, yyyy: ano, hh: Hora, mm: minutos, ss: segundos
            var formatada = String.Format("{0:dd-MM-yyyy hh:mm:ss}", data);
            var formatada1 = String.Format("{0:D}", data);
            var formatada2 = String.Format("{0:f}", data);
            var formatada3 = String.Format("{0:g}", data);
            var formatada4 = String.Format("{0:y}", data);
            //Data padronizada, usado em muito sistemas tanto r quanto R.
            var formatada5 = String.Format("{0:r}", data);
            // Data padrão muito no mongo (sistema de banco de dados).
            var formatada6 = String.Format("{0:s}", data);
            // Data formatada para padrão universal. Usado em arquivos JSON.
            var formatada7 = String.Format("{0:u}", data);

            Console.WriteLine(formatada);
            Console.WriteLine(formatada1);
            Console.WriteLine(formatada2);
            Console.WriteLine(formatada3);
            Console.WriteLine(formatada4);
            Console.WriteLine(formatada5);
            Console.WriteLine(formatada6);
            Console.WriteLine(formatada7);
                
        }

        static void AdicionandoValoresData()
        {

            Console.Clear();

            var data = DateTime.Now;
            Console.WriteLine(data);

            Console.WriteLine(data.AddDays(12));

            Console.WriteLine(data.AddMonths(1));

        }

        static void ComparacaoDatas()
        {

            Console.Clear();

            var data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual!");
            }

            Console.WriteLine(data);
        }

        static void Culture()
        {

            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual =  CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));

        }

        static void TimeZone()
        {

            Console.Clear();

            var utcDate = DateTime.UtcNow;

            Console.WriteLine("Horário Local");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("Horário Global");
            Console.WriteLine(utcDate);
            Console.WriteLine();
            Console.WriteLine("Horário Local");
            Console.WriteLine(utcDate.ToLocalTime());
            Console.WriteLine();

            var timezoneaustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine("Horário na Australia");
            Console.WriteLine(timezoneaustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneaustralia);
            Console.WriteLine(horaAustralia);
            Console.WriteLine();

            // Listar todas as timezones registradas no sistema.
            var timezones = TimeZoneInfo.GetSystemTimeZones();

            Console.WriteLine("Timezones disponíveis:\n");
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("_____________");
            }

        }

        static void TimeSpan()
        {

            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanHoraMinutoSegundo);
            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        }

        static void DiasMes()
        {

            Console.Clear();

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            // Verifica se o dia é final de semana ou não usando o método IsWeekend criado.
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}


