﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class PlanetWroxEntities : DbContext
{
    public PlanetWroxEntities()
        : base("name=PlanetWroxEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Genre> Genres { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public virtual DbSet<PhotoAlbum> PhotoAlbums { get; set; }
    public virtual DbSet<Picture> Pictures { get; set; }
}
