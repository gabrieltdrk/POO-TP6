class Product
{
    public float price { get; set; } = 0;
    public bool isImported { get; set; }
    public virtual void Get_Price()
    {
        Console.WriteLine(price);
    }
}

class Book : Product
{
    public float paper_tax { get; set; } = 0;
    public override void Get_Price()
    {
        Console.WriteLine(price + paper_tax);
    }
}

class Eletronics : Product
{
    public float repair_cost { get; set; } = 0;
    public float maintenance { get; set; } = 0;
    public float firmware_price { get; set; } = 0;
    public override void Get_Price()
    {
        Console.WriteLine(price + repair_cost + maintenance + firmware_price);
    }
}

class Perfume : Product
{
    public float essence_tax { get; set; } = 0;
    public float bottle_tax { get; set; } = 0;
    public override void Get_Price()
    {
        Console.WriteLine(price + essence_tax + bottle_tax);
    }
}


class Program
{
    static void Main(string[] args)
    {
        // PRODUTO
        Product product = new Product();
        product.price = 250;
        product.isImported = true;
        product.Get_Price();

        // LIVRO
        Book book = new Book();
        book.price = 25;
        book.isImported = false;
        book.paper_tax = 10;
        book.Get_Price();

        //ELETRONICOS
        Eletronics eletronics = new Eletronics();
        eletronics.price = 3500;
        eletronics.isImported = true;
        eletronics.firmware_price = 10000;
        eletronics.repair_cost = 200;
        eletronics.maintenance = 895;
        eletronics.Get_Price();

        //PERFUME
        Perfume perfume = new Perfume();
        perfume.price = 650;
        perfume.isImported = false;
        perfume.essence_tax = 35;
        perfume.bottle_tax = 150;
        perfume.Get_Price();
    }
}