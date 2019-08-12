using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MyBenchmarks
{
    public class HashVs
    {
        private const int N = 10000;
        private readonly byte[] data;


        private readonly MD5 md5 = MD5.Create();
        private readonly SHA1 sha1 = SHA1.Create();
        private readonly SHA256 sha256 = SHA256.Create();
        private readonly SHA384 sha384 = SHA384.Create();
        private readonly SHA512 sha512 = SHA512.Create();
        public HashVs()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }


        [Benchmark]
        public byte[] Md5() => md5.ComputeHash(data);

        [Benchmark]
        public byte[] Sha1() => sha1.ComputeHash(data);

        [Benchmark]
        public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        public byte[] Sha384() => sha384.ComputeHash(data);

        [Benchmark]
        public byte[] Sha512() => sha512.ComputeHash(data);

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<HashVs>();
        }
    }
}