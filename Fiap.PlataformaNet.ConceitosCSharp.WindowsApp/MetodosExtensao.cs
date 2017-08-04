using System;
using System.Text.RegularExpressions;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp
{
    public static class MetodosExtensao
    {
        public static string ValidarEmail(this string txt)
        {
            if (!Regex.IsMatch(txt, @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$"))
            {
                throw new Exception("Informe um e-mail valido");
            }

            return txt;
        }

        public static string RetirarAcentos(this string txt)
        {
            string com_Acentos = "ÄÀÁÂÃäàáâãËÈÉÊëèéêÏÌÍÎïìíîÖÒÓÔÕöòóôõÜÙÚÛüùúûÇçÑñ";
            string sem_Acentos = "AAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUUuuuuCcNn";

            for (int i = 0; i < com_Acentos.Length; i++)
            {
                txt = txt.Replace(com_Acentos[i], sem_Acentos[i]);
            }

            return txt;
        }
    }
}
