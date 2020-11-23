using System;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage()]
public class Test
{
    public static Tuple<string, int>[] Data = new[]
    {
        new Tuple<string,int>("Planet Earth", 0),
        new Tuple<string,int>("India", 1),
        new Tuple<string,int>("Kerala", 2),
        new Tuple<string,int>("Kochi", 3),
        new Tuple<string,int>("Tamil Nadu", 2),
        new Tuple<string,int>("Chennai", 3),
        new Tuple<string,int>("Madurai", 3),
        new Tuple<string,int>("Tiruppur", 3),
        new Tuple<string,int>("U.S.A", 1),
        new Tuple<string,int>("Texas", 2),
        new Tuple<string,int>("Austin", 3),
        new Tuple<string,int>("Dallas", 3),
    };
}


