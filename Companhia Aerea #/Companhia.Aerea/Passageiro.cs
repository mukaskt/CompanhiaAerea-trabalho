using System;
using System.Text;

namespace Companhia.Aerea
{
    /// <summary>
    /// Classe que representa os passageiros do projeto, armazena e processa as informações sobre o passageiro
    /// </summary>
    public class Passageiro
    {
        #region [+] Atributos e propriedades

        /// <summary>
        /// CPF do passageiro
        /// </summary>
        public int CPF { get; set; }

        /// <summary>
        /// Nome do passageiro
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sobrenome do passageiro
        /// </summary>
        public string Sobrenome { get; set; }

        /// <summary>
        /// Endereço do passageiro
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Telefone do passageiro
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Número da passagem do passageiro no Voo
        /// </summary>
        public int NumeroPassagem { get; set; }

        /// <summary>
        /// Número do voo do passageiro
        /// </summary>
        public int NumeroVoo { get; set; }

        /// <summary>
        /// Número da poltrona do passageiro
        /// </summary>
        public int? NumeroPoltrona { get; set; }

        /// <summary>
        /// Data e horário do passageiro
        /// </summary>
        public DateTime HorarioVoo { get; set; }

        #endregion

        #region [+] Métodos

        /// <summary>
        /// Retorna
        /// </summary>
        /// <param name="passageiro"></param>
        /// <returns></returns>
        public StringBuilder RetornarDadosPassageiro()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendLine("\n-----> Dados do passageiro\n");

            texto.AppendFormat("\tNome: {0} {1}\n", Nome, Sobrenome);
            texto.AppendFormat("\tCPF: {0}\n", CPF.ToString().PadLeft(11, '0'));
            texto.AppendFormat("\tEndereço: {0}\n", Endereco);
            texto.AppendFormat("\tNúmero da passagem: {0}\n", NumeroPassagem);
            texto.AppendFormat("\tNúmero da poltrona: {0}\n", NumeroPoltrona);

            return texto;
        }

        #endregion
    }
}