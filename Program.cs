using TP_MODUL5_103022400130;

class Program
{
    static void Main(string[] args)
    {
        // Generic Method
        HaloGeneric.SapaUser("Faiq");

        // Generic Class
        DataGeneric<string> data = new DataGeneric<string>("103022400130");
        data.PrintData();
    }
}