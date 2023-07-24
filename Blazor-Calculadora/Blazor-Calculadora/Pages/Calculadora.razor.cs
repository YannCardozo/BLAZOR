using System;
using System.Collections.Generic;
using System.Data;
using Blazor_Calculadora.Base.PageBase;

namespace Blazor_Calculadora.Pages
{
    public class CalculadoraBack : PageBase
    {
        public string input = "";
        public string result = null;
        public bool mostralista = false;
        public List<string> historicoContas = new List<string>();


        public void AppendNumber(int number)
        {

            input += number.ToString();
        }

        public void AppendOperator(char op)
        {
            input += " " + op + " ";
        }

        public void AppendDecimal()
        {
            if (!input.Contains("."))
                input += ".";
        }

        public void Clear()
        {
            input = "";
            result = "";
            //mostralista = true;
        }

        public void Calculate()
        {
            try
            {
                result = new DataTable().Compute(input, null).ToString();
                string resultado = new DataTable().Compute(input, null).ToString();
                if (resultado != "")
                {
                    historicoContas.Insert(0, $"{input} = {resultado}");
                }
                if (historicoContas.Count > 10)
                {
                    historicoContas.RemoveAt(historicoContas.Count - 1);
                }
                input = result;
                if (input != "")
                {
                    mostralista = true;
                }

            }
            catch (Exception)
            {
                result = "Error"; // Handle invalid input or calculation error
            }
        }
        public void DeletaLista()
        {
            result = "";
            historicoContas.Clear();
            mostralista = false;
        }
    }
}
