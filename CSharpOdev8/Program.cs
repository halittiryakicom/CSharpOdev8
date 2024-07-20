//burada tanımlamalar ve kullanıcıdan değer alma var
Console.WriteLine("Lütfen bir değer giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());
int count = 0;

//While
while (count < limit)
{
    Console.WriteLine($"{count}Ben bir Patika'lıyım");
    count++;
}

//Do While
count = 0;
do
{
    Console.WriteLine($"{count}Ben bir Patika'lıyım");
    count++;
} while (count < limit);

//While ile do while arasında ki en önemli fark do while döngümüzde önce işlemlerin yapılması daha sonrasında koşul kontrol edilmesi yapılır. While da ise önce koşul kontrol edilir daha sonra işlemler yapılır. Diğer bir fark ise do while da en az 1 kez kodlama çalışır fakat while da koşula bağlı olarak hiç çalışmayabilir.