//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TB_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_User()
        {
            this.Content_Access_Denial = new HashSet<Content_Access_Denial>();
            this.Core_Access_Denial = new HashSet<Core_Access_Denial>();
            this.TB_Content = new HashSet<TB_Content>();
            this.TB_Core = new HashSet<TB_Core>();
            this.TB_AdditionalData = new HashSet<TB_AdditionalData>();
            this.TB_Notification = new HashSet<TB_Notification>();
        }
    
        public int IdUser { get; set; }

        [Display(Name="Nome")]
        [Required(ErrorMessage = "Seu nome � obrigat�rio.")]
        [MaxLength(128, ErrorMessage = "Seu nome deve possuir at� 128 caracteres.")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Seu e-mail � obrigat�rio.")]
        [MaxLength(128, ErrorMessage = "Seu e-mail deve possuir at� 128 caracteres.")]
        public string E_mail { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Sua senha � obrigat�ria.")]
        [MaxLength(512, ErrorMessage = "Sua senha deve possuir at� 512 caracteres.")]
        public string Pass { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string DirProfilePhoto { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Sua data de nascimento � obrigat�ria.")]
        public System.DateTime BirthDate { get; set; }

        [Display(Name = "�ltimo acesso em: ")]
        public Nullable<System.DateTime> LastAccess { get; set; }

        [Display(Name = "Acesso Premium")]
        public bool HasPremiumAccess { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Content_Access_Denial> Content_Access_Denial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Core_Access_Denial> Core_Access_Denial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Content> TB_Content { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Core> TB_Core { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_AdditionalData> TB_AdditionalData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Notification> TB_Notification { get; set; }
    }
}
