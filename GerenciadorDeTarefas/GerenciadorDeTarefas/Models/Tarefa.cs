using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }  //vai ser a foreign key
        public string Nome { get; set; }
        public DateTime DataPrevistaConclusao { get; set; }
        public DateTime? DataConclusao { get; set; }   // ? quer dizer q la no banco de dados a DataConclusao pode ser nula 

        [JsonIgnore]
        [ForeignKey("IdUsuario")]
        public virtual Usuario usuario { get; private set; }  
    }
}
