using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Atividade.Models
{
    public class Dados
    {
       [JsonPropertyName("slip")]
        public Slip Slip {get;set;}
    }
    public class Slip
    {
        [JsonPropertyName("advice")]
        public string Conselho { get; set; }
    }
}