﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class personNETEntities : DbContext
    {
        public personNETEntities()
            : base("name=personNETEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assoc_Core_Content> Assoc_Core_Content { get; set; }
        public virtual DbSet<Content_Access_Denial> Content_Access_Denial { get; set; }
        public virtual DbSet<Core_Access_Denial> Core_Access_Denial { get; set; }
        public virtual DbSet<TB_AdditionalData> TB_AdditionalData { get; set; }
        public virtual DbSet<TB_Admin> TB_Admin { get; set; }
        public virtual DbSet<TB_Content> TB_Content { get; set; }
        public virtual DbSet<TB_Core> TB_Core { get; set; }
        public virtual DbSet<TB_Genre> TB_Genre { get; set; }
        public virtual DbSet<TB_Keyword> TB_Keyword { get; set; }
        public virtual DbSet<TB_Notification> TB_Notification { get; set; }
        public virtual DbSet<TB_Photo> TB_Photo { get; set; }
        public virtual DbSet<TB_Text> TB_Text { get; set; }
        public virtual DbSet<TB_User> TB_User { get; set; }
        public virtual DbSet<TB_Video> TB_Video { get; set; }
    }
}
