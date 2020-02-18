#nullable enable
using System;

namespace csharp_test
{
    interface IExtractor
    {
        string Id { get; }
        void GetExtractions(object value, ExtractorCollector collector);
    }

    class ExtractorCollector
    {
        public void Add()
        {

        }
    }

    class MyExtractor : IExtractor
    {
        public string Id { get; } = "foo";
        public void GetExtractions(object value, ExtractorCollector collector)
        {
            collector.Add();
        }
    }

    class ExtractionResult
    {
        public Extraction? Extraction { get; }
        //public J
        public

        public ExtractionResult()
        {

        }
    }

    class Extraction
    {
        public string Id { get; }
        public string Name { get; }
    }

    interface IExtractorService
    {
        Extraction[] GetExtractions(object value, string? preferredExtractorId);
        string GetExtractionsJson(object value, string? preferredExtractorId);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World aa!");
        }
    }
}
