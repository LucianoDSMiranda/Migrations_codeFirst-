﻿using System;
using System.Collections.Generic;

namespace learn_migration.Infrastructure.DataModels
{
    public partial class TbInstituicao
    {
        public TbInstituicao()
        {
            TbInscritos = new HashSet<TbInscrito>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public virtual ICollection<TbInscrito> TbInscritos { get; set; }
    }
}
