using System;

namespace DNA
{
  class Program
  {
    static void Main(string[] args)
    {
      // necluotide dna strand
      string startStrand = "ATGCGATGAGCTTAC";

      // find location of "tga"
      int tga = startStrand.IndexOf("TGA");

      // start point and stop point variables
      int startPoint = 0;
      int length = tga + 3;

      // define final strand
      string dna = startStrand.Substring(startPoint, length);
      Console.WriteLine(dna);

      // DNA mutation search
      char mutation = dna[6];
      Console.WriteLine(mutation);

    }
  }
}
