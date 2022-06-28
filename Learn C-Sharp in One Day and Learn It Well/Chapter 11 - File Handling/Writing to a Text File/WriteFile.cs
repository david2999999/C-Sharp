namespace DefaultNamespace;

public class WriteFile
{
    public void write()
    {
        //declaring the path to the file
        string path = "myfile.txt";
        
        //Writing to the file
        using(StreamWriter sw=new StreamWriter(path, true))
        {
            sw.WriteLine("ABC");
            sw.WriteLine("DEF");
            sw.Close();
        }
        
        //Reading from the file
        if (File.Exists(path))
        {
            using(StreamReader sr=new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                sr.Close();
            }
        }
        
        Console.Read();
    }
}