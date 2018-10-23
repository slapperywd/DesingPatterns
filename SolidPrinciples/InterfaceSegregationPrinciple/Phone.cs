namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    using System;

    public class Phone : ICall, IPhoto, IVideo
    {
        public void Call()
        {
            Console.WriteLine("Calling ...");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Making a video ...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking a photo");
        }
    }
}
