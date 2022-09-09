using Kordamine;

/*Koer koer = new Koer(Koer.toug.pudel, "Šarik", "punane", Koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Pudel");
veelkoer.muudaVarv("rohaline");
veelkoer.muudaKaal(31);
veelkoer.muudaVanus(5);
veelkoer.print_Info();*/

Papagoi papagoi_odin = new Papagoi(Papagoi.tougP.Ara, "Bobik", "must", Koduloom.sugu.emane, 2.1, 1, false);
Papagoi papagoi_dva = new Papagoi(Papagoi.tougP.Jaco, "Samolet", "valge", Koduloom.sugu.emane, 3.1, 1, true);
Papagoi papagoi_tri = new Papagoi(Papagoi.tougP.Kakaduu, "Vertalet", "kollane", Koduloom.sugu.emane, 4.1, 1, true);

papagoi_odin.print_Info();
papagoi_odin.print_Haal();
Console.WriteLine(papagoi_odin.print_Info());

List<Koduloom> Kooduloom = new List<Koduloom>();
Kooduloom.Add(papagoi_odin);
Kooduloom.Add(papagoi_dva);
Kooduloom.Add(papagoi_tri);
Console.WriteLine("\n");

StreamWriter text = new StreamWriter(@"..\..\..\info.txt", false);
foreach (Koduloom x in Kooduloom)
{
    text.WriteLine(x.nimi + "," + x.varv + "," + x.vanus);
}
text.Close();

List<Papagoi> papagoi = new List<Papagoi>();
StreamReader sw = new StreamReader(@"..\..\..\info.txt");
string texts;
while ((texts = sw.ReadLine()) != null)
{
    string[] rida = texts.Split(',');
    papagoi.Add(new Papagoi(rida[0], rida[1]));
}
sw.Close();

foreach (var item in papagoi)
{
    Console.WriteLine(item.nimi + " " + item.varv);
}
Console.ReadLine();



/*string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "info.txt");
using(StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("--Koer--\n");
    sw.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", koer.Toug,koer.nimi,koer.varv,koer.loomaSugu,koer.kaal,koer.vanus);

    sw.WriteLine("\n--Papagoi--\n");
    sw.WriteLine("{0} {1} {2} ta on {3} ja tema kaal on {4} ja ta on {5} aastat vana", papagoi.Toug, papagoi.nimi, papagoi.varv, papagoi.loomaSugu, papagoi.kaal, papagoi.vanus);
}*/
