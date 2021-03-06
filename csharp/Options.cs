using System;
using CommandLine;

namespace Rosalind
{
    [Verb("genomeAssembly", HelpText="Run a dynamic programming based genome reconstruction algorithm")]
    class GenomeAssemblyOptions
    {
        private string _inputFile;

        [Option('i', "inputFile", Required=true, HelpText="An input fasta file with reads")]
        public string InputFile 
        {   
            get{return this._inputFile;}
            set
            {
                if (value.EndsWith(".fa") || value.EndsWith(".fasta"))
                {
                    this._inputFile = value;
                }
                else {
                    throw new ArgumentException($"Fasta file expected, found {value}");
                }

            }
        }

        [Option('o', "outputFile", Required=false, HelpText="An output file to dump the reconstructed genome")]
        public string OutputFile {get; set;}
    }

    [Verb("orf", HelpText="Run a program to identify all possible open reading frames from a fasta sequence")]
    class OrfOptions
    {
        private string _inputFile;

        [Option('i', "inputFile", Required=true, HelpText="An input fasta file with reads")]
        public string InputFile 
        {   
            get{return this._inputFile;}
            set
            {
                if (value.EndsWith(".fa") || value.EndsWith(".fasta"))
                {
                    this._inputFile = value;
                }
                else {
                    throw new ArgumentException($"Fasta file expected, found {value}");
                }

            }
        }

        [Option('o', "outputFile", Required=false, HelpText="An output file to dump the reconstructed genome")]
        public string OutputFile {get; set;}
    }

    [Verb("ssMotif", HelpText="Run a program to identify a common shared spliced motif from two fasta sequences")]
    class SharedSplicedMotifOptions
    {
        private string _inputFile;

        [Option('i', "inputFile", Required=true, HelpText="An input fasta file with reads")]
        public string InputFile 
        {   
            get{return this._inputFile;}
            set
            {
                if (value.EndsWith(".fa") || value.EndsWith(".fasta"))
                {
                    this._inputFile = value;
                }
                else {
                    throw new ArgumentException($"Fasta file expected, found {value}");
                }

            }
        }

        [Option('o', "outputFile", Required=true, HelpText="An output file to dump the reconstructed genome")]
        public string OutputFile {get; set;}

    }

    [Verb("rc", HelpText="Run a program to identify corrections in reads")]
    class ReadCorrectionOptions
    {
        private string _inputFile;
        [Option('i', "inputFile", Required=true, HelpText="An input fasta file with reads")]
        public string InputFile
        {
            get{ return this._inputFile; }
            set
            {
                if (value.EndsWith(".fa") || value.EndsWith(".fasta"))
                {
                    this._inputFile = value;
                }
                else {
                    throw new ArgumentException($"Fasta file expected, found {value}");
                }
            }
        }
    }

    [Verb("im", HelpText="Run a program to identify the shortest common superstring of two motifs")]
    class InterleavingMotifsOptions
    {
        private string _inputFile;
        private int matchScore;
        private int indelPenalty;

        [Option('i', "inputFile", Required=true, HelpText="An input fasta file with reads")]
        public string InputFile
        {
            get{ return this._inputFile; }
            set
            {
                if (value.EndsWith(".txt"))
                {
                    this._inputFile = value;
                }
                else {
                    throw new ArgumentException($"Fasta file expected, found {value}");
                }
            }
        }

        [Option('m', "matchScore", HelpText="An integer value for the match score")]
        public int MatchScore
        {
            get {return this.matchScore;}
            set
            {
                if (value < 1) 
                {
                    throw new ArgumentException($"Match score must be a value greater than 0");
                }
                this.matchScore = value;
            }
        }

        [Option('x', "indelPenalty", HelpText="An integer value for the indel penalty")]
        public int IndelPenalty
        {
            get {return this.indelPenalty;}
            set
            {
                if (value > 0 )
                {
                    throw new ArgumentException($"Indel penalty must be less than 1");
                }
                this.indelPenalty = value;
            }
        }
    }

    [Verb("edist", HelpText="Solve the edit distance problem")]
    class EditDistanceOptions
    {
        private string _inputFile;
        [Option('i', "inputFile", Required=true, HelpText="An input fasta file containing 2 strings")]
        public string InputFile
        {
            get{ return this._inputFile; }
            set
            {
                if (value.EndsWith(".fa") || value.EndsWith(".fasta"))
                {
                    this._inputFile = value;
                }
                else {
                    throw new ArgumentException($"Fasta file expected, found {value}");
                }
            }
        }
    }
}