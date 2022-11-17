using tema.Directory;


User paul = new User("xPaul74", "1234", "stefanpaul31@gmail.com");
User joe = new User("OnuSike", "4321", "Igorj@gmail.cum");
User bib = new User("BibartBalutDiocletianAlexandru", "fowem34", "hindi@india.ch");
List<User> users = new List<User>() {paul, joe};

WebApplication app1 = new WebApplication("Facetagram", 2, users);
Console.WriteLine(app1.GetName());
MobileApplication app2 = new MobileApplication("Clash", 3, users);

List<Application> apps = new List<Application>();

apps.Add(app1);
apps.Add(app2);
Admin administrator = new Admin(Console.ReadLine(), apps);



return 0;