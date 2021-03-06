﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Client.Model
{
    /// <summary>
    /// 数据模型 - 数据 的上下文
    /// </summary>
    public class Model2DataContext : DbContext
    {
        #region 属性

        /// <summary>
        /// 聊天信息的数据存储区
        /// </summary>
        public DbSet<Message> PondOfMessage { get; set; }

        /// <summary>
        /// 图片的数据存储区
        /// </summary>
        public DbSet<Picture> PondOfPicture { get; set; }

        /// <summary>
        /// Ip/实际地址对照的数据存储区
        /// </summary>
        public DbSet<IpToAddress> PondOfIpToAddress { get; set; }

        #endregion

        #region 重写契约

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().ToTable("client_message");
            modelBuilder.Entity<Message>().HasKey(x => x.Id);

            modelBuilder.Entity<Picture>().ToTable("client_picture");
            modelBuilder.Entity<Picture>().HasKey(x => x.Id);

            modelBuilder.Entity<IpToAddress>().ToTable("client_ipToAddressr");
            modelBuilder.Entity<IpToAddress>().HasKey(x => x.Id);
        }

        #endregion
    }
}
