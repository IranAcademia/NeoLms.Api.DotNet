using IranAcademiaChatBotServer.Agents.Academia.NeoLms;

var neoLmsClient = new NeoLmsClient("https://iranacademia.neolms.com", "ae4f660e6700d3e410df8a915759cf141a6767bb03fd40ed12f9");

//var aa = await neoLmsClient.GetAllUsers(1);
//var q = new Dictionary<string, object>();
//q.Add("userid", "MKalbi");

//var a = await neoLmsClient.GetLessonsForClass(3123251);
var b = await neoLmsClient.GetAllClassTemplates(0);
//var version = await neoLmsClient.GetVersion();
//Console.WriteLine(version.Version);

//var authenticationResult = await neoLmsClient.IsAuthenticated("EAr", "ctdl8598");
//Console.WriteLine(authenticationResult.IsAuthenticated);


//var users = await neoLmsClient.GetAllUsers(1);9882445

//Dictionary<string, object> resource_type = new Dictionary<string, object>();
//resource_type.Add("type", "File");

//var teachers = await neoLmsClient.GetClassesEnrolledBy(9882445);

Console.WriteLine("");