using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToJoinTest
{
    /// <summary>
    /// 会社名テーブル
    /// </summary>
    public class CompanyNameTable
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
    }

    /// <summary>
    /// ユーザーテーブル
    /// </summary>
    public class UserTable
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string CompanyId { get; set; }
    }
}
