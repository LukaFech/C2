namespace C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_ar = 0;
            int second_ar = 0;
            int third_ar = 0;
            int fourth_ar = 0;
            //№1
            Console.WriteLine("Enter num");
            first_ar = int.Parse(Console.ReadLine());
            FizzBuzz ok = new FizzBuzz(first_ar);
            Console.WriteLine(ok.GetFizzBuzz());
            //№2
            Console.WriteLine("Enter 2 nums");
            first_ar = int.Parse(Console.ReadLine());
            second_ar = int.Parse(Console.ReadLine());
            Percent lend = new Percent(first_ar, second_ar);
            lend.Calculate();
            //№3
            Console.WriteLine("Enter 4 nums");
            first_ar = int.Parse(Console.ReadLine());
            second_ar = int.Parse(Console.ReadLine());
            third_ar = int.Parse(Console.ReadLine());
            fourth_ar = int.Parse(Console.ReadLine());
            Digitnums roa = new Digitnums(first_ar, second_ar, third_ar, fourth_ar);
            Console.WriteLine(roa.GetNum());
            //№4
            Console.WriteLine("Enter what do you need to swap");
            first_ar = int.Parse(Console.ReadLine());
            second_ar = int.Parse(Console.ReadLine());
            Sixnums rs = new Sixnums(first_ar, second_ar);
            Console.WriteLine(rs.GetNum());
            //№5
            Data ogr = new Data();
            Console.WriteLine(ogr.GetDay());
            //№6
            Tempriture asv = new Tempriture();
            Console.WriteLine(asv.Get_temp());
            //№7
            Randomtask vds = new Randomtask();
            vds.Get_Nums();
            //№8
            Armstrong lds = new Armstrong();
            lds.Check();
            //№9
            Perfecto adf = new Perfecto();
            adf.Check();
        }
    }
}
