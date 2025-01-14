﻿using Otorez.Models.ORM.Entity.SuperUserModels;
using Otorez.Models.ORM.Entity.HomeModels;
using Otorez.Models.ORM.Entity.AdminModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Otorez.Models.ORM.Context.ProjectContext
{
    public class ProjectContext : DbContext
    {


        public ProjectContext()
        {
           
            Database.Connection.ConnectionString = @"Server=; DataBase=Otorez; User Id=; Password=;";
        }

        //Home
        public virtual DbSet<Registration> Registration { get; set; }

        public virtual DbSet<ContactForm> ContactForm { get; set; }

        public virtual DbSet<Newsletter> Newsletter { get; set; }


        //Admin
        public virtual DbSet<Account> Account { get; set; }

        public virtual DbSet<Reservation> Reservation { get; set; }

        public virtual DbSet<Room> Room { get; set; }

        public virtual DbSet<Service> Service { get; set; }

        public virtual DbSet<ServicePurchase> ServicePurchase { get; set; }

        public virtual DbSet<Kbs> Kbs { get; set; }


        //SuperUser
        public virtual DbSet<SuperUser> SuperUser { get; set; }


    }
}