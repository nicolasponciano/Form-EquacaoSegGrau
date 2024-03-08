using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03_PROJETO_03
{
    class EqSegundoGrauBLL
    {
        public static void ValidarDados(EqSegundoGrau umaEquacao)
        {
            Erro.TemErro = false;

            if (umaEquacao.A.Length == 0)
            {
                Erro.Mensagem = "O campo A é obrigatório!";
                return;
            }
            else
            {
                try
                {
                    float.Parse(umaEquacao.A);
                }
                catch
                {
                    Erro.Mensagem = "O campo A deve ser Númerico!";
                    return;
                }
                if (float.Parse(umaEquacao.A) <= 0)
                {
                    Erro.Mensagem = "O campo A deve ser maior que 0 !";
                    return;
                }

                if (umaEquacao.B.Length == 0)
                {
                    Erro.Mensagem = "O campo B é obrigatório!";
                    return;
                }
                else
                {
                    try
                    {
                        float.Parse(umaEquacao.B);
                    }
                    catch
                    {
                        Erro.Mensagem = "O campo B deve ser Númerico!";
                        return;
                    }
                    if (float.Parse(umaEquacao.B) <= 0)
                    {
                        Erro.Mensagem = "O campo B deve ser maior que 0 !";
                        return;
                    }
                    if (umaEquacao.C.Length == 0)
                    {
                        Erro.Mensagem = "O campo C é obrigatório!";
                        return;
                    }
                    else
                    {
                        try
                        {
                            float.Parse(umaEquacao.C);
                        }
                        catch
                        {
                            Erro.Mensagem = "O campo C deve ser Númerico!";
                            return;
                        }
                        if (float.Parse(umaEquacao.C) <= 0)
                        {
                            Erro.Mensagem = "O campo C deve ser maior que 0 !";
                            return;
                        }
                    }
                }
            }
        }
    }
}

