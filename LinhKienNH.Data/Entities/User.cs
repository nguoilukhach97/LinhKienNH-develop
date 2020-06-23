using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.Entities
{
    public class User
    {
        public int Id {get;set;}
        public string UserName {get;set;}
        public string PassWord  {get;set;}
        public int GroupId{get;set;}
        public string FullName {get;set;}
        public string Email {get;set;}
        public string PhoneNumber{get;set;}
        public string Address {get;set;}
        public string Image {get;set;}
        public Status Status {get;set;}
    }
}
