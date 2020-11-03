using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            DefuncionesRelateduser = new HashSet<Defunciones>();
            DefuncionesWitness = new HashSet<Defunciones>();
            MatrimoniosRelateduser1 = new HashSet<Matrimonios>();
            MatrimoniosRelateduser2 = new HashSet<Matrimonios>();
            MatrimoniosWitness = new HashSet<Matrimonios>();
            NacimientosDad = new HashSet<Nacimientos>();
            NacimientosMom = new HashSet<Nacimientos>();
            NacimientosRelateduser = new HashSet<Nacimientos>();
            NacimientosWitness = new HashSet<Nacimientos>();
        }

        [System.ComponentModel.DisplayName("DOCUMENTO")]
        public string Id { get; set; }

        [System.ComponentModel.DisplayName("TIPO DE DOCUMENTO")]
        public int DoctypeId { get; set; }
        
        [System.ComponentModel.DisplayName("NOMBRES")]
        public string Name { get; set; }
        
        [System.ComponentModel.DisplayName("APELLIDOS")]
        public string Surname { get; set; }
        
        [System.ComponentModel.DisplayName("LUGAR DE EXPEDICIÓN")]
        public string ExpeditionPlace { get; set; }
        
        [System.ComponentModel.DisplayName("FECHA DE EXPEDICIÓN")]
        public DateTime? ExpeditionDate { get; set; }
        
        [System.ComponentModel.DisplayName("FECHA DE NACIMIENTO")]
        public DateTime BirthDate { get; set; }

        public virtual Doctypes Doctype { get; set; }
        public virtual Notarios Notarios { get; set; }

        public virtual ICollection<Defunciones> DefuncionesRelateduser { get; set; }
        public virtual ICollection<Defunciones> DefuncionesWitness { get; set; }
        public virtual ICollection<Matrimonios> MatrimoniosRelateduser1 { get; set; }
        public virtual ICollection<Matrimonios> MatrimoniosRelateduser2 { get; set; }
        public virtual ICollection<Matrimonios> MatrimoniosWitness { get; set; }
        public virtual ICollection<Nacimientos> NacimientosDad { get; set; }
        public virtual ICollection<Nacimientos> NacimientosMom { get; set; }
        public virtual ICollection<Nacimientos> NacimientosRelateduser { get; set; }
        public virtual ICollection<Nacimientos> NacimientosWitness { get; set; }
    }
}
