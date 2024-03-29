﻿namespace Pergunta_4
{
    public class Calculo
    {
        public double jurosDia = 0.03;
        public double multaFixa = 2.00;
        public double valueJuros;
        public double valueMulta;

        public double Calcular(double valorBoleto, DateTime vencimento, DateTime pagamento)
        {
            var verif = VerificarDias(pagamento, vencimento);

            var result = VerificaFeriado(vencimento);
            var result2 = VerificaFeriado(vencimento.AddDays(1));
            var verifcarFinalSemana2 = VerificaFinalDeSemana(vencimento.AddDays(1));
            var verifcarFinalSemana = VerificaFinalDeSemana(vencimento);
            var dia = (int)vencimento.DayOfWeek;
            var pag = pagamento - vencimento;

            if (result == true || verifcarFinalSemana == true)
            {

                if (dia == 6 && pag.Days <= 2)
                {
                    valueJuros = 0;
                    valueMulta = 0;
                    return valorBoleto;
                }
                else if (result == true && dia == 5 && verifcarFinalSemana2 == true && pag.Days <= 3)
                {
                    valueJuros = 0;
                    valueMulta = 0;
                    return valorBoleto;
                }
                else if (dia != 6 && pag.Days >= 2)
                {
                    valueJuros = jurosDia * pag.Days;
                    valueMulta = multaFixa;
                    return valorBoleto + multaFixa + (jurosDia * (pag.Days));
                }
                else if (result == true && result2 == false && verifcarFinalSemana2 == false)
                {
                    valueJuros = 0;
                    valueMulta = 0;
                    return valorBoleto;
                }
                else if (result == true && pag.Days >= 2)
                {
                    valueJuros = jurosDia * pag.Days;
                    valueMulta = multaFixa;
                    return valorBoleto + multaFixa + (jurosDia * (pag.Days));
                }
            }
            else if (result == false && verifcarFinalSemana == false && verif >= 1)
            {
                valueJuros = jurosDia * pag.Days;
                valueMulta = multaFixa;
                return valorBoleto + multaFixa + (jurosDia * (verif));
            }
            else if (verifcarFinalSemana == true && verif < 2)
            {
                valueJuros = 0;
                valueMulta = 0;
                return valorBoleto;
            }

            valueJuros = 0;
            valueMulta = 0;
            return valorBoleto;


        }
        public int VerificarDias(DateTime vencimento, DateTime pagamento)
        {
            var result = vencimento - pagamento;
            return result.Days;
        }

        public bool VerificaFeriado(DateTime checkDate)
        {
            DateTime dateToBeChecked = new DateTime(checkDate.Year, checkDate.Month, checkDate.Day);
            int anoCheckDate = checkDate.Year;
            int a = (int)anoCheckDate % 4;
            int b = (int)anoCheckDate % 7;
            int c = (int)anoCheckDate % 19;
            int d = (int)((19 * c) + 24) % 30;
            int e = (int)((2 * a) + (4 * b) + (6 * d) + 5) % 7;
            int diaPascoa = 22 + d + e;
            int mesPascoa = 3;
            if (diaPascoa > 31)
            {
                diaPascoa = d + e - 9;
                mesPascoa = 4;
            }
            List<String> feriados = new List<String>();
            feriados.Add(new DateTime(anoCheckDate, mesPascoa, diaPascoa).ToString()); //Pascoa
            feriados.Add(new DateTime(anoCheckDate, mesPascoa, diaPascoa).AddDays(-2).ToString()); //Sexta Feira da Paixão
            feriados.Add(new DateTime(anoCheckDate, mesPascoa, diaPascoa).AddDays(60).ToString()); //Corpus Cristi
                                                                                                   //feriados.Add(new DateTime(checkDate.Year, mesPascoa, diaPascoa).AddDays(-47).ToString()); //Carnaval
            feriados.Add(new DateTime(anoCheckDate, 1, 1).ToString()); //Dia de Ano Novo (Confraternização Universal)
            feriados.Add(new DateTime(anoCheckDate, 4, 21).ToString()); //Dia de Tiradentes
            feriados.Add(new DateTime(anoCheckDate, 5, 1).ToString()); //Dia do Trabalho
            feriados.Add(new DateTime(anoCheckDate, 9, 7).ToString()); //Dia da Independência
            feriados.Add(new DateTime(anoCheckDate, 10, 12).ToString()); //Dia da Padroeira do Brasil
            feriados.Add(new DateTime(anoCheckDate, 11, 2).ToString()); //Dia de Finados
            feriados.Add(new DateTime(anoCheckDate, 11, 15).ToString()); //Data da Proclamação da República
            feriados.Add(new DateTime(anoCheckDate, 12, 25).ToString()); //Natal
            return feriados.Contains(dateToBeChecked.ToString());
        }

        public bool VerificaFinalDeSemana(DateTime date)
        {
            var data = (int)date.DayOfWeek;
            if (data == 6 || data == 0)
            {
                return true;
            }
            return false;
        }
    }
}
