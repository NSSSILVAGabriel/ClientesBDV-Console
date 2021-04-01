using System;
using System.IO;

namespace BDV
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis 1,2, e 99 contém 10 tuplas, para receber os dados do arquivo LEGCA.TXT


            //criar o objeto para abrir o arquivo
            var arquivo = File.ReadAllLines("..\\LEGCCA.TXT");
            //abrir o arquuivo para leitura]
            foreach (var linha in arquivo)
            {
                //ler 1 linha
                //separar a linha
                //imprimir a linha formartada
                //voltar para o loop opnde leio mais uma linha

                //string linha = "01;36545802895;andre oliveira;F;20210101;99991231";

                string [] linhaSeparada = linha.Split(";");

                if (linhaSeparada[0].Equals("01"))

                {
                    Console.WriteLine($"`CPF/CNPJ: {linhaSeparada[1]} - N2 : {linhaSeparada[2]} - Descrição e domínio : {linhaSeparada[3]}");
                }
                        
                if (linhaSeparada[0].Equals("02"))
                {
                    Console.WriteLine($"`Tipo do Registro: {linhaSeparada[1]} - N2 : {linhaSeparada[2]} - Descrição e domínio : {linhaSeparada[3]}");                   

                }


                if (linhaSeparada[0].Equals("99"))
                {
                    Console.WriteLine($"`Número de registros: {linhaSeparada[1]} - N2 : {linhaSeparada[2]}");

                }

            }
            


            //var Registro1 = Tuple <string, string, string, string, string, string, string, string, string, string>("Tipo do Registro: ", "CNPJ da Instituição: ", "Código do Sistema: ", "Código do BDV: ", "Data Movimento ", , , , , );
            //var Registro2 = Tuple<string, string, string, string, string, string, string, string, string, string>("Tipo do Registro: ", "Tipo Pessoa: ", "CNPJCPFPessoa: ", "NomePessoa: ", "DtInicio ", "DtFim ", "TpVinc: ", "Agencia: ", "Conta: ", "Saldo: ");
            //var Registro99 = Tuple<string, string, string, string, string, string, string, string, string, string>("Tipo do Registro: ", "Número de Registros: ", , , , , , , , );
            
            //Console.ReadLine = File.ReadAllText("..\\LEGCCA.TXT");

            //Console.WriteLine(Arquivo,Registro1,Registro2,Registro99);

        }
    }
}
