﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace CNCliente.Models
{
    public partial class cae
    {
        public cae()
        {
            cliente = new HashSet<cliente>();
        }

        public int caeId { get; set; }
        public string caeCodigo { get; set; }
        public string caeNome { get; set; }

        public virtual ICollection<cliente> cliente { get; set; }
    }
}