//会社テーブルを作成
var companyClass = new List<JoinClass.CompanyNameTable>();
companyClass.Add(new JoinClass.CompanyNameTable
{
    Id = 1,
    CompanyName = "panasonic"
});
companyClass.Add(new JoinClass.CompanyNameTable
{
    Id = 2,
    CompanyName = "toshiba"
});

//ユーザーテーブルを作成
var userClass = new List<JoinClass.UserTable>();
userClass.Add(new JoinClass.UserTable
{
    Id = 1,
    CompanyId = 1,
    Password = "pass",
    UserName = "raito"
});
userClass.Add(new JoinClass.UserTable
{
    Id = 2,
    CompanyId = 2,
    Password = "test",
    UserName = "yamada"
});

//Linqを実施してみる