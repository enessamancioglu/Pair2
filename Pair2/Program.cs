
int columb;

while (true)//girilen kolon sayisi kontrol edildi
{
    Console.WriteLine("How much columb will you play?");
   // columb = int.Parse(Console.ReadLine());

    if (int.TryParse(Console.ReadLine(), out columb) && columb >= 1 && columb <= 8)
    {

        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a value between 1 and 8:");
        

    }

}
  

Random randomSayi = new Random();//random sayi fonksiyonu cagrildi

int[] kolonSayisi = new int[6];


for (int i = 0; i < columb; i++)//kolon sayisi  kadar dongu olusturdu
{
    
    for (int k = 0; k < 6; k++)//6 tane birbirinden farkli random sayi olusturuldu 
    {
        int rastgeleSayi;
        do
        {
            rastgeleSayi = randomSayi.Next(1, 50);
        } while (Array.Exists(kolonSayisi, element => element == rastgeleSayi));//rastgele olusturlan sayisalarin ayni sayi olup olmadigini kontrol eden durum
        kolonSayisi[k] = rastgeleSayi;
    }
    Array.Sort(kolonSayisi);

    foreach (var item in kolonSayisi)//listeleme yapildi
    {
        Console.Write(item + ",");

    }
    Console.WriteLine("");

}


