using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace learn_migration.Infrastructure.DataModels
{
    public partial class TbJogador
    {
        public TbJogador()
        {
            TbInscritos = new HashSet<TbInscrito>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;        
        public DateTime? DataNasc { get; set; }

        [JsonIgnore]
        public virtual ICollection<TbInscrito> TbInscritos { get; set; }
    }
}
