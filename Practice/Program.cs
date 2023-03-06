using Practice;

var mobcre = new MobilephoneCreator();
var telcre = new TelephoneCreator();

var cl1 = new[] {new Client(mobcre.FactoryMethod()), new Client(telcre.FactoryMethod())};

foreach (var v in cl1) v.Call();