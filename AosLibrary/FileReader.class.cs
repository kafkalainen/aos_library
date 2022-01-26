using System;

using System.IO;
public class FileReader
{
	private string dataBuffer;

	public FileReader(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException($"ERROR: {path} was null");
		}
		else if (path.Trim() == "")
		{
			throw new ArgumentException($"ERROR {path} was empty");
		}
		else
		{
			dataBuffer = File.ReadAllText(path);
		}
	}

	public void PrintDataBuffer()
	{
		Console.WriteLine(this.dataBuffer);
	}
}
