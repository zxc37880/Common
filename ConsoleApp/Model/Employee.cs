using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    public class Employee
    {
        public int Id { get; set; }

        /// <summary>
        /// UserName
        /// </summary> 
        public string UserName { get; set; }

        /// <summary>
        /// UserName
        /// </summary> 
        public string UserID { get; set; }

        /// <summary>
        /// UserName
        /// </summary> 
        public string Email { get; set; }

        /// <summary>
        /// UserName
        /// </summary> 
        public string Password { get; set; }

        /// <summary>
        /// EngName
        /// </summary> 
        public string EngName { get; set; }

        /// <summary>
        /// 使用者級別:'L'為leader，'E'為一般人員, 'A'為助理
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Remark(目前是暫時用來放和PM負責的簽約的品項，可參考 ProductInfo)
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 部門
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 分公司
        /// </summary>
        public string BranchCompany { get; set; } = "0";

        /// <summary>
        /// 使用者的toke-預留
        /// </summary>
        public string Token { get; set; }
    }
}
