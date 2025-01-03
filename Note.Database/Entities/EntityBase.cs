﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TookKit.Mvvm.Bindings;

namespace Note.Database.Entities
{
    public abstract partial class EntityBase:ObservableObject
    {
        private int id;
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//自动递增
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }
        private DateTime insertDate=DateTime.Now;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertDate
        {
            get { return insertDate; }
            set { SetProperty(ref insertDate, value); }
        }

    }
}
