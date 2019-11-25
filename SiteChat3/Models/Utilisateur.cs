//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteChat3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilisateur()
        {
            this.Maintenance = new HashSet<Maintenance>();
            this.Message = new HashSet<Message>();
            this.Notification = new HashSet<Notification>();
            this.Notification1 = new HashSet<Notification>();
            this.UtilisateurDiscussion = new HashSet<UtilisateurDiscussion>();
        }
    
        public int IdUtilisateur { get; set; }
        
        public string NomUtilisateur { get; set; }
        [Required(ErrorMessage = "Le champ nom doit être rempli")]
        public string PrenomUtilisateur { get; set; }
        [Required(ErrorMessage = "Le champ prénom doit être rempli")]
        public string PseudoUtilisateur { get; set; }
        [Required(ErrorMessage = "Le champ pseudo doit être rempli")]
        public string EmailUtilisateur { get; set; }
        [Required(ErrorMessage = "Le champ email doit être rempli")]
        public System.DateTime DateDeNaissanceUtilisateur { get; set; }
        [Required(ErrorMessage = "vous devez renseigner votre date de naissance")]
        public string NumeroUtilisateur { get; set; }
        
        public string MotDePasseUtilisateur { get; set; }
        [Required(ErrorMessage = "choisissez un mot de passe")]
        public System.DateTime DateCreationUtilisateur { get; set; }
        
        public Nullable<int> IdAvatar { get; set; }
        public int IdAcces { get; set; }
        public Nullable<int> IdStatutUtilisateur { get; set; }
        public string TokenUtilisateur { get; set; }
    
        public virtual Acces Acces { get; set; }
        public virtual Avatar Avatar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance> Maintenance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Message { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notification1 { get; set; }
        public virtual StatutUtilisateur StatutUtilisateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UtilisateurDiscussion> UtilisateurDiscussion { get; set; }
    }
}
