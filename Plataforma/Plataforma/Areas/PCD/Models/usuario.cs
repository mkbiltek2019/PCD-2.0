//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plataforma.Areas.PCD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.comentarios = new HashSet<comentario>();
            this.documentos_profe = new HashSet<documentos_profe>();
            this.log_visitas = new HashSet<log_visitas>();
            this.log_visitas_cursousuario = new HashSet<log_visitas_cursousuario>();
            this.log_visitas_documentousuario = new HashSet<log_visitas_documentousuario>();
            this.respuestas = new HashSet<respuesta>();
            this.colegios = new HashSet<colegio>();
            this.cursos = new HashSet<curso>();
            this.libros = new HashSet<libro>();
            this.niveles = new HashSet<nivele>();
            this.permisos = new HashSet<permiso>();
            this.roles = new HashSet<role>();
            this.grupos = new HashSet<grupos>();
            this.documentos_usuario = new HashSet<documentos_usuario>();
            this.transacciones = new HashSet<transaccione>();
            this.carritoes = new HashSet<carrito>();
            this.ventas = new HashSet<venta>();
        }
    
        public int id { get; set; }
        [Required(ErrorMessage = "Ingresa un nombre para el usuario")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Ingresa los apellidos para el usuario")]
        public string apellidos { get; set; }
        [Required(ErrorMessage = "Ingresa un nombre de usuario para el usuario")]
        public string username { get; set; }
        [MinLength(6, ErrorMessage = "La contrase�a debe contener al menos 6 caracteres")]
        [Required(ErrorMessage = "Ingresa una contase�a para el usuario")]
        public string password { get; set; }
        [Required(ErrorMessage = "Ingresa al menos un n�mero de tel�fono para el usuario")]
        public Nullable<int> telefono { get; set; }
        public Nullable<int> telefono_2 { get; set; }
        [Required(ErrorMessage = "Ingresa al menos un correo electr�nico para el usuario")]
        public string correo { get; set; }
        public string correo_2 { get; set; }
        public string informacion_opcional { get; set; }
        public Nullable<System.DateTime> fecha_primer_ingreso { get; set; }
        public Nullable<bool> bloqueado { get; set; }
        public Nullable<bool> logueado { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public Nullable<int> categoria_precio { get; set; }
        public Nullable<decimal> saldo { get; set; }
        public Nullable<long> id_gp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comentario> comentarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentos_profe> documentos_profe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_visitas> log_visitas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_visitas_cursousuario> log_visitas_cursousuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<log_visitas_documentousuario> log_visitas_documentousuario { get; set; }
        public virtual notificacione notificacione { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respuesta> respuestas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colegio> colegios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> cursos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<libro> libros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nivele> niveles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permiso> permisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<role> roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grupos> grupos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentos_usuario> documentos_usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaccione> transacciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carrito> carritoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> ventas { get; set; }
    }
}
