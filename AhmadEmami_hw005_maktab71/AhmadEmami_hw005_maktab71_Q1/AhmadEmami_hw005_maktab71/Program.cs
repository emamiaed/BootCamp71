string sourceFile = @"..\..\..\file.txt";
string destinationFile = @"..\..\..\Archive\file.txt";

if (!File.Exists("file.txt"))
{
    var myFile = File.Create(sourceFile);
    myFile.Close();
}

try
{
    File.Copy(sourceFile, destinationFile);
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("We Can't Find Such Directory");
}
catch (IOException)
{
    Console.WriteLine("File Already Exist");

}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("No Write Access on This Directory");
}
catch (Exception)
{
    Console.WriteLine("Are All Things OK?!");
}
//-----------------------------------------------------------------

