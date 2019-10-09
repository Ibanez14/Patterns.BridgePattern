using BridgePattern.ChristoferOkhravi;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.ConceptualExample
{
    public interface IView
    {
        string Show();
        IResource Resource { get; }
    }

    public class LongView : IView
    {
        public LongView(IResource resource)
        {
            Resource = resource;
        }

        public IResource Resource { get; private set; }
        public  string Show()
        {
            // Here we use all the properties of our Resource 
            var builder = new StringBuilder();
            builder.AppendLine("- - - - - - - - - - - ")
                   .AppendLine("L O N G  V I E W")
                   .AppendLine("Navigation Property")
                   .AppendLine($"Title Property with {Resource.Title}")
                   .AppendLine($"Long Image part of {Resource.Image}")
                   .AppendLine($"Footer with link {Resource.Image}")
                   .AppendLine("- - - - - - - - - -  - -");

            return builder.ToString();
        }
    }
    public class ShortView : IView
    {
        public ShortView(IResource resource)
        {
            Resource = resource;
        }
        public IResource Resource { get; private set; }
        public string Show()
        {
            // Here we use only some of the properties of our Resource
            var builder = new StringBuilder();
            builder.AppendLine("- - - - - - - - - - - ")
                   .AppendLine("S H O R T   V I E W")
                   .AppendLine($"Title Property with {Resource.Title}")
                   .AppendLine($"Footer with link {Resource.Image}")
                   .AppendLine("- - - - - - - - - - - ");

            return builder.ToString();
        }
    }



}
