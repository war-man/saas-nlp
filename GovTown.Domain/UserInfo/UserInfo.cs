//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using GovTown.Core.Domain.DeptInfos;
using GovTown.Core.Domain.RoleInfos;
using System.ComponentModel.DataAnnotations.Schema;

namespace GovTown.Core.Domain.UserInfos
{
    [DataContract]
    public partial class UserInfo : BaseEntity
    {
        public UserInfo() {
            Page = 0;
            PageSize = 20;
        }
        public UserInfo(string userName,string password,string name)
        {
            this.UserName = UserName;
            this.Password = password;
            this.Name = name;
        }

        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int DeptId { get; set; }//����
        [DataMember]
        public string Job { get; set; } //ְ��
        [DataMember]
        public string Phone { get; set; }//�ֻ�
        [DataMember]
        public string Telephone { get; set; } //�����绰
        [DataMember]
        public string Email { get; set; } //����
        [DataMember]
        public int Role { get; set; }//��ɫ


        //public List<DeptInfo> DeptList { get; set; }
        [Column("DeptId")]
        [ForeignKey("DeptId")]
        public virtual DeptInfo DeptList { get; set; }


        [Column("Role")]
        [ForeignKey("Role")]
        public virtual RoleInfo RoleList { get; set; }

        [NotMapped]
        public string code { get; set; } //��֤��
        [NotMapped]
        public int Page { get; set; } //��ǰҳ��
        [NotMapped]
        public int PageSize { get; set; } //ҳ��С
    }
}