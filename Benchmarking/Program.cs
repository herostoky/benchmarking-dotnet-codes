using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");

// BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
// BenchmarkRunner.Run<ForAndForeach>();

const string targetHash = "e4203ed6c3a5fea2a530419e3ad92d3f";
const string filename = "Test_file.json";
const string userId = "1422";
var filenameLower = filename.ToLower();
var filenameNoExt = filename.Split('.')[0];
var filenameNoExtLower = filenameNoExt.ToLower();
var uploadTime = new DateTime(2025, 5, 12, 8, 9, 0);

var dateFormats = new[]
{
    "yyyy-MM-dd HH:mm",
    "dd/MM/yyyy HH:mm",
    "yyyyMMddHHmm",
    "dd-MM-yyyy HH:mm",
    "yyyy-MM-ddTHH:mm",
    "yyyy-MM-dd HH:mm:ss",
    "dd/MM/yyyy à HH:mm"
};

var patterns = new[]
{
    "{0}|{1}|{2}",
    "{0}_{1}_{2}",
    "{2}_{0}_{1}",
    "{1}|{0}|{2}",
    "{2}|{1}|{0}",
    "{2}|{0}",
    "{0}|{2}",
    "{2}_{0}",
    "{0}_{2}",
    "{2}|{0}|{1}|upload",
    "{3}|{1}|{2}",
    "{4}|{1}|{2}",
    "{5}|{1}|{2}"
};

foreach (var format in dateFormats)
{
    var formattedDate = uploadTime.ToString(format);

    foreach (var pattern in patterns)
    {
        var candidate = string.Format(pattern,
            filename,                   // {0}
            formattedDate,              // {1}
            userId,                     // {2}
            filenameLower,              // {3}
            filenameNoExt,              // {4}
            filenameNoExtLower          // {5}
        );

        var hash = CalculateMd5Hash(candidate);
        if (hash == targetHash)
        {
            Console.WriteLine($"Match found!\nInput: {candidate}\nMD5: {hash}");
            return;
        }
    }
}

Console.WriteLine("No match found.");
return;

static string CalculateMd5Hash(string input)
{
    var inputBytes = Encoding.UTF8.GetBytes(input);
    var hashBytes = MD5.HashData(inputBytes);
    var sb = new StringBuilder();
    foreach (var b in hashBytes)
    {
        sb.Append(b.ToString("x2"));
    }
    return sb.ToString();
}
