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
var ret = companyClass.Join(
                   userClass,//ここで結合するテーブルを選択する。
                   companycls => companycls.Id,//ここで結合元テーブルの結合データを選択する。
                   usercls => usercls.CompanyId,//ここで結合先テーブルの結合データを選択する。
                   (company, user) => new//ここで欲しい情報を選択して新しいクラスを生成する。
                   {
                       CompanyName = company.CompanyName,
                       UserName = user.UserName
                   });
//結果表示
foreach(var data in ret)
{
    Console.WriteLine($"{data.CompanyName}の{data.UserName}");
}