﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2019
{
    public class Snacks : Producto
    {
        public Snacks(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {

        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine((string)this);
            sb.AppendLine(String.Format("CALORIAS : {0}", this.CantidadCalorias));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
