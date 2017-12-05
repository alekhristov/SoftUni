using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TheaThePhotographer
{
	class Program
	{
		static void Main(string[] args)
		{
			long numberOfPicturesTaken = long.Parse(Console.ReadLine());
			long filterTime = long.Parse(Console.ReadLine());
			long goodPicturesPercent = long.Parse(Console.ReadLine());
			long uploadTime = long.Parse(Console.ReadLine());

			long totalFilterTime = numberOfPicturesTaken * filterTime;
			decimal goodPictures = Math.Ceiling((numberOfPicturesTaken * ((decimal)goodPicturesPercent / 100)));
			long totalUploadTime = (long)goodPictures * uploadTime;
			long totalTimeInSeconds = totalFilterTime + totalUploadTime;

			TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);

			string totalTime = time.ToString(@"d\:hh\:mm\:ss");
			Console.WriteLine(totalTime);
		}
	}
}
