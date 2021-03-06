﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JetDev.Cielo.Entidades
{
    public class Cancelamento
    {
        [XmlElement("codigo")]
        public string Codigo { get; set; }
        [XmlElement("mensagem")]
        public string Mensagem { get; set; }
        [XmlElement("data-hora")]
        public string DataHora { get; set; }
        [XmlElement("valor")]
        public string ValorString
        {
            get { return Utils.ConverteValorParaCielo(Valor); }
            set { Valor = Utils.ConverteValorDeCielo(value); }
        }
        [XmlIgnore]
        public decimal Valor { get; set; }
    }
}
