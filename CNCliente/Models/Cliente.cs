﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace CNCliente.Models
{
    public partial class cliente
    {
        public cliente()
        {
            projeto = new HashSet<projeto>();
        }

        public int clienteId { get; set; }
        public string clienteErpid { get; set; }
        public string clienteNipc { get; set; }
        public string clienteNome { get; set; }
        public string clienteEmail { get; set; }
        public string clienteTelefone { get; set; }
        public int? dimensao_Id { get; set; }
        public int? regiao_Id { get; set; }
        public int? setor_Id { get; set; }
        public int? cae_Id { get; set; }
        public int? codpostal_Id { get; set; }
        public int? distrito_Id { get; set; }
        public int? concelho_Id { get; set; }

        public virtual cae cae { get; set; }
        public virtual codpostal codpostal { get; set; }
        public virtual concelho concelho { get; set; }
        public virtual dimensao dimensao { get; set; }
        public virtual distrito distrito { get; set; }
        public virtual regiao regiao { get; set; }
        public virtual setor setor { get; set; }
        public virtual ICollection<projeto> projeto { get; set; }
    }
}