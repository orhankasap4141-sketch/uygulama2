static bool NumaraVarMi(List<string> liste, string aranan)
{
    foreach (string sayi in liste)
    {
        if (sayi == aranan)
        {
            return true;
        }
    }
    return false;
}
 
 {
    List<string> sayilar = new List<string> { "41", "13", "34" };
    Console.WriteLine("aramak istediğiniz sayıyı girin:");
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out int aranan))
    {
        Console.WriteLine("geçersiz sayı girdiniz.");
        return;
    }
    bool bulundu = NumaraVarMi(sayilar, aranan.ToString());
    Console.WriteLine(bulundu ? "Sayı bulundu." : "Sayı bulunamadı.");
}
