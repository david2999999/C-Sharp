namespace DefaultNamespace;

public class ReadFile
{
    public void readFile()
    {
        string path = "c:\\myFile.txt";
        
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.EndOfStream != true)
            {
            Console.WriteLine(sr.ReadLine());
            }
            
            sr.Close();
        }
    }
}