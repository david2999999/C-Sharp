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

	public void readFileWithErrorHandling() {
		try
		{
			using (StreamReader sr = new StreamReader(path))
			{
				while (!sr.EndOfStream)
				{
					Console.WriteLine(sr.ReadLine());
				}

				sr.Close();
			}
		} catch (FileNotFoundException e)
		{
			Console.WriteLine(e.Message);
		}
	}
}