using System.IO;
using System;


public class FunWithFiles
{
    string fileName = "myFile.txt";

    public FunWithFiles()
    {
        createFiles();
        // write2File();
        //readFromFile();
    }

    //Creates a file
    private void createFiles()
    {
        File myFileobj = new File(fileName);
        try
        {
            if
            {
                myFileobj.createNewFile();
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File could not be created");
        }
    }
}