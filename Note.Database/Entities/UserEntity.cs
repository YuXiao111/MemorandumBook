using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Database.Entities
{
    [Table(nameof(UserEntity))]
    public class UserEntity : EntityBase
    {
        private string userName = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }


        private string passWord = string.Empty;
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            get { return passWord; }
            set { SetProperty(ref passWord, value); }
        }

        private int role;
        /// <summary>
        /// 角色，0表示超级管理员
        /// </summary>
        public int Role
        {
            get { return role; }
            set { SetProperty(ref role, value); }
        }
    }
}
